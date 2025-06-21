using System.Data;
using POS_project.Migrations;

namespace POS_project
{
    public partial class AddminAddEmp : UserControl
    {
        private readonly AppDbContext _context;
        private int getid = 0;

        public AddminAddEmp()
        {
            InitializeComponent();
            _context = new AppDbContext();
            displayAllUsersData();
        }
        public void displayAllUsersData()
        {
            dataGridView.DataSource = _context.Users.Where(u => !u.IsDeleted).ToList();
        }

        private void Add_user_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(add_username.Text) || string.IsNullOrEmpty(add_password.Text)
               || Role_user.SelectedIndex == -1 || status_user.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (_context.Users.Any(u => u.Username == add_username.Text.Trim()))
                    {
                        MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        User newUser = new User
                        {
                            Username = add_username.Text.Trim(),
                            Password = add_password.Text.Trim(),
                            Role = Role_user.SelectedItem.ToString(),
                            Status = status_user.SelectedItem.ToString(),
                            Date = DateTime.Today,
                            IsDeleted = false,
                            Email = ""
                        };

                        _context.Users.Add(newUser);
                        _context.SaveChanges();

                        MessageBox.Show("User added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        displayAllUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (string.IsNullOrEmpty(add_username.Text) || string.IsNullOrEmpty(add_password.Text)
               || Role_user.SelectedIndex == -1 || status_user.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this User id: " + getid + "?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        User userToUpdate = _context.Users.FirstOrDefault(u => u.id == getid);
                        if (userToUpdate != null)
                        {
                            // Check if a different user with the new username already exists
                            if (_context.Users.Any(u => u.Username == add_username.Text.Trim() && u.id != getid))
                            {
                                MessageBox.Show("Username already exists for another user", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                userToUpdate.Username = add_username.Text.Trim();
                                userToUpdate.Password = add_password.Text.Trim();
                                userToUpdate.Role = Role_user.SelectedItem.ToString();
                                userToUpdate.Status = status_user.SelectedItem.ToString();

                                _context.SaveChanges();

                                MessageBox.Show("User updated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                displayAllUsersData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void users_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // Ensure the clicked row index is valid
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex]; // Correctly reference the DataGridView control

                // Directly cast to User if your DataGridView is bound to List<User>
                User selectedUser = (User)row.DataBoundItem;

                add_username.Text = selectedUser.Username;
                add_password.Text = selectedUser.Password;
                Role_user.SelectedItem = selectedUser.Role;
                status_user.SelectedItem = selectedUser.Status;

                getid = selectedUser.id; // Update the getid field with the selected user's id
            }
        }

        private void Remove_user_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(add_username.Text) || string.IsNullOrEmpty(add_password.Text)
               || Role_user.SelectedIndex == -1 || status_user.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this User id: " + getid + "?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        User userToDelete = _context.Users.FirstOrDefault(u => u.id == getid);
                        if (userToDelete != null)
                        {
                            userToDelete.IsDeleted = true;
                            _context.SaveChanges();

                            MessageBox.Show("User Deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            displayAllUsersData();
                        }
                        else
                        {
                            MessageBox.Show("User not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
