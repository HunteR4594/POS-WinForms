using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms; // Assuming this is a WinForms application

namespace POS_project
{
    public partial class Form1 : Form
    {
        private SqlConnection connect;

        public Form1()
        {
            InitializeComponent();
            // Connection string: Good practice to keep sensitive info (like Data Source) in App.config/Web.config
            // Current Location: Caloocan, Metro Manila, Philippines
            // The Data Source 'DESKTOP-5MGMHRD' suggests a local machine or a specific computer name on the network.
            // Ensure this machine is accessible from where the application is run,
            // and SQL Server is configured for remote connections if running on a different machine.
            connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // This event handler is empty. If it's not needed for custom drawing, it can be removed.
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // Input validation: Check if fields are empty
            if (string.IsNullOrEmpty(username_login.Text) || string.IsNullOrEmpty(passwordlogin.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND status = @status";
                    using SqlCommand command = new(selectData, connect);
                    command.Parameters.AddWithValue("@username", username_login.Text);
                    command.Parameters.AddWithValue("@password", passwordlogin.Text); // This should be a HASHED password comparison
                    command.Parameters.AddWithValue("@status", "Active");

                    int rowCount = (int)command.ExecuteScalar();

                    if (rowCount > 0)
                    {
                        // Second SQL query: Retrieve user role if login is successful
                        // Re-querying username and password for role retrieval is redundant and prone to issues.
                        // You should retrieve the role in the first query if the user is authenticated.
                        string selectRole = "SELECT role FROM users WHERE username = @username AND password = @password"; // Typo here: @pass should be @password

                        using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                        {
                            getRole.Parameters.AddWithValue("username", username_login.Text.Trim());
                            getRole.Parameters.AddWithValue("password", passwordlogin.Text.Trim()); // This should also be a HASHED password comparison

                            string userRole = getRole.ExecuteScalar() as string;


                            MessageBox.Show("Login Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (userRole == "Admin")
                            {
                                MainForm sForm = new MainForm();
                                sForm.Show();
                                this.Hide();
                            }
                            else if (userRole == "Cashier")
                            {
                                CashierForm sForm = new CashierForm();
                                sForm.Show();
                                this.Hide();
                            }
                            else 
                            {
                                MessageBox.Show("Your account role is not recognized. Please contact support.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }
                    else
                    {
                        // Invalid credentials or inactive status
                        MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex) // Catch specific SQL exceptions for better error handling
                {
                    // More detailed error message for SQL issues
                    MessageBox.Show($"Database Error: {ex.Message}\n\n{ex.StackTrace}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex) // Catch all other exceptions
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}\n\n{ex.StackTrace}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    // Ensure connection is closed
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This event handler is empty. If it's not needed, it can be removed.
        }

        private void label2_Click(object sender, EventArgs e) // Assuming this is for "Register" link/button
        {
            Register sForm = new();
            sForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e) // Assuming this is for "Exit"
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This event handler is empty. If it's not needed, it can be removed.
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            passwordlogin.PasswordChar = showpassword.Checked ? '\0' : '*';
        }
    }
}