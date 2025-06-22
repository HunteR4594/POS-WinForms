using POS_project.Migrations;

namespace POS_project
{

    public partial class Register : Form
    {
        private readonly AppDbContext _context;

        public Register()
        {
            InitializeComponent();
            _context = new AppDbContext();
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
            if (string.IsNullOrEmpty(username_register.Text) || string.IsNullOrEmpty(password_register.Text) || string.IsNullOrEmpty(cpassword_register.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    // Check if email already exists using EF Core
                    if (_context.Users.Any(u => u.Email == email_register.Text.Trim()))
                    {
                        MessageBox.Show("Email already exists. Please use a different email.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!email_register.Text.Contains('@'))
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
                        // Create new user and add to context
                        User newUser = new User
                        {
                            Email = email_register.Text,
                            Username = username_register.Text,
                            Password = password_register.Text,
                            Role = "Cashier", // Default role for new registrations
                            Status = "Active", // Default status for new registrations
                            Date = DateTime.Now,
                            IsDeleted = false
                        };

                        _context.Users.Add(newUser);
                        _context.SaveChanges(); // Save changes to the database

                        MessageBox.Show("Registration Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 sForm = new Form1();
                        sForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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