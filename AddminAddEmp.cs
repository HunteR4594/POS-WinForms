using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using Aspose.Pdf.Operators;

namespace POS_project
{
    public partial class AddminAddEmp : UserControl
    {
        private SqlConnection connect;
        public AddminAddEmp()
        {
            InitializeComponent();

            displayAllUsersData();

            connect = new(@"Data Source=DESKTOP-5MGMHRD;Initial Catalog=testdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        public void displayAllUsersData()
        {
            UsersData usersData = new UsersData();
            List<UsersData> usersList = usersData.AllUsersData();

            dataGridView.DataSource = usersList;
        }

        private void Add_user_Click(object sender, EventArgs e)
        {
            if (add_username.Text == "" || add_password.Text == ""
               || Role_user.SelectedIndex == -1 || status_user.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string checkUser = "SELECT * FROM users WHERE username = @username";
                        using (SqlCommand checkCommand = new SqlCommand(checkUser, connect))
                        {
                            checkCommand.Parameters.AddWithValue("@username", add_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkCommand);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO users (username, password, role, status) VALUES (@username, @password, @role, @status)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connect))
                                {
                                    insertCommand.Parameters.AddWithValue("@username", add_username.Text.Trim());
                                    insertCommand.Parameters.AddWithValue("@password", add_password.Text.Trim());
                                    insertCommand.Parameters.AddWithValue("@role", Role_user.SelectedItem.ToString());
                                    insertCommand.Parameters.AddWithValue("@status", status_user.SelectedItem.ToString());
                                    DateTime date = DateTime.Today;
                                    insertCommand.Parameters.AddWithValue("@date_created", date);

                                    int rowsAffected = insertCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("User added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ClearFields();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to add user", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
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

        public void ClearFields()
        {
            add_username.Text = "";
            add_password.Text = "";
            Role_user.SelectedIndex = -1;
            status_user.SelectedIndex = -1;
        }
        private void Clear_user_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Update_user_Click(object sender, EventArgs e)
        {
            if (add_username.Text == "" || add_password.Text == ""
               || Role_user.SelectedIndex == -1 || status_user.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this User ID: " + getID + "?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string checkUser = "SELECT * FROM users WHERE username = @username";
                            using (SqlCommand checkCommand = new SqlCommand(checkUser, connect))
                            {
                                checkCommand.Parameters.AddWithValue("@username", add_username.Text.Trim());
                                SqlDataAdapter adapter = new SqlDataAdapter(checkCommand);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string updateData = "UPDATE users SET username = @username, " +
                                        "password = @password, role = @role, status = @status WHERE id =@id";
                                    using (SqlCommand updateCommand = new SqlCommand(updateData, connect))
                                    {
                                        updateCommand.Parameters.AddWithValue("@username", add_username.Text.Trim());
                                        updateCommand.Parameters.AddWithValue("@password", add_password.Text.Trim());
                                        updateCommand.Parameters.AddWithValue("@role", Role_user.SelectedItem.ToString());
                                        updateCommand.Parameters.AddWithValue("@status", status_user.SelectedItem.ToString());
                                        updateCommand.Parameters.AddWithValue("@id", getID);
                                        int rowsAffected = updateCommand.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("User updated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            ClearFields();
                                            displayAllUsersData();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update user", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private int getID = 0;
        private void users_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                int id = (int)row.Cells["0"].Value;
                string username = row.Cells["1"].Value.ToString();
                string password = row.Cells["2"].Value.ToString();
                string role = row.Cells["3"].Value.ToString();
                string status = row.Cells["4"].Value.ToString();

                add_username.Text = username;
                add_password.Text = password;
                Role_user.SelectedItem = role;
                status_user.SelectedItem = status;


            }
        }
    }
}
