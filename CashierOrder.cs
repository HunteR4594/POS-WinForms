using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;
using Microsoft.EntityFrameworkCore;
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
        // MODIFICATION 1: The cashier ID is now 'readonly' and has no default value.
        // It MUST be initialized in the constructor.
        private readonly int _cashierId;
        public CashierOrder(int cashierId)
        {
            InitializeComponent();

            // Ensure the provided ID is valid (not zero or negative)
            if (cashierId <= 0)
            {
                throw new ArgumentException("A valid cashier ID must be provided.", nameof(cashierId));
            }

            _context = new AppDbContext(); // Initialize EF Core DbContext
            _cashierId = cashierId; // Assign the required cashier ID
            InitializeOrderListTable(); // Setup the DataTable structure
            displayAllAvailableProducts(); // Load available products into dataGridView1 using EF Core
            displayCategories(); // Load categories into ComboBox using EF Core
            UpdateTotals(); // Initialize all total labels to 0.00
        }

        // --- Method: Initialize Order List Table ---
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
            orderListTable.Columns.Add("Product PK ID", typeof(int)); // New column for actual product Primary Key ID
            orderListTable.Columns.Add("Category", typeof(string)); // New column for category name
            orderListTable.Columns.Add("Cashier Username", typeof(string)); // New column for cashier's username

            dataGridView2.DataSource = orderListTable; // Bind the DataTable to dataGridView2

            // Configure column visibility and formatting for dataGridView2
            dataGridView2.Columns["Original Unit Price"].Visible = false; // Usually hidden on UI, but needed for calculations
            dataGridView2.Columns["Line Discount Amount"].Visible = false; // Can be hidden or shown
            dataGridView2.Columns["Product PK ID"].Visible = false; // Hide the actual Product PK ID
            dataGridView2.Columns["Category"].Visible = false; // Hide category as it's often not displayed on receipt lines

            // Ensure currency formatting for relevant columns displayed on the grid
            dataGridView2.Columns["Unit Price After Discount"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Original Subtotal"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Line Discount Amount"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Final Subtotal"].DefaultCellStyle.Format = "C2";
        }

        // --- displayAllAvailableProducts to use EF Core and Product entity ---
        public void displayAllAvailableProducts()
        {
            try
            {
                var products = _context.Products
                                       .Where(p => p.status == "Available")
                                       .AsNoTracking()
                                       .ToList();
                dataGridView1.DataSource = products;
                dataGridView1.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- displayCategories() to use EF Core and Category entity and add "All" ---
        public void displayCategories()
        {
            try
            {
                var categories = _context.Categories
                                         .Select(c => c.CategoryName)
                                         .Distinct()
                                         .OrderBy(c => c)
                                         .AsNoTracking()
                                         .ToList();

                Cashier_CategoryOr.Items.Clear();
                Cashier_CategoryOr.Items.Add("All");
                foreach (string category in categories)
                {
                    Cashier_CategoryOr.Items.Add(category);
                }
                Cashier_CategoryOr.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Cashier_CategoryOr_SelectedIndexChanged to filter DataGridView and populate ProductID ComboBox ---
        private void Cashier_CategoryOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = Cashier_CategoryOr.SelectedItem?.ToString();

            Cashier_ProductidOr.Items.Clear();
            ClearProductInputs();


            if (selectedCategory == "All")
            {
                displayAllAvailableProducts();
            }
            else if (selectedCategory != null)
            {
                try
                {
                    var filteredProducts = _context.Products
                                                   .Where(p => p.category == selectedCategory && p.status == "Available")
                                                   .OrderBy(p => p.prod_name)
                                                   .AsNoTracking()
                                                   .ToList();
                    dataGridView1.DataSource = filteredProducts;

                    foreach (Product p in filteredProducts)
                    {
                        Cashier_ProductidOr.Items.Add(p.prod_id);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering products or loading product IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- dataGridView1_CellClick to correctly update Category and Product ID ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Product selectedProduct = row.DataBoundItem as Product;

                if (selectedProduct != null)
                {
                    isProgrammaticUpdate = true;
                    Cashier_CategoryOr.SelectedItem = selectedProduct.category;
                    Cashier_ProductidOr.SelectedItem = selectedProduct.prod_id;
                    isProgrammaticUpdate = false;
                    Cashier_Product_NameOr.Text = selectedProduct.prod_name;
                    Cashier_PriceOr.Text = selectedProduct.prod_price.ToString("F2");
                    Cashier_QuantityOr.Value = 1;
                }
            }
        }


        // --- Add_CashierOr_Click (Corrected Stock Logic and DataTable Population) ---
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

            Product productInDb = _context.Products.FirstOrDefault(p => p.prod_id == prodId);

            if (productInDb == null)
            {
                MessageBox.Show("Product not found in database: " + prodId, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (productInDb.stock < quantity)
            {
                MessageBox.Show($"Not enough stock available for {prodName}. Available: {productInDb.stock}", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double originalSubtotalVATInclusive = originalPricePerUnitVATInclusive * quantity;
            double lineDiscountAmount = 0.0;
            double finalPricePerUnitVATInclusive = originalPricePerUnitVATInclusive;
            double finalSubtotalVATInclusive = originalSubtotalVATInclusive;

            if (isDiscountActive)
            {
                if (currentDiscountType == "Cash")
                {
                    lineDiscountAmount = quantity * currentDiscountValue;
                    finalSubtotalVATInclusive = originalSubtotalVATInclusive - lineDiscountAmount;
                    finalPricePerUnitVATInclusive = originalPricePerUnitVATInclusive - currentDiscountValue;
                }
                else if (currentDiscountType == "Percent")
                {
                    double percentFactor = currentDiscountValue / 100.0;
                    lineDiscountAmount = originalSubtotalVATInclusive * percentFactor;
                    finalSubtotalVATInclusive = originalSubtotalVATInclusive - lineDiscountAmount;
                    finalPricePerUnitVATInclusive = originalPricePerUnitVATInclusive * (1 - percentFactor);
                }

                if (finalPricePerUnitVATInclusive < 0) finalPricePerUnitVATInclusive = 0;
                if (finalSubtotalVATInclusive < 0) finalSubtotalVATInclusive = 0;
            }

            bool productExistsInOrderList = false;
            foreach (DataRow row in orderListTable.Rows)
            {
                if (row["Product ID"].ToString() == prodId)
                {
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                    row["Original Subtotal"] = Convert.ToDouble(row["Original Subtotal"]) + originalSubtotalVATInclusive;
                    row["Line Discount Amount"] = Convert.ToDouble(row["Line Discount Amount"]) + lineDiscountAmount;
                    row["Final Subtotal"] = Convert.ToDouble(row["Final Subtotal"]) + finalSubtotalVATInclusive;
                    row["Unit Price After Discount"] = finalPricePerUnitVATInclusive;
                    productExistsInOrderList = true;
                    break;
                }
            }

            if (!productExistsInOrderList)
            {
                // Fetch the cashier's username using _cashierId
                string cashierUsername = _context.Users.FirstOrDefault(u => u.id == _cashierId)?.Username ?? "Unknown";

                orderListTable.Rows.Add(
                    prodId, prodName, quantity,
                    originalPricePerUnitVATInclusive,
                    finalPricePerUnitVATInclusive,
                    originalSubtotalVATInclusive,
                    lineDiscountAmount,
                    finalSubtotalVATInclusive,
                    productInDb.id,
                    productInDb.category,
                    cashierUsername // Add the cashier's username here
                );
            }

            try
            {
                productInDb.stock -= quantity;
                _context.SaveChanges();
                displayAllAvailableProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error updating stock during Add: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateTotals();
            ClearProductInputs();
            currentDiscountType = string.Empty;
            currentDiscountValue = 0.0;
            isDiscountActive = false;
            DiscountValue.Text = "Discount";
        }

        // --- UpdateTotals (consolidated logic for all summary calculations) ---
        private void UpdateTotals()
        {
            grossSubtotalBeforeDiscount = 0;
            totalLineDiscountAmount = 0;
            double currentFinalSubtotalAfterLineDiscount = 0;

            foreach (DataRow row in orderListTable.Rows)
            {
                grossSubtotalBeforeDiscount += Convert.ToDouble(row["Original Subtotal"]);
                totalLineDiscountAmount += Convert.ToDouble(row["Line Discount Amount"]);
                currentFinalSubtotalAfterLineDiscount += Convert.ToDouble(row["Final Subtotal"]);
            }

            netSalesBeforeVAT = currentFinalSubtotalAfterLineDiscount / (1 + VAT_RATE);
            totalVATAmount = currentFinalSubtotalAfterLineDiscount - netSalesBeforeVAT;
            double finalGrandTotal = currentFinalSubtotalAfterLineDiscount;

            label12.Text = grossSubtotalBeforeDiscount.ToString("C2");
            label7.Text = totalLineDiscountAmount.ToString("C2");
            vatValue.Text = totalVATAmount.ToString("C2");
            Cashier_Total_PriceOr.Text = finalGrandTotal.ToString("C2");
        }

        // --- Method: Clear Product Inputs ---
        private void ClearProductInputs()
        {
            Cashier_ProductidOr.SelectedIndex = -1;
            Cashier_Product_NameOr.Text = "";
            Cashier_PriceOr.Text = "0.00";
            Cashier_QuantityOr.Value = 1;
        }

        private void Cashier_QuantityOr_ValueChanged(object sender, EventArgs e)
        {
        }

        // --- Remove_CashierOr_Click to return stock using EF Core ---
        private void Remove_CashierOr_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataRowView drv = dataGridView2.SelectedRows[0].DataBoundItem as DataRowView;
                if (drv == null) return;
                DataRow rowToRemove = drv.Row;

                string prodId = rowToRemove["Product ID"].ToString();
                int quantityToReturn = Convert.ToInt32(rowToRemove["Quantity"]);

                try
                {
                    Product productToUpdate = _context.Products.FirstOrDefault(p => p.prod_id == prodId);
                    if (productToUpdate != null)
                    {
                        productToUpdate.stock += quantityToReturn;
                        _context.SaveChanges();
                        displayAllAvailableProducts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error returning stock on item removal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                orderListTable.Rows.Remove(rowToRemove);
                UpdateTotals();
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the order list.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- Clear_CashierOr_Click to return all stock on clear using EF Core ---
        private void Clear_CashierOr_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in orderListTable.Rows.Cast<DataRow>().ToList())
            {
                string prodId = row["Product ID"].ToString();
                int quantityToReturn = Convert.ToInt32(row["Quantity"]);

                try
                {
                    Product productToUpdate = _context.Products.FirstOrDefault(p => p.prod_id == prodId);
                    if (productToUpdate != null)
                    {
                        productToUpdate.stock += quantityToReturn;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error returning stock for {prodId} on clear: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                _context.SaveChanges();
                displayAllAvailableProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving stock changes during clear operation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            orderListTable.Clear();
            UpdateTotals();
            ClearProductInputs();
            Cashier_AmountOr.Clear();
            Cashier_ChangeOr.Text = "0.00";
            currentDiscountType = string.Empty;
            currentDiscountValue = 0.0;
            isDiscountActive = false;
            grossSubtotalBeforeDiscount = 0.0;
            totalLineDiscountAmount = 0.0;
            netSalesBeforeVAT = 0.0;
            totalVATAmount = 0.0;
            DiscountValue.Text = "Discount";
            MessageBox.Show("Order list cleared and stock returned.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Cashier_Pay_OrdersOr_Click (Corrected Sale property names) ---
        private void Cashier_Pay_OrdersOr_Click(object sender, EventArgs e)
        {
            if (orderListTable.Rows.Count == 0) return;
            if (string.IsNullOrEmpty(Cashier_AmountOr.Text)) return;
            if (!double.TryParse(Cashier_AmountOr.Text, out double amountReceived)) return;
            if (!double.TryParse(Cashier_Total_PriceOr.Text.Replace("₱", "").Replace("$", "").Trim(), out double totalDue)) return;
            if (amountReceived < totalDue)
            {
                MessageBox.Show($"Insufficient amount. Total due: {totalDue.ToString("C2")}", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double change = amountReceived - totalDue;
            Cashier_ChangeOr.Text = change.ToString("C2");

            try
            {
                Sale newSale = new Sale
                {
                    customer_id = "DefaultCustomer",
                    total_price = (decimal)totalDue,
                    amount = (decimal)amountReceived,
                    change = (decimal)change,
                    order_date = DateTime.Now,
                    CashierId = _cashierId // Assign the default cashier ID
                };
                _context.Sales.Add(newSale);

                foreach (DataRow row in orderListTable.Rows)
                {
                    SaleItem saleItem = new SaleItem()
                    {
                        ProdId = row["Product ID"].ToString(),
                        ProdName = row["Product Name"].ToString(),
                        Quantity = Convert.ToInt32(row["Quantity"]),
                        OrigPrice = Convert.ToDecimal(row["Original Unit Price"]),
                        TotalPrice = Convert.ToDecimal(row["Final Subtotal"]),
                        customer_id = "DefaultCustomer",
                        category = row["Category"].ToString(),
                        ProductId = Convert.ToInt32(row["Product PK ID"]),
                        order_date = DateTime.Now,
                        Username = row["Cashier Username"].ToString()
                    };
                    newSale.SaleItems.Add(saleItem);
                }

                _context.SaveChanges();
                MessageBox.Show("Sale and Sale Items recorded successfully!", "Sale Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errorMessage = "Error saving sale record and items: " + ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                }
                MessageBox.Show(errorMessage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult result = MessageBox.Show($"Payment successful! Change: {change.ToString("C2")}\nDo you want to print a receipt?", "Payment Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Cashier_ReceiptOr_Click(sender, e);
            }
            Clear_CashierOr_Click(sender, e);
        }

        // --- Cashier_ReceiptOr_Click (Removed summaryLabelPadding) ---
        private void Cashier_ReceiptOr_Click(object sender, EventArgs e)
        {
            if (orderListTable.Rows.Count == 0) return;

            string receiptContent = "--- Receipt ---\n";
            receiptContent += "ProdID\tName\tQty\tOrig Price\tFinal Price\n";
            receiptContent += "-------------------------------------------------------------------------------\n";

            foreach (DataRow row in orderListTable.Rows)
            {
                receiptContent += $"{row["Product ID"]}\t{row["Product Name"]}\t{row["Quantity"]}\t{Convert.ToDouble(row["Original Unit Price"]):F2}\t{Convert.ToDouble(row["Unit Price After Discount"]):F2}\n";
            }

            receiptContent += "-------------------------------------------------------------------------------\n";
            receiptContent += $"Partial Total (Gross Sales before Discount): {grossSubtotalBeforeDiscount.ToString("C2")}\n";
            receiptContent += $"Total Line Discount Applied: {totalLineDiscountAmount.ToString("C2")}\n";
            receiptContent += $"Net Sales Before VAT: {netSalesBeforeVAT.ToString("C2")}\n";
            receiptContent += $"Total VAT (12%): {totalVATAmount.ToString("C2")}\n";
            receiptContent += $"Final Grand Total: {Cashier_Total_PriceOr.Text}\n";
            receiptContent += $"Amount Paid: {Convert.ToDouble(Cashier_AmountOr.Text).ToString("C2")}\n";
            receiptContent += $"Change: {Cashier_ChangeOr.Text}\n";
            receiptContent += "-------------------------------------------------------------------------------\n";
            receiptContent += "Thank you for your purchase!\n";

            MessageBox.Show(receiptContent, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Discount_CashierOr_Click (Removed re-calculation loop) ---
        private void Discount_CashierOr_Click(object sender, EventArgs e)
        {
            using (DiscountForm discountForm = new DiscountForm())
            {
                if (discountForm.ShowDialog() == DialogResult.OK)
                {
                    currentDiscountType = discountForm.SelectedDiscountType;
                    currentDiscountValue = discountForm.DiscountValue;
                    isDiscountActive = true;

                    DiscountValue.Text = currentDiscountType == "Cash"
                        ? $"Cash {currentDiscountValue.ToString("C2")}"
                        : $"Percent {currentDiscountValue.ToString("F2")}%";

                    MessageBox.Show($"Discount set: {currentDiscountType} - {currentDiscountValue}", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    currentDiscountType = string.Empty;
                    currentDiscountValue = 0.0;
                    isDiscountActive = false;
                    DiscountValue.Text = "Discount";
                }
            }
        }

        // --- MODIFIED: Cashier_ScanOr_Click to handle the barcode scanner event ---
        private void Cashier_ScanOr_Click(object sender, EventArgs e)
        {
            Barcode_Scanner barcodeForm = new Barcode_Scanner();
            // Subscribe to the event that is fired when a barcode is successfully scanned.
            // When the event occurs, the 'BarcodeForm_BarcodeScanned' method will be called.
            barcodeForm.BarcodeScanned += BarcodeForm_BarcodeScanned;
            // Show the form as a modal dialog, which prevents interaction with the main form until it's closed.
            barcodeForm.ShowDialog(this);
        }

        // --- NEW: Event handler for when a barcode is scanned ---
        private void BarcodeForm_BarcodeScanned(object sender, string barcode)
        {
            // This method is called when the BarcodeScanned event is triggered from the scanner form.
            // The 'barcode' parameter holds the scanned string.

            // We need to ensure this logic runs on the UI thread, as events can sometimes
            // be raised from other threads. 'Invoke' ensures thread safety for UI updates.
            if (this.InvokeRequired)
            {
                // If we're not on the UI thread, call this same method again on the UI thread.
                this.Invoke(new Action(() => FindAndDisplayProduct(barcode)));
            }
            else
            {
                // If we're already on the UI thread, just call the method directly.
                FindAndDisplayProduct(barcode);
            }
        }

        // --- NEW: Method to find a product by its ID and update the UI ---
        private void FindAndDisplayProduct(string productId)
        {
            try
            {
                // Search the database for a product whose prod_id matches the scanned barcode.
                // AsNoTracking() improves performance for read-only queries.
                Product scannedProduct = _context.Products
                                                 .AsNoTracking()
                                                 .FirstOrDefault(p => p.prod_id == productId);

                if (scannedProduct != null)
                {
                    // If a product is found, populate the UI controls with its data.
                    // A flag is used to prevent event handlers (like SelectedIndexChanged)
                    // from firing during these programmatic updates.
                    isProgrammaticUpdate = true;

                    // 1. Set the category in the ComboBox. This might trigger an event
                    //    that repopulates the Product ID ComboBox.
                    Cashier_CategoryOr.SelectedItem = scannedProduct.category;

                    // 2. Now that the Product ID list is correctly filtered for the category,
                    //    select the specific product ID.
                    Cashier_ProductidOr.SelectedItem = scannedProduct.prod_id;

                    // 3. Update the remaining display fields.
                    Cashier_Product_NameOr.Text = scannedProduct.prod_name;
                    Cashier_PriceOr.Text = scannedProduct.prod_price.ToString("F2");
                    Cashier_QuantityOr.Value = 1; // Set default quantity to 1

                    // Reset the flag after updates are complete.
                    isProgrammaticUpdate = false;
                }
                else
                {
                    // If no product is found, inform the user.
                    MessageBox.Show($"Product with Barcode/ID '{productId}' not found in the database.",
                                    "Product Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any potential database errors during the search.
                MessageBox.Show("Error retrieving product from database: " + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                isProgrammaticUpdate = false; // Ensure flag is reset even if an error occurs.
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DiscountValue_Click(object sender, EventArgs e)
        {

        }
    }
}