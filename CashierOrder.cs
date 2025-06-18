using Microsoft.Data.SqlClient;
using System.Data; // Required for DataTable
using System.Windows.Forms; // Ensure this is present for MessageBox, UserControl etc.

namespace POS_project
{
    public partial class CashierOrder : UserControl
    {
        private SqlConnection connect;
        // DataTable to hold the items in the current order
        private DataTable orderListTable;

        // Fields for Discount Feature
        private string currentDiscountType = string.Empty; // "Cash" or "Percent"
        private double currentDiscountValue = 0.0; // The cash value (per unit) or percentage value
        private bool isDiscountActive = false; // Flag to indicate if a discount is set for the next item

        // Fields for Total Calculations (including discount and VAT)
        private double grossSubtotalBeforeDiscount = 0.0; // Sum of Original Subtotals (before any line discount)
        private double totalLineDiscountAmount = 0.0;     // Sum of Line Discount Amounts
        private double netSalesBeforeVAT = 0.0;           // (grossSubtotalBeforeDiscount - totalLineDiscountAmount)
        private double totalVATAmount = 0.0;              // 12% of netSalesBeforeVAT
        private const double VAT_RATE = 0.12; // 12% VAT rate

        public CashierOrder()
        {
            InitializeComponent();

            connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");

            // Initialize the order list DataTable and set it as DataSource for dataGridView2
            InitializeOrderListTable();

            displayAllAvailableProducts();
            displayCategories();
            UpdateTotals(); // Initialize totals on load
        }

        // --- Modified Method: Initialize Order List Table ---
        private void InitializeOrderListTable()
        {
            orderListTable = new DataTable();
            orderListTable.Columns.Add("Product ID", typeof(string));
            orderListTable.Columns.Add("Product Name", typeof(string));
            orderListTable.Columns.Add("Quantity", typeof(int));
            orderListTable.Columns.Add("Original Unit Price", typeof(double)); // Stores the price before any item-specific discount
            orderListTable.Columns.Add("Unit Price After Discount", typeof(double)); // Price per unit after item-specific discount
            orderListTable.Columns.Add("Original Subtotal", typeof(double)); // (Original Unit Price * Quantity) - VAT Inclusive
            orderListTable.Columns.Add("Line Discount Amount", typeof(double)); // The actual discount amount for this item line
            orderListTable.Columns.Add("Final Subtotal", typeof(double)); // (Original Subtotal - Line Discount Amount) - Still VAT Inclusive

            dataGridView2.DataSource = orderListTable; // Bind the DataTable to dataGridView2

            // Configure column visibility and formatting for dataGridView2
            dataGridView2.Columns["Original Unit Price"].Visible = false; // Hide this, it's for internal calculation
            // dataGridView2.Columns["Line Discount Amount"].Visible = false; // Keep hidden or show if desired for detail

            // Ensure currency formatting for relevant columns
            dataGridView2.Columns["Unit Price After Discount"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Original Subtotal"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Line Discount Amount"].DefaultCellStyle.Format = "C2"; // Show discount for the line
            dataGridView2.Columns["Final Subtotal"].DefaultCellStyle.Format = "C2";
        }

        public void displayAllAvailableProducts()
        {
            ProductData pData = new ProductData();
            List<ProductData> listdata = pData.allAvailableProducts();

            dataGridView1.DataSource = listdata;
            dataGridView1.AutoGenerateColumns = true; // Ensure columns are generated
        }

        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    String selectData = "SELECT category FROM categories";
                    using (SqlCommand command = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Cashier_CategoryOr.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader.GetString(0);
                                Cashier_CategoryOr.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Cashier_CategoryOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = Cashier_CategoryOr.SelectedItem?.ToString();

            if (selectedCategory != null)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT prod_id, prod_name, prod_price FROM products WHERE category = @category AND status = 'Available'";

                        using (SqlCommand command = new SqlCommand(selectData, connect))
                        {
                            command.Parameters.AddWithValue("@category", selectedCategory);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                Cashier_ProductIDOr.Items.Clear();
                                ClearProductInputs();

                                while (reader.Read())
                                {
                                    string productId = reader["prod_id"].ToString();
                                    Cashier_ProductIDOr.Items.Add(productId);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading products for category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        // --- Event Handler: dataGridView1_CellClick ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string productId = row.Cells["ProdID"].Value?.ToString();
                string productName = row.Cells["ProdName"].Value?.ToString();
                double originalProductPrice = 0.0;
                if (row.Cells["Price"].Value != null)
                {
                    double.TryParse(row.Cells["Price"].Value.ToString(), out originalProductPrice);
                }

                Cashier_ProductIDOr.SelectedItem = productId;
                Cashier_Product_NameOr.Text = productName;
                Cashier_PriceOr.Text = originalProductPrice.ToString("F2"); // Display original VAT-inclusive price

                Cashier_QuantityOr.Value = 1;
            }
        }

        // --- Modified Event Handler: Add_CashierOr_Click ---
        private void Add_CashierOr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cashier_Product_NameOr.Text) || Cashier_ProductIDOr.SelectedItem == null)
            {
                MessageBox.Show("Please select a product first.", "Missing Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cashier_QuantityOr.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string prodId = Cashier_ProductIDOr.SelectedItem.ToString();
            string prodName = Cashier_Product_NameOr.Text;
            int quantity = (int)Cashier_QuantityOr.Value;
            double originalPricePerUnitVATInclusive = Convert.ToDouble(Cashier_PriceOr.Text); // Price from display is VAT-inclusive

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

            // Check if product already exists in the order list
            bool productExists = false;
            foreach (DataRow row in orderListTable.Rows)
            {
                if (row["Product ID"].ToString() == prodId)
                {
                    // Update existing row
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                    row["Original Subtotal"] = Convert.ToDouble(row["Original Subtotal"]) + originalSubtotalVATInclusive;
                    row["Line Discount Amount"] = Convert.ToDouble(row["Line Discount Amount"]) + lineDiscountAmount;
                    row["Final Subtotal"] = Convert.ToDouble(row["Final Subtotal"]) + finalSubtotalVATInclusive;
                    // For merged items, "Unit Price After Discount" can be set to the average or the last added unit price.
                    // For simplicity, we are leaving it as the last added unit price here.
                    row["Unit Price After Discount"] = finalPricePerUnitVATInclusive;
                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                // Add new row to the order list DataTable
                orderListTable.Rows.Add(
                    prodId,
                    prodName,
                    quantity,
                    originalPricePerUnitVATInclusive,
                    finalPricePerUnitVATInclusive,
                    originalSubtotalVATInclusive,
                    lineDiscountAmount,
                    finalSubtotalVATInclusive
                );
            }

            UpdateTotals(); // Recalculate all totals including VAT
            ClearProductInputs(); // Clear selection for next item
            // After adding an item, reset discount fields
            currentDiscountType = string.Empty;
            currentDiscountValue = 0.0;
            isDiscountActive = false;
            DiscountValue.Text = "Discount"; // Reset discount label on UI
        }

        // --- Modified Method: UpdateTotals (formerly UpdateTotalPrice) ---
        // This method calculates and updates Partial Price, Total Discount, Total VAT, and Final Grand Total
        private void UpdateTotals()
        {
            grossSubtotalBeforeDiscount = 0; // Reset before recalculating
            totalLineDiscountAmount = 0;     // Reset before recalculating
            double currentFinalSubtotalAfterLineDiscount = 0; // Sum of "Final Subtotal" column from orderListTable

            foreach (DataRow row in orderListTable.Rows)
            {
                grossSubtotalBeforeDiscount += Convert.ToDouble(row["Original Subtotal"]);
                totalLineDiscountAmount += Convert.ToDouble(row["Line Discount Amount"]);
                currentFinalSubtotalAfterLineDiscount += Convert.ToDouble(row["Final Subtotal"]);
            }

            // Calculate Net Sales Before VAT (this is the base for VAT calculation)
            // If currentFinalSubtotalAfterLineDiscount is already VAT-inclusive, then netSalesBeforeVAT is
            // the value without VAT.
            netSalesBeforeVAT = currentFinalSubtotalAfterLineDiscount / (1 + VAT_RATE);

            // Calculate Total VAT Amount
            totalVATAmount = currentFinalSubtotalAfterLineDiscount - netSalesBeforeVAT; // (netSalesBeforeVAT * VAT_RATE);

            // The Cashier_Total_PriceOr will display the final grand total (including VAT, after discount)
            double finalGrandTotal = currentFinalSubtotalAfterLineDiscount; // This is already the final total.

            // Update UI labels
            label12.Text = grossSubtotalBeforeDiscount.ToString("C2");  // Partial Price (before any discounts)
            label7.Text = totalLineDiscountAmount.ToString("C2");     // Total Discount Applied
            vatValue.Text = totalVATAmount.ToString("C2");            // Total VAT Amount
            Cashier_Total_PriceOr.Text = finalGrandTotal.ToString("C2"); // Final Grand Total
        }

        // --- Method: Clear Product Inputs ---
        private void ClearProductInputs()
        {
            Cashier_ProductIDOr.SelectedIndex = -1; // Deselect
            Cashier_Product_NameOr.Text = "";
            Cashier_PriceOr.Text = "0.00"; // Reset price display
            Cashier_QuantityOr.Value = 1; // Reset quantity
        }

        private void Cashier_QuantityOr_ValueChanged(object sender, EventArgs e)
        {
            // This event handler remains empty as per previous discussions.
        }

        // --- Existing button handlers ---
        private void Remove_CashierOr_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;
                orderListTable.Rows.RemoveAt(rowIndex);
                UpdateTotals(); // Update all totals after removal
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the order list.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clear_CashierOr_Click(object sender, EventArgs e)
        {
            orderListTable.Clear();
            UpdateTotals(); // Reset all totals (which will become 0)
            ClearProductInputs();
            Cashier_AmountOr.Clear(); // Clear amount input
            Cashier_ChangeOr.Text = "0.00"; // Reset change display
            // Also reset discount and VAT variables when order is cleared
            currentDiscountType = string.Empty;
            currentDiscountValue = 0.0;
            isDiscountActive = false;
            grossSubtotalBeforeDiscount = 0.0;
            totalLineDiscountAmount = 0.0;
            netSalesBeforeVAT = 0.0;
            totalVATAmount = 0.0;
            DiscountValue.Text = "Discount"; // Reset discount label on UI
            MessageBox.Show("Order list cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Modified Event Handler: Cashier_Pay_OrdersOr_Click ---
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
            // The Cashier_Total_PriceOr now displays the final grand total (incl. VAT, after discount)
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

            // --- Start Stock Deduction Logic ---
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                else if (connect.State == ConnectionState.Broken)
                {
                    connect.Close();
                    connect.Open();
                }

                string updateQuery = "UPDATE products SET stock = stock - @quantity WHERE prod_id = @productId";

                foreach (DataRow row in orderListTable.Rows)
                {
                    string productId = row["Product ID"].ToString();
                    int orderedQuantity = Convert.ToInt32(row["Quantity"]);

                    using (SqlCommand command = new SqlCommand(updateQuery, connect))
                    {
                        command.Parameters.AddWithValue("@quantity", orderedQuantity);
                        command.Parameters.AddWithValue("@productId", productId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Stock updated successfully!", "Stock Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            // --- End Stock Deduction Logic ---

            double change = amountReceived - totalDue;
            Cashier_ChangeOr.Text = change.ToString("C2");
            MessageBox.Show($"Payment successful! Change: {change.ToString("C2")}", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            displayAllAvailableProducts(); // Refresh available products grid

            DialogResult result = MessageBox.Show("Payment successful! Do you want to print a receipt?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Cashier_ReceiptOr_Click(sender, e);
            }

            Clear_CashierOr_Click(sender, e); // Clear all order details, totals, and inputs
        }

        // --- Modified Event Handler: Cashier_ReceiptOr_Click ---
        private void Cashier_ReceiptOr_Click(object sender, EventArgs e)
        {
            if (orderListTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order to generate a receipt for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string receiptContent = "--- Receipt ---\n";
            // Updated column headers for receipt to show more detail
            receiptContent += "ProdID\tName\tQty\tOrig Price\tFinal Price\n"; //"Line Discount\n";
            receiptContent += "-------------------------------------------------------------------------------\n";  // Adjusted separator length

            foreach (DataRow row in orderListTable.Rows)
            {
                receiptContent += $"{row["Product ID"]}\t" +
                                  $"{row["Product Name"]}\t" +
                                  $"{row["Quantity"]}\t" +
                                  $"{Convert.ToDouble(row["Original Unit Price"]).ToString("F2")}\t" +
                                  $"{Convert.ToDouble(row["Unit Price After Discount"]).ToString("F2")}\n"; //+
                                  //$"{Convert.ToDouble(row["Line Discount Amount"]).ToString("F2")}\n";
            }

            receiptContent += "-------------------------------------------------------------------------------\n";
            receiptContent += $"Partial Total (Gross Sales before Discount): {grossSubtotalBeforeDiscount.ToString("C2")}\n";
            receiptContent += $"Total Line Discount Applied: {totalLineDiscountAmount.ToString("C2")}\n";
            receiptContent += $"Net Sales Before VAT: {netSalesBeforeVAT.ToString("C2")}\n"; // Explicitly showing Net Sales before VAT
            receiptContent += $"Total VAT (12%): {totalVATAmount.ToString("C2")}\n"; // Explicitly showing Total VAT
            receiptContent += $"Final Grand Total: {Cashier_Total_PriceOr.Text}\n"; // This is the total the customer pays

            double amountPaid = 0;
            if (double.TryParse(Cashier_AmountOr.Text, out amountPaid))
            {
                receiptContent += $"Amount Paid: {amountPaid.ToString("C2")}\n";
            }
            else
            {
                receiptContent += "Amount Paid: Not entered\n";
            }
            receiptContent += $"Change: {Cashier_ChangeOr.Text}\n";
            receiptContent += "-------------------------------------------------------------------------------\n";
            receiptContent += "Thank you for your purchase!\n";

            MessageBox.Show(receiptContent, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Event Handler: Discount_CashierOr_Click ---
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
                }
                else
                {
                    currentDiscountType = string.Empty;
                    currentDiscountValue = 0.0;
                    isDiscountActive = false;
                    DiscountValue.Text = "Discount";
                    MessageBox.Show("Discount application cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
