using Microsoft.Data.SqlClient;
using System.Data;

namespace POS_project
{

    public partial class Register : Form
    {
        private SqlConnection connect;

        public Register()
        {
            InitializeComponent();
            connect = new(@"Data Source=DESKTOP-5MGMHRD;Initial Catalog=testdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_register_TextChanged(object sender, EventArgs e)
        {
            // Your code here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 sForm = new Form1();
            sForm.Show();
            this.Hide();
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            if (username_register.Text == "" || password_register.Text == "" || cpassword_register.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string checkUser = "SELECT COUNT(*) FROM admin WHERE email = @email";
                        using (SqlCommand checkCommand = new SqlCommand(checkUser, connect))
                        {
                            DateTime date = DateTime.Today;
                            checkCommand.Parameters.AddWithValue("@email", email_register.Text.Trim());
                            int userExists = (int)checkCommand.ExecuteScalar();
                            if (userExists > 0)
                            {
                                MessageBox.Show("Email already exists. Please use a different email.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (!email_register.Text.Contains('@')) // Fixed the issue by using Contains method
                            {
                                MessageBox.Show("Please enter a valid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (username_register.Text.Length < 5)
                            {
                                MessageBox.Show("Username must be at least 5 characters long.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (password_register.Text.Length < 8)
                            {
                                MessageBox.Show("Password must be at least 8 characters long.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (password_register.Text != cpassword_register.Text)
                            {
                                MessageBox.Show("Passwords do not match. Please try again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (username, password, email, date_created) VALUES (@username, @password, @email, @date_created)";
                                using (SqlCommand insertCommand = new(insertData, connect))
                                {
                                    insertCommand.Parameters.AddWithValue("@email", email_register.Text);
                                    insertCommand.Parameters.AddWithValue("@username", username_register.Text);
                                    insertCommand.Parameters.AddWithValue("@password", password_register.Text);
                                    insertCommand.Parameters.AddWithValue("@date_created", DateTime.Now);
                                    int rowsAffected = insertCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Registration Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Form1 sForm = new Form1();
                                        sForm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Registration Failed. Please try again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                cpassword_register.PasswordChar = '\0';
            }
            else
            {
                cpassword_register.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_register.PasswordChar = '\0';
            }
            else
            {
                password_register.PasswordChar = '*';
            }
        }
    }
}