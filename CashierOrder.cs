using Microsoft.Data.SqlClient;
using System.Data;

namespace POS_project
{
    public partial class CashierOrder : UserControl
    {
        private SqlConnection connect;

        public CashierOrder()
        {
            InitializeComponent();

            connect = new(@"Data Source=DESKTOP-5MGMHRD;Initial Catalog=testdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            displayAllAvailableProducts();
            displayCategories();
        }


        public void displayAllAvailableProducts()
        {
            ProductData pData = new ProductData();
            List<ProductData> listdata = pData.allAvailableProducts();

            dataGridView1.DataSource = listdata;
        }


        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {

            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    String selectData = "SELECT * FROM categories";
                    using (SqlCommand command = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Cashier_CategoryOr.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader.GetString(1);
                                Cashier_CategoryOr.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensures connection is closed. Good practice.
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            // else if connection is not closed (i.e., open or broken), nothing happens,
            // which might be an issue if displayCategories is called when it's already open.
        }

        private void Cashier_CategoryOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method is triggered when a category is selected from the ComboBox.
            string selectedCategory = Cashier_CategoryOr.SelectedItem?.ToString();

            if (selectedCategory != null)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        // Corrected (assuming 'category' is the column storing category names in the products table):
                        string selectData = "SELECT prod_id FROM products WHERE category = @category AND status = @status";

                        using (SqlCommand command = new SqlCommand(selectData, connect))
                        {
                            command.Parameters.AddWithValue("@category", selectedCategory);
                            command.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                Cashier_ProductIDOr.Items.Clear();

                                while (reader.Read())
                                {

                                    string value = reader["prod_id"].ToString();
                                    Cashier_ProductIDOr.Items.Add(value);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void Cashier_QuantityOr_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}