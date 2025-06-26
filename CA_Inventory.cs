using System.Data;
using POS_project.Migrations;

namespace POS_project
{
    public partial class CA_Inventory : UserControl
    {
        public CA_Inventory()
        {
            InitializeComponent();
            LoadProducts(); // Call this method when the UserControl initializes
        }

        private void LoadProducts(string searchTerm = null)
        {
            using (var context = new AppDbContext()) // Create an instance of your DbContext
            {
                try
                {
                    // Fetch products from the database that are not marked as deleted
                    var query = context.Products.Where(p => p.status != "Deleted");

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(p => p.prod_name.Contains(searchTerm) || p.prod_id.Contains(searchTerm));
                    }

                    var products = query.ToList();

                    // Clear existing columns if any, to avoid duplication on subsequent loads
                    ProductGridView.Columns.Clear();
                    ProductGridView.AutoGenerateColumns = false; // We'll define columns manually

                    // Define the columns for the DataGridView
                    // The DataPropertyName must match the property name in your POS_project.Product class
                    ProductGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "productidcol", HeaderText = "ProdCode", DataPropertyName = "prod_id" });
                    ProductGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "productNamecol", HeaderText = "ProdName", DataPropertyName = "prod_name" });
                    ProductGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "categoryCol", HeaderText = "Category", DataPropertyName = "category" });
                    ProductGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "quantityCol", HeaderText = "Stock", DataPropertyName = "stock" });
                    ProductGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "statusCol", HeaderText = "Status", DataPropertyName = "status" });
                    ProductGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "priceCol", HeaderText = "ProdPrice", DataPropertyName = "prod_price" });
                    ProductGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "barcodeCol", HeaderText = "Barcode", DataPropertyName = "barcode" });


                    //// Add "Add Stock" and "Delete Product" buttons as DataGridViewButtonColumn
                    //ProductGridView.Columns.Add(new DataGridViewButtonColumn() { Name = "addstockCol", HeaderText = "Add Stock", Text = "Add", UseColumnTextForButtonValue = true, Width = 125 });
                    //ProductGridView.Columns.Add(new DataGridViewButtonColumn() { Name = "deleteCol", HeaderText = "Delete Product", Text = "Delete", UseColumnTextForButtonValue = true, Width = 150 });

                    ProductGridView.DataSource = products; // Bind the list of products to the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text);
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle button clicks in the DataGridView
            if (e.RowIndex >= 0) // Ensure it's a valid row
            {
                // Check if the clicked cell is in the "Add Stock" column
                if (ProductGridView.Columns[e.ColumnIndex].Name == "addstockCol")
                {
                    // Get the product ID from the clicked row
                    var product = ProductGridView.Rows[e.RowIndex].DataBoundItem as Product;
                    if (product != null)
                    {
                        MessageBox.Show($"Add stock for product: {product.prod_name} (ID: {product.id})");
                        // You would typically open a new form/dialog here to get the quantity to add
                        // For example:
                        // using (var addStockForm = new AddStockForm(product.id))
                        // {
                        //     if (addStockForm.ShowDialog() == DialogResult.OK)
                        //     {
                        //         LoadProducts(); // Reload products after stock update
                        //     }
                        // }
                    }
                }
                // Check if the clicked cell is in the "Delete Product" column
                else if (ProductGridView.Columns[e.ColumnIndex].Name == "deleteCol")
                {
                    var product = ProductGridView.Rows[e.RowIndex].DataBoundItem as Product;
                    if (product != null)
                    {
                        if (MessageBox.Show($"Are you sure you want to delete {product.prod_name}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            using (var context = new AppDbContext()) //
                            {
                                var productToDelete = context.Products.Find(product.id);
                                if (productToDelete != null)
                                {
                                    // Mark as deleted instead of actual removal, or remove if your business logic allows
                                    productToDelete.status = "Deleted";
                                    context.SaveChanges();
                                    MessageBox.Show($"{product.prod_name} has been marked as deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadProducts(); // Reload the products to update the DataGridView
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}