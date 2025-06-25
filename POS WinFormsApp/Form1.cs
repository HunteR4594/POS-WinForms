using POS_project.Migrations;

namespace POS_project
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
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
                    // Check for user existence, password, and active status using EF Core
                    var user = _context.Users.FirstOrDefault(u => u.Username == username_login.Text && u.Password == passwordlogin.Text && u.Status == "Active");

                    if (user != null)
                    {
                        MessageBox.Show("Login Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (user.Role == "Admin")
                        {
                            MainForm sForm = new MainForm();
                            sForm.Show();
                            this.Hide();
                        }
                        else if (user.Role == "Cashier")
                        {
                            CashierForm sForm = new CashierForm(user.id, user.Username);
                            sForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your account role is not recognized. Please contact support.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        // Invalid credentials or inactive status
                        MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) // Catch all exceptions for now, can be more specific later
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}\n\n{ex.StackTrace}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}