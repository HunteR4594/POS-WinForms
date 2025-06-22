using POS_project.Migrations; // Keep if EF Core still requires it internally for some reason, otherwise can remove
using System;
using System.Drawing;
using System.IO; // Still needed for File, Directory, Path
using System.Linq;
using System.Windows.Forms;
using ZXing; // Assuming ZXing library is installed and this using is for BarcodeFormat etc.

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
            // Only attach ONCE!
            this.dataGridViewproducts.CellClick += dataGridViewproducts_CellClick;
        }

        // FIX: Made 'Name' property nullable to satisfy CS8618 warning
        public class CategoryItem
        {
            public int id { get; set; }
            public string? Name { get; set; } // Changed to nullable string

            public override string ToString() => Name;
        }

        public void displayCategories()
        {
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
            try
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
                        // REMOVED: p.image_path, // <--- REMOVED
                        p.barcode     // This is now the path to the barcode image
                    })
                    .ToList();

                // Add View Barcode button column if it doesn't exist
                if (dataGridViewproducts.Columns["ViewBarcode"] == null)
                {
                    DataGridViewButtonColumn viewBarcodeColumn = new DataGridViewButtonColumn();
                    viewBarcodeColumn.Name = "ViewBarcode";
                    viewBarcodeColumn.HeaderText = "View Barcode";
                    viewBarcodeColumn.Text = "View";
                    viewBarcodeColumn.UseColumnTextForButtonValue = true;
                    viewBarcodeColumn.Width = 100;
                    dataGridViewproducts.Columns.Add(viewBarcodeColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading available products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception (e.g., to a file or console) for debugging
                Console.WriteLine($"Database Error in displayAllProducts: {ex.Message}");
            }
        }

        public bool AreFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(add_product_id.Text) ||
                   string.IsNullOrWhiteSpace(Product_Name.Text) ||
                   Add_Category.SelectedIndex == -1 ||
                   string.IsNullOrWhiteSpace(add_Product_Price.Text) ||
                   string.IsNullOrWhiteSpace(Add_Product_stock.Text) ||
                   string.IsNullOrWhiteSpace(Add_Product_Status.SelectedItem?.ToString()); // Check selected item directly
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            // Removed check for Import_pic.ImageLocation
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
                string productId = add_product_id.Text.Trim();
                if (_context.Products.Any(p => p.prod_id == productId))
                {
                    MessageBox.Show("Product id: " + productId + " already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Barcode handling - generate and save the barcode image
                string? barcodeFilePath = BarcodeUtility.GenerateAndSaveProductBarcode(productId, productId, BarcodeFormat.CODE_128);
                if (barcodeFilePath == null)
                {
                    MessageBox.Show("Failed to generate barcode image. Product not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Aborting if barcode generation fails
                }

                CategoryItem? selectedCategory = Add_Category.SelectedItem as CategoryItem;

                Product newProduct = new Product
                {
                    prod_id = productId,
                    prod_name = Product_Name.Text.Trim(),
                    category = selectedCategory?.Name ?? string.Empty,
                    prod_price = price,
                    stock = stock,
                    barcode = barcodeFilePath, // Save the path to the barcode image
                    status = Add_Product_Status.SelectedItem.ToString(),
                    date_insert = DateTime.Now
                };

                _context.Products.Add(newProduct);
                _context.SaveChanges();

                MessageBox.Show("Product added successfully with barcode!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                displayAllProducts();
            }
            catch (Exception ex)
            {
                string errorMsg = ex.Message;
                if (ex.InnerException != null)
                    errorMsg += "\nInner: " + ex.InnerException.Message;
                MessageBox.Show("Error adding product: " + errorMsg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error in Add_Product_Click: {errorMsg}\nStackTrace: {ex.StackTrace}");
            }
        }

        private void ClearFields()
        {
            add_product_id.Text = "";
            Product_Name.Text = "";
            Add_Category.SelectedIndex = -1;
            add_Product_Price.Text = "";
            Add_Product_stock.Text = "";
            Add_Product_Status.SelectedIndex = -1;
            barcodePreview.Image = null; // Clear barcode preview
            getid = 0;
        }

        // REMOVED: private void Import_Click(object sender, EventArgs e) {...} // <--- REMOVED

        private void dataGridViewproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Handle View Barcode button click
                if (e.ColumnIndex == dataGridViewproducts.Columns["ViewBarcode"]?.Index) // Added null check for column
                {
                    string? productId = dataGridViewproducts.Rows[e.RowIndex].Cells["prod_id"].Value?.ToString();
                    string? barcodePath = dataGridViewproducts.Rows[e.RowIndex].Cells["barcode"].Value?.ToString(); // Get barcode path from DB

                    if (!string.IsNullOrEmpty(barcodePath) && File.Exists(barcodePath))
                    {
                        ShowBarcodeForm(productId, barcodePath);
                    }
                    else
                    {
                        MessageBox.Show("Barcode image not found for this product. It might not have been generated or the file is missing.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return; // Exit if button was clicked
                }

                // Handle regular row selection
                DataGridViewRow row = dataGridViewproducts.Rows[e.RowIndex];

                getid = Convert.ToInt32(row.Cells["id"].Value);
                add_product_id.Text = row.Cells["prod_id"].Value?.ToString();
                Product_Name.Text = row.Cells["prod_name"].Value?.ToString();
                Add_Category.Text = row.Cells["category"].Value?.ToString();
                add_Product_Price.Text = row.Cells["prod_price"].Value?.ToString();
                Add_Product_stock.Text = row.Cells["stock"].Value?.ToString();
                Add_Product_Status.Text = row.Cells["status"].Value?.ToString();

                // Load barcode preview image if path exists
                string? barcodePathFromDb = row.Cells["barcode"].Value?.ToString();
                if (!string.IsNullOrEmpty(barcodePathFromDb) && File.Exists(barcodePathFromDb))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(barcodePathFromDb, FileMode.Open, FileAccess.Read))
                        {
                            barcodePreview.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading barcode preview: {ex.Message}", "Barcode Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        barcodePreview.Image = null;
                    }
                }
                else
                {
                    barcodePreview.Image = null;
                }
            }
        }

        private void ShowBarcodeForm(string? productId, string barcodePath)
        {
            try
            {
                Form barcodeForm = new Form();
                barcodeForm.Text = $"Barcode for Product: {productId ?? "N/A"}";
                barcodeForm.Size = new Size(400, 300);
                barcodeForm.StartPosition = FormStartPosition.CenterParent;
                barcodeForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                barcodeForm.MaximizeBox = false;

                PictureBox barcodePictureBox = new PictureBox();
                barcodePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                barcodePictureBox.Dock = DockStyle.Fill;

                // Load barcode image from stream to prevent file locking
                using (FileStream fs = new FileStream(barcodePath, FileMode.Open, FileAccess.Read))
                {
                    barcodePictureBox.Image = Image.FromStream(fs);
                }

                barcodeForm.Controls.Add(barcodePictureBox);
                barcodeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying barcode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error in ShowBarcodeForm: {ex.Message}");
            }
        }

        private void Update_Product_Click(object sender, EventArgs e)
        {
            if (getid == 0)
            {
                MessageBox.Show("Please select a product to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Removed check for Import_pic.ImageLocation
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

            if (MessageBox.Show("Are you sure you want to update Product id: " + add_product_id.Text + "?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Product? productToUpdate = _context.Products.FirstOrDefault(p => p.id == getid); // Added '?' for nullable
                    if (productToUpdate != null)
                    {
                        string newProductId = add_product_id.Text.Trim();

                        // Check for duplicate product ID only if it's being changed to a different ID
                        if (productToUpdate.prod_id != newProductId && _context.Products.Any(p => p.prod_id == newProductId))
                        {
                            MessageBox.Show("Product ID already exists for another product. Please choose a unique ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Barcode handling for update (regenerate if product ID changes)
                        string? newBarcodePath = productToUpdate.barcode;
                        if (productToUpdate.prod_id != newProductId)
                        {
                            // Delete old barcode image if path exists and it's different
                            if (!string.IsNullOrEmpty(productToUpdate.barcode) && File.Exists(productToUpdate.barcode))
                            {
                                try
                                {
                                    File.Delete(productToUpdate.barcode);
                                }
                                catch (Exception barcodeDelEx)
                                {
                                    MessageBox.Show($"Warning: Could not delete old barcode image file: {barcodeDelEx.Message}", "Barcode Deletion Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            newBarcodePath = BarcodeUtility.GenerateAndSaveProductBarcode(newProductId, newProductId, BarcodeFormat.CODE_128);
                            if (newBarcodePath == null)
                            {
                                MessageBox.Show("Failed to regenerate barcode image for updated product. Update aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        CategoryItem? selectedCategory = Add_Category.SelectedItem as CategoryItem;

                        productToUpdate.prod_id = newProductId;
                        productToUpdate.prod_name = Product_Name.Text.Trim();
                        productToUpdate.category = selectedCategory?.Name ?? string.Empty;
                        productToUpdate.prod_price = price;
                        productToUpdate.stock = stock;
                        // REMOVED: productToUpdate.image_path = newImagePath; // <--- REMOVED
                        productToUpdate.barcode = newBarcodePath; // Update with the new/existing path
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
                    Console.WriteLine($"Error in Update_Product_Click: {ex.Message}\nStackTrace: {ex.StackTrace}");
                }
            }
        }

        private void Clear_Product_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Remove_Product_Click(object sender, EventArgs e)
        {
            if (getid == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete Product id: " + add_product_id.Text + "?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Product? productToDelete = _context.Products.FirstOrDefault(p => p.id == getid); // Added '?' for nullable
                    if (productToDelete != null)
                    {
                        // REMOVED: Delete associated image file // <--- REMOVED all image deletion logic

                        // Delete associated barcode file
                        if (!string.IsNullOrEmpty(productToDelete.barcode) && File.Exists(productToDelete.barcode))
                        {
                            try
                            {
                                File.Delete(productToDelete.barcode);
                            }
                            catch (Exception barcodeDelEx)
                            {
                                MessageBox.Show($"Warning: Could not delete barcode image file: {barcodeDelEx.Message}", "Barcode Image Deletion Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Console.WriteLine($"Error in Remove_Product_Click: {ex.Message}\nStackTrace: {ex.StackTrace}");
                }
            }
        }

        private void GenerateBarcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(add_product_id.Text.Trim()))
            {
                MessageBox.Show("Please enter a Product ID first to generate a barcode preview.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string productId = add_product_id.Text.Trim();

                // Generate barcode and display preview (does not save to file here)
                Bitmap? barcodeBitmap = BarcodeUtility.GenerateCode128Barcode(productId);
                if (barcodeBitmap != null)
                {
                    barcodePreview.Image = barcodeBitmap;
                    MessageBox.Show($"Barcode preview generated successfully for Product ID: {productId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to generate barcode preview. Please check the Product ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating barcode preview: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error in GenerateBarcode_Click: {ex.Message}");
            }
        }

        private void GenerateAllBarcodes_Click(object sender, EventArgs e)
        {
            try
            {
                var productsWithoutBarcodes = _context.Products.Where(p => string.IsNullOrEmpty(p.barcode)).ToList();

                if (!productsWithoutBarcodes.Any())
                {
                    MessageBox.Show("All products already have barcodes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int generatedCount = 0;
                foreach (var product in productsWithoutBarcodes)
                {
                    try
                    {
                        string? barcodePath = BarcodeUtility.GenerateAndSaveProductBarcode(product.prod_id, product.prod_id, BarcodeFormat.CODE_128);
                        if (barcodePath != null)
                        {
                            product.barcode = barcodePath;
                            generatedCount++;
                        }
                        else
                        {
                            MessageBox.Show($"Failed to generate barcode for product {product.prod_id}. Skipping this product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating barcode for product {product.prod_id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                _context.SaveChanges();
                displayAllProducts();

                MessageBox.Show($"Successfully generated barcodes for {generatedCount} products!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating barcodes for all products: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error in GenerateAllBarcodes_Click: {ex.Message}");
            }
        }
    }
}