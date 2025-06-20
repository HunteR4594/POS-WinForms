using Microsoft.Data.SqlClient;

namespace POS_project
{
    public partial class AddProducts : UserControl
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True";

        public AddProducts()
        {
            InitializeComponent();
            // Call displayCategories directly. It will manage its own connection.
            displayCategories();
            displayAllProducts(); // Assuming you'll have a method to display products
        }

        // CategoryItem class is fine as is
        public class CategoryItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name;
        }

        public void displayCategories()
        {

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT id, category FROM categories";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items to prevent duplicates on refresh
                            Add_Category.Items.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Store CategoryItem objects to associate ID with Name
                                    Add_Category.Items.Add(new CategoryItem
                                    {
                                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                                        Name = reader.GetString(reader.GetOrdinal("category"))
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // The 'using' statement handles connect.Close() automatically here
            }
        }


        public void displayAllProducts()
        {
            ProductData pData = new ProductData();
            List<ProductData> listdata = pData.AllProductData();

            dataGridViewproducts.DataSource = listdata; // Clear existing data source to avoid duplicates
        }


        public bool AreFieldsEmpty()
        {
            // Use string.IsNullOrWhiteSpace for text fields
            return string.IsNullOrWhiteSpace(add_product_ID.Text) ||
                   string.IsNullOrWhiteSpace(add_product_name.Text) ||
                   Add_Category.SelectedIndex == -1 ||
                   string.IsNullOrWhiteSpace(add_Product_Price.Text) ||
                   string.IsNullOrWhiteSpace(Add_Product_Stock.Text) ||
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

            // Validate numeric inputs
            if (!decimal.TryParse(add_Product_Price.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter a valid price.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(Add_Product_Stock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Create connection locally for this operation to ensure proper scope and disposal
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    string selectProductQuery = "SELECT COUNT(*) FROM products WHERE prod_id = @prodID";
                    using (SqlCommand checkCommand = new SqlCommand(selectProductQuery, connect))
                    {
                        checkCommand.Parameters.AddWithValue("@prodID", add_product_ID.Text.Trim());
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Product ID: " + add_product_ID.Text.Trim() + " already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }


                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string productID = add_product_ID.Text.Trim();
                    string relativePath = Path.Combine("Product_Directory", productID + ".jpg");
                    string fullImagePath = Path.Combine(baseDirectory, relativePath);

                    string directoryPath = Path.GetDirectoryName(fullImagePath);

                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }


                    try
                    {
                        File.Copy(Import_pic.ImageLocation, fullImagePath, true);
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



                    string insertData = "INSERT INTO products (prod_id, prod_name, category, prod_price, stock, image_path, status, date_insert)" +
                                        " VALUES (@prodID, @prodName, @category, @prodPrice, @stock, @imagePath, @status, @dateInsert)";

                    using (SqlCommand insertCommand = new SqlCommand(insertData, connect))
                    {
                        DateTime date = DateTime.Today;
                        insertCommand.Parameters.AddWithValue("@prodID", productID);
                        insertCommand.Parameters.AddWithValue("@prodName", Product_Name.Text.Trim());


                        CategoryItem selectedCategory = Add_Category.SelectedItem as CategoryItem;
                        insertCommand.Parameters.AddWithValue("@category", selectedCategory?.Name ?? string.Empty);

                        insertCommand.Parameters.AddWithValue("@prodPrice", price);
                        insertCommand.Parameters.AddWithValue("@stock", stock);
                        insertCommand.Parameters.AddWithValue("@imagePath", fullImagePath);
                        insertCommand.Parameters.AddWithValue("@status", Add_Product_Status.SelectedItem.ToString());
                        insertCommand.Parameters.AddWithValue("@dateInsert", date.ToString("yyyy-MM-dd"));

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        ClearFields();
                        displayAllProducts();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error adding product: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ClearFields()
        {
            add_product_ID.Text = "";
            Product_Name.Text = "";
            Add_Category.SelectedIndex = -1;
            add_Product_Price.Text = "";
            Add_Product_Stock.Text = "";
            Add_Product_Status.SelectedIndex = -1;
            Import_pic.Image = null;

        }


        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Added more image types
                dialog.Title = "Select Product Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Import_pic.ImageLocation = dialog.FileName;
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

        private int getID = 0;
        private object dataGridView1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the sender is cast to DataGridView
            if (sender is DataGridView dataGridView)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex]; // Access the row at the clicked index

                    getID = Convert.ToInt32(row.Cells[0].Value); // Assuming the first column contains the product ID

                    add_product_ID.Text = row.Cells[1].Value?.ToString();
                    Product_Name.Text = row.Cells[2].Value?.ToString();
                    Add_Category.Text = row.Cells[3].Value?.ToString();
                    add_Product_Price.Text = row.Cells[4].Value?.ToString();
                    Add_Product_Stock.Text = row.Cells[5].Value?.ToString();
                    Add_Product_Status.SelectedItem = row.Cells[7].Value?.ToString();
                    Import_pic.ImageLocation = row.Cells[6].Value?.ToString(); // Assuming the 6th column contains the image path
                }
            }
            else
            {
                MessageBox.Show("Unexpected sender type. Expected DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Product_Click(object sender, EventArgs e)
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
            if (!int.TryParse(Add_Product_Stock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this product?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();

                        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string productID = add_product_ID.Text.Trim();

                        // Determine file extension from the image currently in the PictureBox, or default.
                        string fileExtension = ".jpg"; // Default extension
                        if (Import_pic.Image != null)
                        {
                            // Attempt to get the format from the image in the PictureBox
                            if (System.Drawing.Imaging.ImageFormat.Jpeg.Equals(Import_pic.Image.RawFormat))
                                fileExtension = ".jpg";
                            else if (System.Drawing.Imaging.ImageFormat.Png.Equals(Import_pic.Image.RawFormat))
                                fileExtension = ".png";
                            else if (System.Drawing.Imaging.ImageFormat.Gif.Equals(Import_pic.Image.RawFormat))
                                fileExtension = ".gif";
                            else if (System.Drawing.Imaging.ImageFormat.Bmp.Equals(Import_pic.Image.RawFormat))
                                fileExtension = ".bmp";
                        }

                        string relativePath = Path.Combine("Product_Directory", productID + fileExtension);
                        string fullImagePath = Path.Combine(baseDirectory, relativePath);

                        string directoryPath = Path.GetDirectoryName(fullImagePath);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        try
                        {
                            // Save the image from the PictureBox to the target file path.
                            // The image in PictureBox is already in memory (from Import_Click),
                            // so this avoids locking the original source file.
                            if (Import_pic.Image != null)
                            {
                                Import_pic.Image.Save(fullImagePath);
                            }
                            else
                            {
                                // If there's no image in PictureBox (e.g., cleared), you might want to:
                                // 1. Delete the existing image file for this product, or
                                // 2. Set image_path in DB to NULL, or
                                // 3. Keep the existing image path in DB.
                                // For this fix, we'll assume a new image must always be present.
                                MessageBox.Show("No image selected for update. Please select an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        catch (Exception fileEx)
                        {
                            MessageBox.Show("Error saving updated product image: " + fileEx.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string updateData = "UPDATE products SET prod_name = @prodName, category = @category, prod_price = @prodPrice, " +
                                            "stock = @stock, image_path = @imagePath, status = @status, date_insert = @dateInsert " +
                                            "WHERE prod_id = @prodID";

                        using (SqlCommand updateCommand = new SqlCommand(updateData, connect))
                        {
                            DateTime date = DateTime.Today;
                            updateCommand.Parameters.AddWithValue("@prodID", productID);
                            updateCommand.Parameters.AddWithValue("@prodName", Product_Name.Text.Trim());

                            CategoryItem selectedCategory = Add_Category.SelectedItem as CategoryItem;
                            updateCommand.Parameters.AddWithValue("@category", selectedCategory?.Name ?? string.Empty);

                            updateCommand.Parameters.AddWithValue("@prodPrice", price);
                            updateCommand.Parameters.AddWithValue("@stock", stock);
                            updateCommand.Parameters.AddWithValue("@imagePath", relativePath); // Store relative path
                            updateCommand.Parameters.AddWithValue("@status", Add_Product_Status.SelectedItem.ToString());
                            updateCommand.Parameters.AddWithValue("@dateInsert", date.ToString("yyyy-MM-dd"));

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No product found with the specified Product ID for update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            ClearFields();
                            displayAllProducts();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating product: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Clear_Product_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Remove_Product_Click(object sender, EventArgs e)
        {
            // Input validation: Ensure a product ID is present before attempting to delete
            if (string.IsNullOrWhiteSpace(add_product_ID.Text))
            {
                MessageBox.Show("Please select a product to delete from the table.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string productID = add_product_ID.Text.Trim();
                string imagePathFromDb = null; // To store the image path before deleting the DB record

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();

                        // --- Step 1: Retrieve the image_path from the database before deleting the record ---
                        string getImagePathQuery = "SELECT image_path FROM products WHERE prod_id = @prodID";
                        using (SqlCommand getImageCmd = new SqlCommand(getImagePathQuery, connect))
                        {
                            getImageCmd.Parameters.AddWithValue("@prodID", productID);
                            object result = getImageCmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                imagePathFromDb = result.ToString();
                            }
                        }

                        // --- Step 2: Delete the product record from the database ---
                        string deleteCommand = "DELETE FROM products WHERE prod_id = @prodID";
                        using (SqlCommand deleted = new SqlCommand(deleteCommand, connect))
                        {
                            deleted.Parameters.AddWithValue("@prodID", productID);

                            int rowsAffected = deleted.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // --- Step 3: Delete the associated image file from disk ---
                                if (!string.IsNullOrEmpty(imagePathFromDb))
                                {
                                    string fullImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePathFromDb);
                                    if (File.Exists(fullImagePath))
                                    {
                                        try
                                        {
                                            // Ensure PictureBox doesn't hold a lock on the image if it's currently displayed
                                            if (Import_pic.ImageLocation == fullImagePath) // Check if the displayed image is the one being deleted
                                            {
                                                Import_pic.Image.Dispose(); // Dispose to release file handle
                                                Import_pic.Image = null;    // Clear the picture box
                                            }
                                            File.Delete(fullImagePath);
                                            // You might want to log this or give a message if deletion fails for some reason
                                        }
                                        catch (IOException ioEx)
                                        {
                                            MessageBox.Show("Could not delete image file: " + ioEx.Message, "File Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        catch (Exception fileEx)
                                        {
                                            MessageBox.Show("An unexpected error occurred during image file deletion: " + fileEx.Message, "File Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        // Optional: Message if the file path was in DB but file didn't exist
                                        // MessageBox.Show("Image file not found on disk: " + fullImagePath, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No product found with the specified Product ID for delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            ClearFields();
                            displayAllProducts();
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
}