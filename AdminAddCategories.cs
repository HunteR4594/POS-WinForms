using Microsoft.Data.SqlClient;
using System.Data;
using System; // Make sure to include System namespace for DateTime

namespace POS_project
{
    public partial class AdminAddCategories : UserControl
    {
        // It's generally better to create the SqlConnection locally within each method that uses it,
        // or at least ensure it's properly opened and closed for each operation.
        // For simplicity and to directly address your existing structure, we'll keep it as a field,
        // but ensure it's managed correctly in each method.
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True";

        public AdminAddCategories()
        {
            InitializeComponent();
            // No need to open connection in constructor unless you're immediately doing something that requires it.
            // displayAllCategories() will handle its own connection.
            displayAllCategories();
        }

        public void displayAllCategories()
        {
            // Assuming CategoriesData handles its own connection internally and returns disconnected data.
            // If CategoriesData also uses this shared 'connect' object, then its methods also need to be refactored.
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listdata = cData.AllCategoriesData();
            if (listdata.Count > 0)
            {
                dataGridView.DataSource = listdata;
            }
        }


        private void Add_Category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Add_Cat.Text))
            {
                MessageBox.Show("Please fill the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create connection locally for this operation to ensure proper scope and disposal
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open(); // Open the connection here

                    // Check if category already exists
                    string selectQuery = "SELECT COUNT(*) FROM categories WHERE category = @cat";
                    using (SqlCommand checkCommand = new SqlCommand(selectQuery, connect))
                    {
                        checkCommand.Parameters.AddWithValue("@cat", Add_Cat.Text.Trim());
                        int count = (int)checkCommand.ExecuteScalar(); // ExecuteScalar is efficient for single value
                        if (count > 0)
                        {
                            MessageBox.Show("Category: " + Add_Cat.Text.Trim() + " already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit if category exists
                        }
                    }

                    // Insert new category
                    string insertData = "INSERT INTO categories (category, date) VALUES (@cat, @date)";
                    using (SqlCommand insertCommand = new SqlCommand(insertData, connect))
                    {
                        DateTime date = DateTime.Today;
                        insertCommand.Parameters.AddWithValue("@cat", Add_Cat.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                        insertCommand.ExecuteNonQuery();

                        ClearFields();
                        displayAllCategories(); // Refresh data after insert

                        MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding category: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // The 'using' statement for SqlConnection ensures connect.Close() is called automatically
                // even if an exception occurs. So, a 'finally' block for connect.Close() is not strictly needed here.
            }
        }


        public void ClearFields()
        {
            Add_Cat.Text = "";
        }

        private void Clear_Category_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public int getID = 0;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < dataGridView.Rows.Count) // Added bounds check
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                // Ensure the cell value is not null before casting
                if (row.Cells[0].Value != null)
                {
                    getID = (int)row.Cells[0].Value;
                }
                if (row.Cells[1].Value != null)
                {
                    Add_Cat.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void Update_Category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Add_Cat.Text))
            {
                MessageBox.Show("Please fill the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (getID == 0) // Ensure an ID is selected for update
            {
                MessageBox.Show("Please select a category to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Update Category ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open(); // Open the connection here

                        string updateData = "UPDATE categories SET category = @cat WHERE id = @id";
                        using (SqlCommand updateCommand = new SqlCommand(updateData, connect))
                        {
                            updateCommand.Parameters.AddWithValue("@cat", Add_Cat.Text.Trim());
                            updateCommand.Parameters.AddWithValue("@id", getID);
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                ClearFields();
                                displayAllCategories(); // Refresh data after update
                                MessageBox.Show("Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Category not found or no changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating category: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Remove_Category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Add_Cat.Text) || getID == 0) // Check if an ID is selected
            {
                MessageBox.Show("Please select a category to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Delete Category ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open(); // Open the connection here

                        string deleteData = "DELETE FROM categories WHERE id = @id";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteData, connect))
                        {
                            deleteCommand.Parameters.AddWithValue("@id", getID);
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                ClearFields();
                                displayAllCategories(); // Refresh data after deletion
                                MessageBox.Show("Removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Category not found or could not be removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error removing category: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}