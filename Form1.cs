using Microsoft.Data.SqlClient;
using System.Data;

namespace POS_project
{
    public partial class Form1 : Form
    {
        private SqlConnection connect;

        public Form1()
        {
            InitializeComponent();
            connect = new(@"Data Source=DESKTOP-5MGMHRD;Initial Catalog=testdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (username_login.Text == "" || passwordlogin.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM admin WHERE username = @username AND password = @password";
                        using SqlCommand command = new(selectData, connect);
                        command.Parameters.AddWithValue("@username", username_login.Text);
                        command.Parameters.AddWithValue("@password", passwordlogin.Text);

                        SqlDataAdapter adapter = new(command);
                        DataTable table = new();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm sForm = new MainForm();
                            sForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register sForm = new();
            sForm.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                passwordlogin.PasswordChar = '\0';
            }
            else
            {
                passwordlogin.PasswordChar = '*';
            }
        }
    }
}
