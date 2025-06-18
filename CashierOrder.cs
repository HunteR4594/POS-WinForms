//using Microsoft.Data.SqlClient;
//using System.Data;

//namespace POS_project
//{
//    public partial class CashierOrder : UserControl
//    {
//        private SqlConnection connect;

//        public CashierOrder()
//        {
//            InitializeComponent();

//            connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");

//            displayAllAvailableProducts();
//            displayCategories();
//        }


//        public void displayAllAvailableProducts()
//        {
//            ProductData pData = new ProductData();
//            List<ProductData> listdata = pData.allAvailableProducts();

//            dataGridView1.DataSource = listdata;
//        }


//        public bool checkConnection()
//        {
//            if (connect.State == ConnectionState.Closed)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public void displayCategories()
//        {

//            if (checkConnection())
//            {
//                try
//                {
//                    connect.Open();
//                    String selectData = "SELECT * FROM categories";
//                    using (SqlCommand command = new SqlCommand(selectData, connect))
//                    {
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            Cashier_CategoryOr.Items.Clear();

//                            while (reader.Read())
//                            {
//                                string item = reader.GetString(1);
//                                Cashier_CategoryOr.Items.Add(item);
//                            }
//                        }
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//                finally
//                {
//                    // Ensures connection is closed. Good practice.
//                    if (connect.State == ConnectionState.Open)
//                    {
//                        connect.Close();
//                    }
//                }
//            }
//            // else if connection is not closed (i.e., open or broken), nothing happens,
//            // which might be an issue if displayCategories is called when it's already open.
//        }

//        private void Cashier_CategoryOr_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // This method is triggered when a category is selected from the ComboBox.
//            string selectedCategory = Cashier_CategoryOr.SelectedItem?.ToString();

//            if (selectedCategory != null)
//            {
//                if (checkConnection())
//                {
//                    try
//                    {
//                        connect.Open();

//                        // Corrected (assuming 'category' is the column storing category names in the products table):
//                        string selectData = "SELECT prod_id FROM products WHERE category = @category AND status = @status";

//                        using (SqlCommand command = new SqlCommand(selectData, connect))
//                        {
//                            command.Parameters.AddWithValue("@category", selectedCategory);
//                            command.Parameters.AddWithValue("@status", "Available");
//                            using (SqlDataReader reader = command.ExecuteReader())
//                            {
//                                Cashier_ProductIDOr.Items.Clear();

//                                while (reader.Read())
//                                {

//                                    string value = reader["prod_id"].ToString();
//                                    Cashier_ProductIDOr.Items.Add(value);
//                                }
//                            }
//                        }
//                    }
//                    catch (Exception ex)
//                    {

//                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                    finally
//                    {

//                        if (connect.State == ConnectionState.Open)
//                        {
//                            connect.Close();
//                        }
//                    }
//                }
//            }
//        }

//        private void Cashier_QuantityOr_ValueChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}



//using Microsoft.Data.SqlClient;
//using System.Data; // Required for DataTable
//using System.Windows.Forms; // Ensure this is present for MessageBox, UserControl etc.

//namespace POS_project
//{
//    public partial class CashierOrder : UserControl
//    {
//        private SqlConnection connect;
//        // DataTable to hold the items in the current order
//        private DataTable orderListTable;

//        public CashierOrder()
//        {
//            InitializeComponent();

//            connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");

//            // Initialize the order list DataTable and set it as DataSource for dataGridView2
//            InitializeOrderListTable();

//            displayAllAvailableProducts();
//            displayCategories();
//        }

//        // --- New Method: Initialize Order List Table ---
//        private void InitializeOrderListTable()
//        {
//            orderListTable = new DataTable();
//            orderListTable.Columns.Add("Product ID", typeof(string));
//            orderListTable.Columns.Add("Product Name", typeof(string));
//            orderListTable.Columns.Add("Quantity", typeof(int));
//            orderListTable.Columns.Add("Price", typeof(double)); // Price per unit
//            orderListTable.Columns.Add("Subtotal", typeof(double)); // Price * Quantity

//            dataGridView2.DataSource = orderListTable; // Bind the DataTable to dataGridView2
//            // Ensure currency formatting for price and subtotal columns
//            dataGridView2.Columns["Price"].DefaultCellStyle.Format = "C2";
//            dataGridView2.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
//        }

//        public void displayAllAvailableProducts()
//        {
//            ProductData pData = new ProductData();
//            // Using your allAvailableProducts method
//            List<ProductData> listdata = pData.allAvailableProducts();

//            dataGridView1.DataSource = listdata;
//        }

//        public bool checkConnection()
//        {
//            // Only return true if connection is CLOSED, so we can open it.
//            return connect.State == ConnectionState.Closed;
//        }

//        public void displayCategories()
//        {
//            if (checkConnection())
//            {
//                try
//                {
//                    connect.Open();
//                    String selectData = "SELECT category FROM categories"; // Only fetch category names
//                    using (SqlCommand command = new SqlCommand(selectData, connect))
//                    {
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            Cashier_CategoryOr.Items.Clear(); // Clear existing items

//                            while (reader.Read())
//                            {
//                                string item = reader.GetString(0); // Assuming category name is the first column
//                                Cashier_CategoryOr.Items.Add(item);
//                            }
//                        }
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//                finally
//                {
//                    if (connect.State == ConnectionState.Open)
//                    {
//                        connect.Close();
//                    }
//                }
//            }
//            // If connection is not closed, nothing happens, which is fine for this method.
//        }

//        private void Cashier_CategoryOr_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            string selectedCategory = Cashier_CategoryOr.SelectedItem?.ToString();

//            if (selectedCategory != null)
//            {
//                if (checkConnection())
//                {
//                    try
//                    {
//                        connect.Open();
//                        // Select product ID, name, and price for the selected category
//                        string selectData = "SELECT prod_id, prod_name, prod_price FROM products WHERE category = @category AND status = 'Available'";

//                        using (SqlCommand command = new SqlCommand(selectData, connect))
//                        {
//                            command.Parameters.AddWithValue("@category", selectedCategory);
//                            using (SqlDataReader reader = command.ExecuteReader())
//                            {
//                                Cashier_ProductIDOr.Items.Clear();
//                                // Clear related fields when category changes
//                                ClearProductInputs();

//                                while (reader.Read())
//                                {
//                                    string productId = reader["prod_id"].ToString();
//                                    Cashier_ProductIDOr.Items.Add(productId);
//                                }
//                            }
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show("Error loading products for category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                    finally
//                    {
//                        if (connect.State == ConnectionState.Open)
//                        {
//                            connect.Close();
//                        }
//                    }
//                }
//            }
//        }

//        // --- New Event Handler: dataGridView1_CellClick ---
//        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            // Ensure a valid row is clicked (not header or empty space)
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

//                // Get data from the clicked row using YOUR ProductData properties
//                string productId = row.Cells["ProdID"].Value?.ToString();
//                string productName = row.Cells["ProdName"].Value?.ToString();
//                // Price is string in ProductData, convert to double for calculation/display
//                double productPrice = 0.0;
//                if (row.Cells["Price"].Value != null)
//                {
//                    double.TryParse(row.Cells["Price"].Value.ToString(), out productPrice);
//                }

//                // Display data in the respective controls
//                Cashier_ProductIDOr.SelectedItem = productId; // Select the ID in the ComboBox
//                Cashier_Product_NameOr.Text = productName;
//                Cashier_PriceOr.Text = productPrice.ToString("F2"); // Format price to 2 decimal places

//                Cashier_QuantityOr.Value = 1; // Reset quantity to 1 for new selection
//            }
//        }

//        // --- New Event Handler: Add_CashierOr_Click ---
//        private void Add_CashierOr_Click(object sender, EventArgs e)
//        {
//            // Basic validation
//            if (string.IsNullOrEmpty(Cashier_Product_NameOr.Text) || Cashier_ProductIDOr.SelectedItem == null)
//            {
//                MessageBox.Show("Please select a product first.", "Missing Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (Cashier_QuantityOr.Value <= 0)
//            {
//                MessageBox.Show("Quantity must be greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            string prodId = Cashier_ProductIDOr.SelectedItem.ToString();
//            string prodName = Cashier_Product_NameOr.Text;
//            int quantity = (int)Cashier_QuantityOr.Value;
//            double pricePerUnit = Convert.ToDouble(Cashier_PriceOr.Text); // Get price from displayed label
//            double subtotal = pricePerUnit * quantity;

//            // Check if product already exists in the order list
//            bool productExists = false;
//            foreach (DataRow row in orderListTable.Rows)
//            {
//                if (row["Product ID"].ToString() == prodId)
//                {
//                    // Update quantity and subtotal if product already exists
//                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
//                    row["Subtotal"] = Convert.ToDouble(row["Subtotal"]) + subtotal;
//                    productExists = true;
//                    break;
//                }
//            }

//            if (!productExists)
//            {
//                // Add new row to the order list DataTable
//                orderListTable.Rows.Add(prodId, prodName, quantity, pricePerUnit, subtotal);
//            }

//            UpdateTotalPrice(); // Update the total price
//            ClearProductInputs(); // Clear selection for next item
//        }

//        // --- New Method: Update Total Price ---
//        private void UpdateTotalPrice()
//        {
//            double total = 0;
//            foreach (DataRow row in orderListTable.Rows)
//            {
//                total += Convert.ToDouble(row["Subtotal"]);
//            }
//            Cashier_Total_PriceOr.Text = total.ToString("C2"); // Format as currency
//        }

//        // --- New Method: Clear Product Inputs ---
//        private void ClearProductInputs()
//        {
//            Cashier_ProductIDOr.SelectedIndex = -1; // Deselect
//            Cashier_Product_NameOr.Text = "";
//            Cashier_PriceOr.Text = "0.00"; // Reset price display
//            Cashier_QuantityOr.Value = 1; // Reset quantity
//        }

//        private void Cashier_QuantityOr_ValueChanged(object sender, EventArgs e)
//        {
//            // This event is still technically empty in terms of new logic,
//            // but it's part of the designer and kept here.
//            // If you wanted dynamic price preview, this is where you'd add it.
//            // Example:
//            // if (double.TryParse(Cashier_PriceOr.Text, out double price) && Cashier_QuantityOr.Value > 0)
//            // {
//            //     double currentSubtotal = price * (double)Cashier_QuantityOr.Value;
//            //     // You might display this subtotal somewhere, or it's implicitly handled when 'Add' is clicked.
//            // }
//        }

//        // --- Existing button handlers (now with basic implementation) ---
//        private void Remove_CashierOr_Click(object sender, EventArgs e)
//        {
//            // Implement logic to remove selected item from dataGridView2 and update total
//            if (dataGridView2.SelectedRows.Count > 0)
//            {
//                int rowIndex = dataGridView2.SelectedRows[0].Index;
//                orderListTable.Rows.RemoveAt(rowIndex);
//                UpdateTotalPrice();
//            }
//            else
//            {
//                MessageBox.Show("Please select an item to remove from the order list.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }

//        private void Clear_CashierOr_Click(object sender, EventArgs e)
//        {
//            // Implement logic to clear all items from dataGridView2 and reset total
//            orderListTable.Clear();
//            UpdateTotalPrice();
//            ClearProductInputs();
//            Cashier_AmountOr.Clear(); // Clear amount input
//            Cashier_ChangeOr.Text = "0.00"; // Reset change display
//            MessageBox.Show("Order list cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void Cashier_Pay_OrdersOr_Click(object sender, EventArgs e)
//        {
//            // Implement payment processing logic here:
//            // 1. Validate amount entered in Cashier_AmountOr
//            // 2. Calculate change based on Cashier_Total_PriceOr and Cashier_AmountOr
//            // 3. Display change in Cashier_ChangeOr
//            // 4. Optionally, save transaction to database, update inventory, etc.
//            if (orderListTable.Rows.Count == 0)
//            {
//                MessageBox.Show("No items in the order to pay for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (string.IsNullOrEmpty(Cashier_AmountOr.Text))
//            {
//                MessageBox.Show("Please enter the amount received.", "Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (!double.TryParse(Cashier_AmountOr.Text, out double amountReceived))
//            {
//                MessageBox.Show("Invalid amount entered. Please enter a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            double totalDue = 0;
//            // Parse the total price from the label, removing currency symbol
//            if (double.TryParse(Cashier_Total_PriceOr.Text.Replace("₱", "").Replace("$", "").Trim(), out totalDue))
//            {
//                if (amountReceived >= totalDue)
//                {
//                    double change = amountReceived - totalDue;
//                    Cashier_ChangeOr.Text = change.ToString("C2");
//                    MessageBox.Show($"Payment successful! Change: {change.ToString("C2")}", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    // Here you would add logic to save the order, update stock, etc.
//                    // For now, let's clear the order after payment for demonstration
//                    Clear_CashierOr_Click(sender, e); // Re-use clear logic
//                }
//                else
//                {
//                    MessageBox.Show($"Insufficient amount. Total due: {totalDue.ToString("C2")}", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                }
//            }
//            else
//            {
//                MessageBox.Show("Error parsing total price. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void Cashier_ReceiptOr_Click(object sender, EventArgs e)
//        {
//            // Implement receipt generation logic here.
//            // You might open a new form to display the receipt, print it, etc.
//            if (orderListTable.Rows.Count == 0)
//            {
//                MessageBox.Show("No items in the order to generate a receipt for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                return;
//            }

//            string receiptContent = "--- Receipt ---\n";
//            receiptContent += "Product ID\tName\tQty\tPrice\tSubtotal\n";
//            receiptContent += "---------------------------------------------------\n";

//            foreach (DataRow row in orderListTable.Rows)
//            {
//                receiptContent += $"{row["Product ID"]}\t{row["Product Name"]}\t{row["Quantity"]}\t{Convert.ToDouble(row["Price"]).ToString("F2")}\t{Convert.ToDouble(row["Subtotal"]).ToString("F2")}\n";
//            }

//            receiptContent += "---------------------------------------------------\n";
//            receiptContent += $"Total: {Cashier_Total_PriceOr.Text}\n";

//            double amountPaid = 0;
//            if (double.TryParse(Cashier_AmountOr.Text, out amountPaid))
//            {
//                receiptContent += $"Amount Paid: {amountPaid.ToString("C2")}\n";
//            }
//            else
//            {
//                receiptContent += "Amount Paid: Not entered\n";
//            }
//            receiptContent += $"Change: {Cashier_ChangeOr.Text}\n";
//            receiptContent += "---------------------------------------------------\n";
//            receiptContent += "Thank you for your purchase!\n";

//            MessageBox.Show(receiptContent, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//    }
//}


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

        public CashierOrder()
        {
            InitializeComponent();

            // IMPORTANT: Only attempt database connection and data loading if NOT in design mode
            if (!this.DesignMode)
            {
                // This connection string is for CashierOrder's direct use.
                connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renren\Documents\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");

                // These methods interact with the database, so they should be inside this block.
                displayAllAvailableProducts();
                displayCategories();
            }

            // Initialize the order list DataTable. This is OK at design time
            // as it only sets up the table structure, not connects to DB.
            InitializeOrderListTable();
        }

        // --- Initialize Order List Table ---
        private void InitializeOrderListTable()
        {
            orderListTable = new DataTable();
            orderListTable.Columns.Add("Product ID", typeof(string));
            orderListTable.Columns.Add("Product Name", typeof(string));
            orderListTable.Columns.Add("Quantity", typeof(int));
            orderListTable.Columns.Add("Price", typeof(double)); // Price per unit
            orderListTable.Columns.Add("Subtotal", typeof(double)); // Price * Quantity

            dataGridView2.DataSource = orderListTable; // Bind the DataTable to dataGridView2
            // Ensure currency formatting for price and subtotal columns
            dataGridView2.Columns["Price"].DefaultCellStyle.Format = "C2";
            dataGridView2.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }

        public void displayAllAvailableProducts()
        {
            ProductData pData = new ProductData();
            // Using your allAvailableProducts method to display available products in dataGridView1
            List<ProductData> listdata = pData.allAvailableProducts();

            dataGridView1.DataSource = listdata;
            // Optionally, refresh column headers if they disappear after binding
            dataGridView1.AutoGenerateColumns = true;
        }

        public bool checkConnection()
        {
            // Only return true if connection is CLOSED, so we can open it.
            return connect.State == ConnectionState.Closed;
        }

        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    String selectData = "SELECT category FROM categories"; // Only fetch category names
                    using (SqlCommand command = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Cashier_CategoryOr.Items.Clear(); // Clear existing items

                            while (reader.Read())
                            {
                                string item = reader.GetString(0); // Assuming category name is the first column
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
                        // Select product ID, name, and price for the selected category
                        string selectData = "SELECT prod_id, prod_name, prod_price FROM products WHERE category = @category AND status = 'Available'";

                        using (SqlCommand command = new SqlCommand(selectData, connect))
                        {
                            command.Parameters.AddWithValue("@category", selectedCategory);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                Cashier_ProductIDOr.Items.Clear();
                                // Clear related fields when category changes
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
            // Ensure a valid row is clicked (not header or empty space)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Get data from the clicked row using YOUR ProductData properties
                string productId = row.Cells["ProdID"].Value?.ToString();
                string productName = row.Cells["ProdName"].Value?.ToString();
                // Price is string in ProductData, convert to double for calculation/display
                double productPrice = 0.0;
                if (row.Cells["Price"].Value != null)
                {
                    // Use TryParse to safely convert string price to double
                    double.TryParse(row.Cells["Price"].Value.ToString(), out productPrice);
                }

                // Display data in the respective controls
                Cashier_ProductIDOr.SelectedItem = productId; // Select the ID in the ComboBox (if it exists)
                Cashier_Product_NameOr.Text = productName;
                Cashier_PriceOr.Text = productPrice.ToString("F2"); // Format price to 2 decimal places

                Cashier_QuantityOr.Value = 1; // Reset quantity to 1 for new selection
            }
        }

        // --- Event Handler: Add_CashierOr_Click ---
        private void Add_CashierOr_Click(object sender, EventArgs e)
        {
            // Basic validation
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
            double pricePerUnit = Convert.ToDouble(Cashier_PriceOr.Text); // Get price from displayed label
            double subtotal = pricePerUnit * quantity;

            // Check if product already exists in the order list
            bool productExists = false;
            foreach (DataRow row in orderListTable.Rows)
            {
                if (row["Product ID"].ToString() == prodId)
                {
                    // Update quantity and subtotal if product already exists
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                    row["Subtotal"] = Convert.ToDouble(row["Subtotal"]) + subtotal;
                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                // Add new row to the order list DataTable
                orderListTable.Rows.Add(prodId, prodName, quantity, pricePerUnit, subtotal);
            }

            UpdateTotalPrice(); // Update the total price
            ClearProductInputs(); // Clear selection for next item
        }

        // --- Method: Update Total Price ---
        private void UpdateTotalPrice()
        {
            double total = 0;
            foreach (DataRow row in orderListTable.Rows)
            {
                total += Convert.ToDouble(row["Subtotal"]);
            }
            Cashier_Total_PriceOr.Text = total.ToString("C2"); // Format as currency
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
            // You can add logic here if you want real-time subtotal previews.
        }

        // --- Existing button handlers (now with basic implementation) ---
        private void Remove_CashierOr_Click(object sender, EventArgs e)
        {
            // Logic to remove selected item from dataGridView2 and update total
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;
                orderListTable.Rows.RemoveAt(rowIndex);
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the order list.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // IMPORTANT: No stock change here as per requirement. Stock only changes on 'Pay Orders'.
        }

        private void Clear_CashierOr_Click(object sender, EventArgs e)
        {
            // Logic to clear all items from dataGridView2 and reset total
            orderListTable.Clear();
            UpdateTotalPrice();
            ClearProductInputs();
            Cashier_AmountOr.Clear(); // Clear amount input
            Cashier_ChangeOr.Text = "0.00"; // Reset change display
            MessageBox.Show("Order list cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // IMPORTANT: No stock change here as per requirement. Stock only changes on 'Pay Orders'.
        }

        // --- MODIFIED Event Handler: Cashier_Pay_OrdersOr_Click ---
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
            // Parse the total price from the label, removing currency symbol
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
                // Ensure connection is open for database updates
                if (checkConnection())
                {
                    connect.Open();
                }
                else if (connect.State == ConnectionState.Broken || connect.State == ConnectionState.Closed)
                {
                    // Attempt to reopen if broken or closed unexpectedly
                    connect.Close(); // Ensure it's fully closed before reopening
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
                        command.ExecuteNonQuery(); // Execute the update command
                    }
                }

                MessageBox.Show("Stock updated successfully!", "Stock Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally, you might want to revert the transaction if an error occurs mid-update
                // For simplicity, we are not implementing transaction rollback here.
                return; // Stop payment process if stock update fails
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            // --- End Stock Deduction Logic ---

            // Payment calculation and display
            double change = amountReceived - totalDue;
            Cashier_ChangeOr.Text = change.ToString("C2");
            MessageBox.Show($"Payment successful! Change: {change.ToString("C2")}", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh available products grid to reflect new stock levels
            displayAllAvailableProducts();

            // --- Receipt Print Option ---
            DialogResult result = MessageBox.Show("Payment successful! Do you want to print a receipt?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Cashier_ReceiptOr_Click(sender, e); // Call the receipt generation logic
            }

            // Clear the order after successful payment and potential receipt printing
            Clear_CashierOr_Click(sender, e); // Re-use clear logic
            Cashier_AmountOr.Clear(); // Clear amount input
            Cashier_ChangeOr.Text = "0.00"; // Reset change display after final clear
        }

        private void Cashier_ReceiptOr_Click(object sender, EventArgs e)
        {
            // Implement receipt generation logic here.
            // You might open a new form to display the receipt, print it, etc.
            if (orderListTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order to generate a receipt for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string receiptContent = "--- Receipt ---\n";
            receiptContent += "Product ID\tName\tQty\tPrice\tSubtotal\n";
            receiptContent += "---------------------------------------------------\n";

            foreach (DataRow row in orderListTable.Rows)
            {
                receiptContent += $"{row["Product ID"]}\t{row["Product Name"]}\t{row["Quantity"]}\t{Convert.ToDouble(row["Price"]).ToString("F2")}\t{Convert.ToDouble(row["Subtotal"]).ToString("F2")}\n";
            }

            receiptContent += "---------------------------------------------------\n";
            receiptContent += $"Total: {Cashier_Total_PriceOr.Text}\n";

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
            receiptContent += "---------------------------------------------------\n";
            receiptContent += "Thank you for your purchase!\\n";

            MessageBox.Show(receiptContent, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
