using POS_project.Migrations;

namespace POS_project
{
    public partial class AddProducts : UserControl
    {
        private readonly AppDbContext _context;
        private int getid = 0;

        public AddProducts()
        {
            InitializeComponent();
            _context = new AppDbContext();
            displayCategories();
            displayAllProducts();
            // Attach the CellClick event handler here if it's not done in Designer.cs
            // dataGridViewproducts.CellClick += dataGridViewproducts_CellClick;
        }

        public class CategoryItem
        {
            public int id { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name;
        }

        public void displayCategories()
        {
            // Clear existing items to prevent duplicates on refresh
            Add_Category.Items.Clear();

            var categories = _context.Categories.ToList();
            foreach (var category in categories)
            {
                Add_Category.Items.Add(new CategoryItem
                {
                    id = category.id,
                    Name = category.CategoryName
                });
            }
        }

        public void displayAllProducts()
        {
            dataGridViewproducts.DataSource = _context.Products
                .Select(p => new
                {
                    p.id,
                    p.prod_id,
                    p.prod_name,
                    prod_price = p.prod_price.ToString("F2"),
                    p.category,
                    p.stock,
                    p.status,
                    FormattedDate = p.date_insert.ToString("yyyy-MM-dd"),
                    p.image_path // Include image_path to retrieve it
                })
                .ToList();
        }

        public bool AreFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(add_product_id.Text) ||
                   string.IsNullOrWhiteSpace(Product_Name.Text) || // Corrected: use Product_Name TextBox
                   Add_Category.SelectedIndex == -1 ||
                   string.IsNullOrWhiteSpace(add_Product_Price.Text) ||
                   string.IsNullOrWhiteSpace(Add_Product_stock.Text) ||
                   Add_Product_Status.SelectedIndex == -1 ||
                   Import_pic.ImageLocation == null;
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all required fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(add_Product_Price.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter a valid price.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(Add_Product_stock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_context.Products.Any(p => p.prod_id == add_product_id.Text.Trim()))
                {
                    MessageBox.Show("Product id: " + add_product_id.Text.Trim() + " already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string productid = add_product_id.Text.Trim();
                string relativePath = Path.Combine("Product_Directory", productid + ".jpg");
                string fullimage_path = Path.Combine(baseDirectory, relativePath);

                string directoryPath = Path.GetDirectoryName(fullimage_path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                try
                {
                    File.Copy(Import_pic.ImageLocation, fullimage_path, true);
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show("Error copying image file: " + ioEx.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception fileEx)
                {
                    MessageBox.Show("An unexpected error occurred during image copy: " + fileEx.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CategoryItem selectedCategory = Add_Category.SelectedItem as CategoryItem;

                Product newProduct = new Product
                {
                    prod_id = productid,
                    prod_name = Product_Name.Text.Trim(), // Corrected: use Product_Name TextBox
                    category = selectedCategory?.Name ?? string.Empty,
                    prod_price = price,
                    stock = stock, // Store as int
                    image_path = fullimage_path,
                    status = Add_Product_Status.SelectedItem.ToString(),
                    date_insert = DateTime.Now
                };

                _context.Products.Add(newProduct);
                _context.SaveChanges();

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                displayAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            add_product_id.Text = "";
            Product_Name.Text = ""; // Corrected: Clear Product_Name TextBox
            Add_Category.SelectedIndex = -1;
            add_Product_Price.Text = "";
            Add_Product_stock.Text = "";
            Add_Product_Status.SelectedIndex = -1;
            Import_pic.Image = null;
            Import_pic.ImageLocation = null; // Also clear ImageLocation
            getid = 0; // Reset getid when clearing fields
        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                dialog.Title = "Select Product Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Import_pic.ImageLocation = dialog.FileName;
                    Import_pic.Image = Image.FromFile(dialog.FileName); // Display the image immediately
                }
                else
                {
                    MessageBox.Show("No image selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridViewproducts.Rows[e.RowIndex];

                // Retrieve values directly from DataGridView cells based on column names
                // Ensure these column names match what you're binding in displayAllProducts
                getid = Convert.ToInt32(row.Cells["id"].Value);
                add_product_id.Text = row.Cells["prod_id"].Value?.ToString();
                Product_Name.Text = row.Cells["prod_name"].Value?.ToString(); // Corrected: set Product_Name TextBox
                Add_Category.Text = row.Cells["category"].Value?.ToString();
                add_Product_Price.Text = row.Cells["prod_price"].Value?.ToString(); // Already formatted as "F2"
                Add_Product_stock.Text = row.Cells["stock"].Value?.ToString(); // stock is int, retrieved as object, convert to string
                Add_Product_Status.Text = row.Cells["status"].Value?.ToString();

                string imagePath = row.Cells["image_path"].Value?.ToString(); // Retrieve image_path

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        Import_pic.Image = Image.FromFile(imagePath);
                        Import_pic.ImageLocation = imagePath; // Set ImageLocation as well for update logic
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("Invalid image format or image is corrupted.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Import_pic.Image = null;
                        Import_pic.ImageLocation = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Import_pic.Image = null;
                        Import_pic.ImageLocation = null;
                    }
                }
                else
                {
                    Import_pic.Image = null;
                    Import_pic.ImageLocation = null;
                }
            }
        }


        private void Update_Product_Click(object sender, EventArgs e)
        {
            if (getid == 0) // Check if a product is selected for update
            {
                MessageBox.Show("Please select a product to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all required fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(add_Product_Price.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter a valid price.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(Add_Product_stock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update Product id: " + getid + "?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Product productToUpdate = _context.Products.FirstOrDefault(p => p.id == getid);
                    if (productToUpdate != null)
                    {
                        // Check for duplicate product ID only if it's being changed
                        if (productToUpdate.prod_id != add_product_id.Text.Trim() && _context.Products.Any(p => p.prod_id == add_product_id.Text.Trim()))
                        {
                            MessageBox.Show("Product id already exists for another product.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string productid = add_product_id.Text.Trim();
                        string relativePath = Path.Combine("Product_Directory", productid + ".jpg");
                        string fullimage_path = Path.Combine(baseDirectory, relativePath);

                        string directoryPath = Path.GetDirectoryName(fullimage_path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        // Handle image update logic
                        // Scenario 1: New image selected (ImageLocation is different from existing path, or existing path is null/empty)
                        if (Import_pic.ImageLocation != null && Import_pic.ImageLocation != productToUpdate.image_path)
                        {
                            // Delete old image if it exists and is different
                            if (!string.IsNullOrEmpty(productToUpdate.image_path) && File.Exists(productToUpdate.image_path))
                            {
                                File.Delete(productToUpdate.image_path);
                            }
                            try
                            {
                                File.Copy(Import_pic.ImageLocation, fullimage_path, true);
                                productToUpdate.image_path = fullimage_path;
                            }
                            catch (IOException ioEx)
                            {
                                MessageBox.Show("Error copying image file: " + ioEx.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            catch (Exception fileEx)
                            {
                                MessageBox.Show("An unexpected error occurred during image copy: " + fileEx.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        // Scenario 2: Image was cleared (Import_pic.Image is null, but there was an old path)
                        else if (Import_pic.Image == null && !string.IsNullOrEmpty(productToUpdate.image_path))
                        {
                            if (File.Exists(productToUpdate.image_path))
                            {
                                File.Delete(productToUpdate.image_path);
                            }
                            productToUpdate.image_path = string.Empty; // Clear the path in DB
                        }
                        // Scenario 3: No new image selected, and old image not cleared (path remains the same)
                        // Do nothing, path remains as is

                        CategoryItem selectedCategory = Add_Category.SelectedItem as CategoryItem;

                        productToUpdate.prod_id = productid;
                        productToUpdate.prod_name = Product_Name.Text.Trim(); // Corrected: use Product_Name TextBox
                        productToUpdate.category = selectedCategory?.Name ?? string.Empty;
                        productToUpdate.prod_price = price;
                        productToUpdate.stock = stock;
                        productToUpdate.status = Add_Product_Status.SelectedItem.ToString();
                        // date_insert is typically not updated on product modification

                        _context.SaveChanges();

                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();
                        displayAllProducts();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear_Product_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Remove_Product_Click(object sender, EventArgs e)
        {
            // Use getid, which is set in CellClick
            if (getid == 0) // Check if a product is actually selected
            {
                MessageBox.Show("Please select a product to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete Product id: " + add_product_id.Text + "?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Product productToDelete = _context.Products.FirstOrDefault(p => p.id == getid);
                    if (productToDelete != null)
                    {
                        // Optionally delete the associated image file
                        if (!string.IsNullOrEmpty(productToDelete.image_path) && File.Exists(productToDelete.image_path))
                        {
                            try
                            {
                                File.Delete(productToDelete.image_path);
                            }
                            catch (Exception fileEx)
                            {
                                // Log or show a warning, but don't prevent product deletion if image deletion fails
                                MessageBox.Show($"Warning: Could not delete image file: {fileEx.Message}", "File Deletion Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        _context.Products.Remove(productToDelete);
                        _context.SaveChanges();

                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();
                        displayAllProducts();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}