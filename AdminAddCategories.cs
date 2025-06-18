using System.Linq;
using System.Windows.Forms;

namespace POS_project
{
    public partial class AdminAddCategories : UserControl
    {
        private readonly AppDbContext _context;
        public int getid = 0;

        public AdminAddCategories()
        {
            InitializeComponent();
            _context = new AppDbContext();
            displayAllCategories();
        }

        public void displayAllCategories()
        {
            var categories = _context.Categories.ToList();
            if (categories.Any())
            {
                dataGridView.DataSource = categories;
            }
            else
            {
                dataGridView.DataSource = null; // Clear data if no categories
            }
        }

        private void Add_Category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Add_Cat.Text))
            {
                MessageBox.Show("Please fill the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_context.Categories.Any(c => c.CategoryName == Add_Cat.Text.Trim()))
                {
                    MessageBox.Show("Category: " + Add_Cat.Text.Trim() + " already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Category newCategory = new Category
                {
                    CategoryName = Add_Cat.Text.Trim(),
                    //CreatedAt = DateTime.Now
                };

                _context.Categories.Add(newCategory);
                _context.SaveChanges();

                ClearFields();
                displayAllCategories();
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearFields()
        {
            Add_Cat.Text = "";
            getid = 0;
        }

        private void Clear_Category_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                Category selectedCategory = (Category)row.DataBoundItem;

                getid = selectedCategory.id;
                Add_Cat.Text = selectedCategory.CategoryName;
            }
        }

        private void Update_Category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Add_Cat.Text))
            {
                MessageBox.Show("Please fill the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (getid == 0)
            {
                MessageBox.Show("Please select a category to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Update Category id: " + getid + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Category categoryToUpdate = _context.Categories.FirstOrDefault(c => c.id == getid);
                    if (categoryToUpdate != null)
                    {
                        categoryToUpdate.CategoryName = Add_Cat.Text.Trim();
                        _context.SaveChanges();

                        ClearFields();
                        displayAllCategories();
                        MessageBox.Show("Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Category not found or no changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating category: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Remove_Category_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Add_Cat.Text) || getid == 0)
            {
                MessageBox.Show("Please select a category to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Delete Category id: " + getid + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Category categoryToDelete = _context.Categories.FirstOrDefault(c => c.id == getid);
                    if (categoryToDelete != null)
                    {
                        _context.Categories.Remove(categoryToDelete);
                        _context.SaveChanges();

                        ClearFields();
                        displayAllCategories();
                        MessageBox.Show("Removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Category not found or could not be removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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