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

namespace POS_project
{

    public partial class Register : Form
    {
        private SqlConnection connect;

        public Register()
        {
            InitializeComponent();
            connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paula\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
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
            try
            {
                // Open connection
                connect.Open();

                // Check if username exists
                string checkUsername = "SELECT * FROM admin WHERE Username = @username";
                using (SqlCommand command = new SqlCommand(checkUsername, connect))
                {
                    command.Parameters.AddWithValue("@username", username_register.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show(username_register.Text + " is already existing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert new user
                DateTime date = DateTime.Today;

                using (SqlCommand cmd = new SqlCommand("INSERT INTO admin (Email, Username, Password, Date_created) VALUES (@email, @username, @password, @date_created)", connect))
                {
                    cmd.Parameters.AddWithValue("@email", username_register.Text.Trim()); // Add proper textbox
                    cmd.Parameters.AddWithValue("@username", password_register.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", cpassword_register.Text.Trim());
                    cmd.Parameters.AddWithValue("@date_created", date);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }
    }
}