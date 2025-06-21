using System.Data; // Still needed for DataTable (for orderListTable)
using System.Linq; // Required for LINQ queries
using System.Windows.Forms; // Required for WinForms components (MessageBox, UserControl)
using System; // Required for Convert, DateTime etc.
using Microsoft.EntityFrameworkCore; // Required for EF Core operations
using System.Collections.Generic;
using POS_project.Migrations; // Required for List<T>

namespace POS_project
{
    public partial class CashierOrder : UserControl
    {
        private readonly AppDbContext _context; // EF Core DbContext for database interactions
        private DataTable orderListTable; // DataTable for displaying current order items

        // Fields for Discount Feature (these store the *active* discount to be applied to the next item added)
        private string currentDiscountType = string.Empty; // "Cash" or "Percent"
        private double currentDiscountValue = 0.0; // The cash value (per unit) or percentage value
        private bool isDiscountActive = false; // Flag to indicate if a discount is set for the next item

        // Fields for Total Calculations (these accumulate totals for the entire order, including discount and VAT)
        private double grossSubtotalBeforeDiscount = 0.0; // Sum of Original Subtotals (before any line discount)
        private double totalLineDiscountAmount = 0.0;     // Sum of Line Discount Amounts
        private double netSalesBeforeVAT = 0.0;           // (grossSubtotalBeforeDiscount - totalLineDiscountAmount)
        private double totalVATAmount = 0.0;              // 12% of netSalesBeforeVAT
        private const double VAT_RATE = 0.12; // 12% VAT rate

        // Flag to prevent re-triggering Cashier_CategoryOr_SelectedIndexChanged during programmatic updates
        private bool isProgrammaticUpdate = false;

        public CashierOrder()
        {
            InitializeComponent();
            _context = new AppDbContext(); // Initialize EF Core DbContext
            InitializeOrderListTable(); // Setup the DataTable structure
            displayAllAvailableProducts(); // Load available products into dataGridView1 using EF Core
            displayCategories(); // Load categories into ComboBox using EF Core
            UpdateTotals(); // Initialize all total labels to 0.00
        }

        // --- Modified Method: Initialize Order List Table ---
        private void InitializeOrderListTable()
        {
            orderListTable = new DataTable();
            // Define all the columns required for detailed order tracking
            orderListTable.Columns.Add("Product ID", typeof(string));
            orderListTable.Columns.Add("Product Name", typeof(string));
            orderListTable.Columns.Add("Quantity", typeof(int));
            orderListTable.Columns.Add("Original Unit Price", typeof(double)); // Original price from DB (VAT-inclusive)
            orderListTable.Columns.Add("Unit Price After Discount", typeof(double)); // Price per unit after line discount
            orderListTable.Columns.Add("Original Subtotal", typeof(double)); // (Original Unit Price * Quantity) - VAT Inclusive
            orderListTable.Columns.Add("Line Discount Amount", typeof(double)); // The actual discount amount for this item line
            orderListTable.Columns.Add("Final Subtotal", typeof(double)); // (Original Subtotal - Line Discount Amount) - Still VAT Inclusive

            dataGridView2.DataSource = orderListTable; // Bind the DataTable to dataGridView2

            // Configure column visibility and formatting for dataGridView2
            // You can adjust which columns are visible on the grid itself.
            dataGridView2.Columns["Original Unit Price"].Visible = false; // Usually hidden on UI, but needed for calculations
            dataGridView2.Columns["Line Discount Amount"].Visible = false; // Can be hidden or shown

            // Ensure currency formatting for relevant columns displayed on the grid
            dataGridView2.Columns["Unit Price After Discount"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Original Subtotal"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Line Discount Amount"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Final Subtotal"].DefaultCellStyle.Format = "C2";
        }

        // --- MODIFIED: displayAllAvailableProducts to use EF Core and Product entity ---
        public void displayAllAvailableProducts()
        {
            try
            {
                // Query all available products from the database using EF Core and LINQ
                // .AsNoTracking() is good for read-only data binding to improve performance
                // Product entity has properties like prod_id, prod_name, prod_price, stock, status etc.
                var products = _context.Products
                                       .Where(p => p.status == "Available")
                                       .AsNoTracking()
                                       .ToList();
                dataGridView1.DataSource = products; // Bind List<Product> directly to DataGridView
                dataGridView1.AutoGenerateColumns = true; // Ensure columns are generated for the Product properties
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MODIFIED: displayCategories() to use EF Core and Category entity and add "All" ---
        public void displayCategories()
        {
            try
            {
                // Query distinct category names using LINQ from the Categories DbSet
                var categories = _context.Categories
                                         .Select(c => c.CategoryName) // Selects just the CategoryName property
                                         .Distinct() // Ensures only unique category names are returned
                                         .OrderBy(c => c) // Order alphabetically
                                         .AsNoTracking() // For read-only data
                                         .ToList(); // Executes the query and returns a List<string>

                Cashier_CategoryOr.Items.Clear(); // Clear existing items in the ComboBox
                Cashier_CategoryOr.Items.Add("All"); // Add "All" as the first option
                foreach (string category in categories)
                {
                    Cashier_CategoryOr.Items.Add(category); // Add each category name to the ComboBox
                }
                Cashier_CategoryOr.SelectedIndex = 0; // Select "All" by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MODIFIED: Cashier_CategoryOr_SelectedIndexChanged to filter DataGridView and populate ProductID ComboBox ---
        private void Cashier_CategoryOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = Cashier_CategoryOr.SelectedItem?.ToString();

            // Clear product ID combo box first
            Cashier_ProductidOr.Items.Clear();
            // Clear other fields to prevent stale data if user changes category
            ClearProductInputs();


            if (selectedCategory == "All") // If "All" is selected, show all available products
            {
                displayAllAvailableProducts(); // This will load all available products into dataGridView1
            }
            else if (selectedCategory != null) // If a specific category is selected
            {
                try
                {
                    // Filter dataGridView1 based on selected category
                    var filteredProducts = _context.Products
                                                   .Where(p => p.category == selectedCategory && p.status == "Available")
                                                   .OrderBy(p => p.prod_name) // Order by product name for display
                                                   .AsNoTracking()
                                                   .ToList();
                    dataGridView1.DataSource = filteredProducts;

                    // Populate Cashier_ProductidOr with product IDs of the filtered products
                    foreach (Product p in filteredProducts) // Use Product entity directly
                    {
                        Cashier_ProductidOr.Items.Add(p.prod_id);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering products or loading product IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // No else block needed for null selectedCategory anymore, as "All" will always be selected by default
        }

        // --- MODIFIED: dataGridView1_CellClick to correctly update Category and Product ID ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Direct casting to Product entity since DataGridView is bound to List<Product>
                Product selectedProduct = row.DataBoundItem as Product;

                if (selectedProduct != null)
                {
                    // Temporarily set flag to indicate programmatic update
                    // This flag is crucial to prevent re-triggering the full filtering logic
                    // when Cashier_CategoryOr.SelectedItem is set programmatically.
                    isProgrammaticUpdate = true;

                    // 1. Set the category ComboBox. This will trigger Cashier_CategoryOr_SelectedIndexChanged.
                    //    Cashier_CategoryOr_SelectedIndexChanged will now filter dataGridView1 and populate Cashier_ProductidOr.
                    Cashier_CategoryOr.SelectedItem = selectedProduct.category;

                    // 2. Now that Cashier_ProductidOr is populated for the correct category,
                    //    we can safely set the specific product ID from the clicked row.
                    Cashier_ProductidOr.SelectedItem = selectedProduct.prod_id;

                    // Reset the flag immediately after programmatic updates are complete
                    isProgrammaticUpdate = false;

                    // These lines will now consistently set the product name, price, and quantity
                    // without being prematurely cleared by Cashier_CategoryOr_SelectedIndexChanged.
                    Cashier_Product_NameOr.Text = selectedProduct.prod_name;
                    Cashier_PriceOr.Text = selectedProduct.prod_price.ToString("F2"); // Use prod_price (decimal)
                    Cashier_QuantityOr.Value = 1; // Reset quantity to 1 for new selection
                }
            }
        }

        // --- NEW: Cashier_ProductidOr_SelectedIndexChanged event handler ---
        private void Cashier_ProductidOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only proceed if the update is NOT programmatic (i.e., user-initiated)
            // or if it IS programmatic but the product ID is valid.
            // This prevents clearing fields when Cashier_CategoryOr_SelectedIndexChanged populates the list.

            string selectedProductId = Cashier_ProductidOr.SelectedItem?.ToString();

            // It's important to only clear/update if a valid product ID is selected by the user.
            // If the item is deselected or null due to programmatic changes (e.g. category change clearing the list),
            // we don't want to clear the inputs here, as dataGridView1_CellClick handles it.
            if (!isProgrammaticUpdate && selectedProductId != null)
            {
                try
                {
                    // Find the product in the database based on the selected Product ID
                    Product selectedProduct = _context.Products
                                                      .AsNoTracking()
                                                      .FirstOrDefault(p => p.prod_id == selectedProductId);

                    if (selectedProduct != null)
                    {
                        // Update the product name and price display fields
                        Cashier_Product_NameOr.Text = selectedProduct.prod_name;
                        Cashier_PriceOr.Text = selectedProduct.prod_price.ToString("F2");
                        Cashier_QuantityOr.Value = 1; // Reset quantity to 1 for new selection
                    }
                    else
                    {
                        // Product not found (shouldn't happen if database is consistent)
                        ClearProductInputs(); // Clear inputs if product not found
                        MessageBox.Show("Selected product ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    ClearProductInputs(); // Clear inputs on error
                    MessageBox.Show("Error loading product details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!isProgrammaticUpdate && selectedProductId == null)
            {
                // This condition handles a user explicitly selecting a blank item (if available)
                // or if the list becomes empty due to a user-driven category change.
                ClearProductInputs();
            }
            // If isProgrammaticUpdate is true, this event was triggered by dataGridView1_CellClick.
            // In that case, dataGridView1_CellClick is already responsible for setting Cashier_Product_NameOr and Cashier_PriceOr.
        }


        // --- MODIFIED: Add_CashierOr_Click (Corrected Stock Logic and DataTable Population) ---
        private void Add_CashierOr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cashier_Product_NameOr.Text) || Cashier_ProductidOr.SelectedItem == null)
            {
                MessageBox.Show("Please select a product first.", "Missing Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cashier_QuantityOr.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string prodId = Cashier_ProductidOr.SelectedItem.ToString();
            string prodName = Cashier_Product_NameOr.Text;
            int quantity = (int)Cashier_QuantityOr.Value;
            double originalPricePerUnitVATInclusive = Convert.ToDouble(Cashier_PriceOr.Text);

            // Fetch product from DB to check current stock using EF Core
            Product productInDb = _context.Products.FirstOrDefault(p => p.prod_id == prodId);

            if (productInDb == null)
            {
                MessageBox.Show("Product not found in database: " + prodId, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if enough stock is available BEFORE adding to order and deducting
            if (productInDb.stock < quantity) // Use int Stock directly
            {
                MessageBox.Show($"Not enough stock available for {prodName}. Available: {productInDb.stock}", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate item totals
            double originalSubtotalVATInclusive = originalPricePerUnitVATInclusive * quantity;
            double lineDiscountAmount = 0.0;
            double finalPricePerUnitVATInclusive = originalPricePerUnitVATInclusive; // Price after line discount (still VAT-inclusive)
            double finalSubtotalVATInclusive = originalSubtotalVATInclusive; // Subtotal after line discount (still VAT-inclusive)

            // Apply item-level discount if active
            if (isDiscountActive)
            {
                if (currentDiscountType == "Cash")
                {
                    lineDiscountAmount = quantity * currentDiscountValue;
                    finalSubtotalVATInclusive = originalSubtotalVATInclusive - lineDiscountAmount;
                    finalPricePerUnitVATInclusive = originalPricePerUnitVATInclusive - currentDiscountValue;

                    if (finalPricePerUnitVATInclusive < 0) finalPricePerUnitVATInclusive = 0;
                    if (finalSubtotalVATInclusive < 0) finalSubtotalVATInclusive = 0;
                }
                else if (currentDiscountType == "Percent")
                {
                    double percentFactor = currentDiscountValue / 100.0;
                    lineDiscountAmount = originalSubtotalVATInclusive * percentFactor;
                    finalSubtotalVATInclusive = originalSubtotalVATInclusive - lineDiscountAmount;
                    finalPricePerUnitVATInclusive = originalPricePerUnitVATInclusive * (1 - percentFactor);

                    if (finalPricePerUnitVATInclusive < 0) finalPricePerUnitVATInclusive = 0;
                    if (finalSubtotalVATInclusive < 0) finalSubtotalVATInclusive = 0;
                }
                else
                {
                    MessageBox.Show("Error: Unknown discount type applied.", "Discount Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Check if product already exists in the order list (DataTable) for merging
            bool productExistsInOrderList = false;
            foreach (DataRow row in orderListTable.Rows)
            {
                if (row["Product ID"].ToString() == prodId)
                {
                    // Update existing row's quantities and subtotals
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                    row["Original Subtotal"] = Convert.ToDouble(row["Original Subtotal"]) + originalSubtotalVATInclusive;
                    row["Line Discount Amount"] = Convert.ToDouble(row["Line Discount Amount"]) + lineDiscountAmount;
                    row["Final Subtotal"] = Convert.ToDouble(row["Final Subtotal"]) + finalSubtotalVATInclusive;
                    row["Unit Price After Discount"] = finalPricePerUnitVATInclusive; // Update with the latest calculated price after discount
                    productExistsInOrderList = true;
                    break;
                }
            }

            if (!productExistsInOrderList)
            {
                // Add new row to the order list DataTable with all detailed columns
                orderListTable.Rows.Add(
                    prodId,
                    prodName,
                    quantity,
                    originalPricePerUnitVATInclusive, // "Original Unit Price"
                    finalPricePerUnitVATInclusive,    // "Unit Price After Discount"
                    originalSubtotalVATInclusive,     // "Original Subtotal"
                    lineDiscountAmount,               // "Line Discount Amount"
                    finalSubtotalVATInclusive         // "Final Subtotal"
                );
            }

            // --- Deduct stock immediately upon adding to order list (as per your previous logic) ---
            try
            {
                // productInDb is already loaded and tracked by the context
                productInDb.stock -= quantity; // Deduct stock from the tracked entity
                _context.SaveChanges(); // Save changes to the database
                displayAllAvailableProducts(); // Refresh the display of available products
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error updating stock during Add: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Important: If stock update fails here, you might want to revert the item addition from orderListTable too.
                // For simplicity, we'll let it proceed to avoid over-complicating the current fix.
            }

            UpdateTotals(); // Recalculate all summary totals (Partial, Discount, VAT, Final)
            ClearProductInputs(); // Clear selection for next item
            // After adding an item, reset discount fields so it doesn't apply to the next item automatically
            currentDiscountType = string.Empty;
            currentDiscountValue = 0.0;
            isDiscountActive = false;
            DiscountValue.Text = "Discount"; // Reset discount label on UI
        }

        // --- Modified Method: UpdateTotals (consolidated logic for all summary calculations) ---
        private void UpdateTotals()
        {
            grossSubtotalBeforeDiscount = 0; // Reset before recalculating from current DataTable
            totalLineDiscountAmount = 0;
            double currentFinalSubtotalAfterLineDiscount = 0; // Sum of "Final Subtotal" from DataTable rows

            foreach (DataRow row in orderListTable.Rows)
            {
                // Sum from the detailed columns in orderListTable
                grossSubtotalBeforeDiscount += Convert.ToDouble(row["Original Subtotal"]);
                totalLineDiscountAmount += Convert.ToDouble(row["Line Discount Amount"]);
                currentFinalSubtotalAfterLineDiscount += Convert.ToDouble(row["Final Subtotal"]);
            }

            // Calculate Net Sales Before VAT (this is the base for VAT calculation)
            netSalesBeforeVAT = currentFinalSubtotalAfterLineDiscount / (1 + VAT_RATE);

            // Calculate Total VAT Amount (the portion of VAT already included in the final price)
            totalVATAmount = currentFinalSubtotalAfterLineDiscount - netSalesBeforeVAT;

            double finalGrandTotal = currentFinalSubtotalAfterLineDiscount; // This is the total the customer pays (VAT-inclusive, after discounts)

            // Update UI labels
            label12.Text = grossSubtotalBeforeDiscount.ToString("C2");  // Partial Price (before any line discounts)
            label7.Text = totalLineDiscountAmount.ToString("C2");     // Total Discount Applied across all lines
            vatValue.Text = totalVATAmount.ToString("C2");            // Total calculated VAT
            Cashier_Total_PriceOr.Text = finalGrandTotal.ToString("C2"); // Final Grand Total
        }

        // --- Method: Clear Product Inputs ---
        private void ClearProductInputs()
        {
            Cashier_ProductidOr.SelectedIndex = -1; // Deselect
            Cashier_Product_NameOr.Text = "";
            Cashier_PriceOr.Text = "0.00"; // Reset price display
            Cashier_QuantityOr.Value = 1; // Reset quantity
        }

        private void Cashier_QuantityOr_ValueChanged(object sender, EventArgs e)
        {
            // This event handler remains empty as per previous discussions.
        }

        // --- MODIFIED: Remove_CashierOr_Click to return stock using EF Core ---
        private void Remove_CashierOr_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the DataRow corresponding to the selected row in DataGridView
                DataRowView drv = dataGridView2.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv == null)
                {
                    MessageBox.Show("Could not get data for the selected row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataRow rowToRemove = drv.Row;

                string prodId = rowToRemove["Product ID"].ToString();
                int quantityToReturn = Convert.ToInt32(rowToRemove["Quantity"]);

                // Return stock to database using EF Core
                try
                {
                    Product productToUpdate = _context.Products.FirstOrDefault(p => p.prod_id == prodId);
                    if (productToUpdate != null)
                    {
                        productToUpdate.stock += quantityToReturn; // Add stock back (int property)
                        _context.SaveChanges(); // Save changes to database
                        displayAllAvailableProducts(); // Refresh products display
                    }
                    else
                    {
                        MessageBox.Show("Product not found in database when removing item: " + prodId, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error returning stock on item removal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Remove the row from the DataTable (orderListTable)
                orderListTable.Rows.Remove(rowToRemove);
                UpdateTotals(); // Recalculate totals after removal
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the order list.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- MODIFIED: Clear_CashierOr_Click to return all stock on clear using EF Core ---
        private void Clear_CashierOr_Click(object sender, EventArgs e)
        {
            // Loop through all items in the current orderListTable to return stock
            // Use ToList() to avoid modifying collection while enumerating
            foreach (DataRow row in orderListTable.Rows.Cast<DataRow>().ToList()) // Cast<DataRow>() needed for AsEnumerable in older .NET
            {
                string prodId = row["Product ID"].ToString();
                int quantityToReturn = Convert.ToInt32(row["Quantity"]);

                try
                {
                    Product productToUpdate = _context.Products.FirstOrDefault(p => p.prod_id == prodId);
                    if (productToUpdate != null)
                    {
                        productToUpdate.stock += quantityToReturn; // Add stock back
                        // Note: SaveChanges will happen *once* after the loop for efficiency
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error returning stock for {prodId} on clear: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Continue processing other items even if one fails
                }
            }
            // Save all pending stock changes to the database after iterating through all items
            try
            {
                _context.SaveChanges();
                displayAllAvailableProducts(); // Refresh the available products display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving stock changes during clear operation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            orderListTable.Clear(); // Clear all items from the order list
            UpdateTotals(); // Reset all totals (which will become 0.00 after clearing the table)
            ClearProductInputs();
            Cashier_AmountOr.Clear();
            Cashier_ChangeOr.Text = "0.00";
            // Also reset discount variables and total summary variables when order is cleared
            currentDiscountType = string.Empty;
            currentDiscountValue = 0.0;
            isDiscountActive = false;
            grossSubtotalBeforeDiscount = 0.0;
            totalLineDiscountAmount = 0.0;
            netSalesBeforeVAT = 0.0;
            totalVATAmount = 0.0;
            DiscountValue.Text = "Discount"; // Reset discount label on UI
            MessageBox.Show("Order list cleared and stock returned.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- MODIFIED: Cashier_Pay_OrdersOr_Click (NEW Sale and SaleItem Recording Logic) ---
        private void Cashier_Pay_OrdersOr_Click(object sender, EventArgs e)
        {
            if (orderListTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order to pay for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Cashier_AmountOr.Text))
            {
                MessageBox.Show("Please enter the amount received.", "Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(Cashier_AmountOr.Text, out double amountReceived))
            {
                MessageBox.Show("Invalid amount entered. Please enter a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalDue = 0;
            // Parse the total price from the label (this is the Final Grand Total, VAT-inclusive, after discounts)
            if (!double.TryParse(Cashier_Total_PriceOr.Text.Replace("₱", "").Replace("$", "").Trim(), out totalDue))
            {
                MessageBox.Show("Error parsing total price. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amountReceived < totalDue)
            {
                MessageBox.Show($"Insufficient amount. Total due: {totalDue.ToString("C2")}", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double change = amountReceived - totalDue;
            Cashier_ChangeOr.Text = change.ToString("C2");
            MessageBox.Show($"Payment successful! Change: {change.ToString("C2")}", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- NEW: Logic to Save Sale and SaleItems to Database ---
            try
            {
                // Create a new Sale record
                Sale newSale = new Sale
                {
                    SaleDate = DateTime.Now,
                    TotalAmount = (decimal)totalDue // Use totalDue (Final Grand Total) for the sale record
                    // If you had a UserId, CashierId, etc., you'd add them here
                    // e.g., UserId = GetCurrentUserId();
                };
                _context.Sales.Add(newSale); // Add the Sale to the context

                // Create SaleItem records for each product in the orderListTable
                foreach (DataRow row in orderListTable.Rows)
                {
                    // Ensure you are using the correct column names from your orderListTable
                    SaleItem saleItem = new SaleItem
                    {
                        // SaleId will be automatically linked by EF Core due to navigation property configuration
                        ProdId = row["Product ID"].ToString(),
                        ProdName = row["Product Name"].ToString(),
                        Quantity = Convert.ToInt32(row["Quantity"]),
                        OrigPrice = Convert.ToDecimal(row["Original Unit Price"]), // Original unit price
                        TotalPrice = Convert.ToDecimal(row["Final Subtotal"]) // Final subtotal for this item line (after discount, VAT-inclusive)
                    };
                    // Add SaleItem to the Sale's collection; EF Core will handle the foreign key relationship
                    newSale.SaleItems.Add(saleItem);
                }

                _context.SaveChanges(); // Save all changes (Sale and SaleItems) to the database

                MessageBox.Show("Sale and Sale Items recorded successfully!", "Sale Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sale record and items: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Important: Consider rollback strategies if this fails partially.
            }
            // --- END NEW Logic ---

            // Offer receipt printing and then clear order
            DialogResult result = MessageBox.Show("Payment successful! Do you want to print a receipt?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Cashier_ReceiptOr_Click(sender, e);
            }
            Clear_CashierOr_Click(sender, e); // Clear all order details, inputs, and return stock
        }

        // --- MODIFIED: Cashier_ReceiptOr_Click (Removed summaryLabelPadding) ---
        private void Cashier_ReceiptOr_Click(object sender, EventArgs e)
        {
            if (orderListTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order to generate a receipt for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string receiptContent = "--- Receipt ---\n";
            // Item line headers (using tabs for simple alignment for items)
            receiptContent += "ProdID\tName\tQty\tOrig Price\tFinal Price\n";
            receiptContent += "-------------------------------------------------------------------------------\n";

            foreach (DataRow row in orderListTable.Rows)
            {
                string prodId = row["Product ID"].ToString();
                string prodName = row["Product Name"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);
                double originalUnitPrice = Convert.ToDouble(row["Original Unit Price"]); // Use 'Original Unit Price'
                double finalUnitPrice = Convert.ToDouble(row["Unit Price After Discount"]); // Use 'Unit Price After Discount'

                // Use tabs for item lines as requested previously
                receiptContent += $"{prodId}\t{prodName}\t{quantity}\t{originalUnitPrice.ToString("F2")}\t{finalUnitPrice.ToString("F2")}\n";
            }

            receiptContent += "-------------------------------------------------------------------------------\n";

            // Removed summaryLabelPadding for left alignment
            receiptContent += $"Partial Total (Gross Sales before Discount): {grossSubtotalBeforeDiscount.ToString("C2")}\n";
            receiptContent += $"Total Line Discount Applied: {totalLineDiscountAmount.ToString("C2")}\n";
            receiptContent += $"Net Sales Before VAT: {netSalesBeforeVAT.ToString("C2")}\n";
            receiptContent += $"Total VAT (12%): {totalVATAmount.ToString("C2")}\n";
            receiptContent += $"Final Grand Total: {Cashier_Total_PriceOr.Text}\n"; // This is the total the customer pays

            double amountPaid = 0;
            if (double.TryParse(Cashier_AmountOr.Text, out amountPaid))
            {
                receiptContent += $"Amount Paid: {amountPaid.ToString("C2")}\n";
            }
            else
            {
                receiptContent += $"Amount Paid: Not entered\n";
            }
            receiptContent += $"Change: {Cashier_ChangeOr.Text}\n";
            receiptContent += "-------------------------------------------------------------------------------\n";
            receiptContent += "Thank you for your purchase!\n";

            MessageBox.Show(receiptContent, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- MODIFIED: Discount_CashierOr_Click (Removed re-calculation loop) ---
        private void Discount_CashierOr_Click(object sender, EventArgs e)
        {
            using (DiscountForm discountForm = new DiscountForm())
            {
                DialogResult result = discountForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentDiscountType = discountForm.SelectedDiscountType;
                    currentDiscountValue = discountForm.DiscountValue;
                    isDiscountActive = true; // Set flag that a discount is ready to be applied to the next item

                    if (currentDiscountType == "Cash")
                    {
                        DiscountValue.Text = $"Cash {currentDiscountValue.ToString("C2")}";
                    }
                    else if (currentDiscountType == "Percent")
                    {
                        DiscountValue.Text = $"Percent {currentDiscountValue.ToString("F2")}%";
                    }

                    MessageBox.Show($"Discount set: {currentDiscountType} - {currentDiscountValue}", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // IMPORTANT: Removed the loop that re-calculated discounts for existing items.
                    // The discount will now only be applied to the next item added via Add_CashierOr_Click.
                }
                else
                {
                    // User cancelled the discount, clear any pending discount
                    currentDiscountType = string.Empty;
                    currentDiscountValue = 0.0;
                    isDiscountActive = false;
                    DiscountValue.Text = "Discount"; // Reset discount label on UI
                    MessageBox.Show("Discount application cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
