using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Assuming SQL Server is used
using POS_project.Migrations; // Required for AppDbContext
using Microsoft.EntityFrameworkCore; // Required for EF Core methods like Include

namespace POS_project
{
    public partial class Reports : UserControl
    {
        // Placeholder for database connection string. Replace with your actual connection string.
        // private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\renren\\Documents\\newDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True";

        public Reports()
        {
            InitializeComponent();
            InitializeReportFilters(); // Initialize filters on startup
            LoadReportData(); // Load initial data
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // Initial load logic can go here if needed, but InitializeReportFilters and LoadReportData are called in constructor
        }

        private void InitializeReportFilters()
        {
            // Set default values for date pickers to cover all records
            startTime_picker.Value = DateTime.Now; // Or a very old date
            endTime_picker.Value = DateTime.Now.AddDays(1); // Set to tomorrow to include today's full data

            // Set default for presetDateTime_comboBox to show "All"
            presetDateTime_comboBox.Items.Clear();
            presetDateTime_comboBox.Items.Add("All");
            presetDateTime_comboBox.Items.Add("Today");
            presetDateTime_comboBox.Items.Add("Yesterday");
            presetDateTime_comboBox.Items.Add("Last 7 Days");
            presetDateTime_comboBox.Items.Add("This Month");
            presetDateTime_comboBox.Items.Add("Last Month");
            presetDateTime_comboBox.Items.Add("Custom Range");
            presetDateTime_comboBox.SelectedItem = "All"; // Set "All" as default

            // Set default for cashier_Username to "All Cashiers"
            cashier_Username.Items.Clear();
            cashier_Username.Items.Add("All Cashiers");
            LoadCashiers();
            cashier_Username.SelectedItem = "All Cashiers";

            // Populate FilterFortheTable with categories
            FilterFortheTable.Items.Clear();
            FilterFortheTable.Items.Add("All Categories");
            // Populate with actual categories from the database
            LoadCategories();
            FilterFortheTable.SelectedItem = "All Categories"; // Default to all

            ResetFilters(); // Set default selections

            // Add event handlers
            presetDateTime_comboBox.SelectedIndexChanged += presetDateTime_comboBox_SelectedIndexChanged;
            cashier_Username.SelectedIndexChanged += cashier_Username_SelectedIndexChanged;
            FilterFortheTable.SelectedIndexChanged += FilterFortheTable_SelectedIndexChanged;
            button5.Click += button5_Click; // Search button
            button4.Click += button4_Click; // Clear button
            button6.Click += button6_Click; // Refresh button (assuming this is refresh based on designer)
            button2.Click += button2_Click; // Print Report
        }

        private void ResetFilters()
        {
            productName_or_id_search.Text = "Search product name or ID";
            startTime_picker.Value = DateTime.Now;
            endTime_picker.Value = DateTime.Now.AddDays(1);
            presetDateTime_comboBox.SelectedItem = "All"; // Set "All" as default
            cashier_Username.SelectedItem = "All Cashiers";
            FilterFortheTable.SelectedItem = "All Categories"; // Default to all
        }

        private void LoadReportData()
        {
            // This method will fetch data from the database and populate the DataGridView
            // Implement SQL queries based on selected filters (time, cashier, category, search)
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = BuildLinqQuery(context);

                    // Convert the LINQ query result to a DataTable for DataGridView binding
                    DataTable dt = new DataTable();

                    // Add columns to DataTable based on expected output
                    dt.Columns.Add("SaleDate", typeof(DateTime));
                    dt.Columns.Add("ProductName", typeof(string));
                    dt.Columns.Add("ProductCode", typeof(string));
                    dt.Columns.Add("Quantity", typeof(int));
                    dt.Columns.Add("UnitPrice", typeof(decimal));
                    dt.Columns.Add("ItemTotalPrice", typeof(decimal));
                    dt.Columns.Add("ItemDiscount", typeof(decimal));
                    dt.Columns.Add("ProductCategory", typeof(string));
                    dt.Columns.Add("CashierName", typeof(string));
                    dt.Columns.Add("TotalSalesGross", typeof(decimal));
                    dt.Columns.Add("AmountPaid", typeof(decimal));
                    dt.Columns.Add("ChangeGiven", typeof(decimal));

                    foreach (var item in query.ToList())
                    {
                        dt.Rows.Add(item.SaleDate,
                                    item.ProductName,
                                    item.ProductCode,
                                    item.Quantity,
                                    item.UnitPrice,
                                    item.ItemTotalPrice,
                                    item.ItemDiscount,
                                    item.ProductCategory,
                                    item.CashierName,
                                    item.TotalSalesGross,
                                    item.AmountPaid,
                                    item.ChangeGiven);
                    }
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message);
            }
        }

        private IQueryable<dynamic> BuildLinqQuery(AppDbContext context)
        {
            var query = context.SaleItems
                               .Include(si => si.Sale)
                               //.Include(si => si.Sale.Customers) // Assuming Customer is linked to Sale if needed for Sale.customer_id
                               .Include(si => si.Product) // Assuming a navigation property 'Product' in SaleItem pointing to Product entity
                               .Include(si => si.Product.Category) // Assuming a navigation property 'Category' in Product pointing to Category entity
                               .Include(si => si.Sale.Cashier) // Assuming a navigation property 'Cashier' in Sale pointing to User entity (Cashier)
                               .Select(si => new
                               {
                                   SaleDate = si.Sale.order_date,
                                   ProductName = si.ProdName,
                                   ProductCode = si.ProdId,
                                   Quantity = si.Quantity,
                                   UnitPrice = si.OrigPrice,
                                   ItemTotalPrice = si.TotalPrice,
                                   ItemDiscount = si.OrigPrice * si.Quantity - si.TotalPrice,
                                   ProductCategory = si.category, // Directly from SaleItem for now, can be si.Product.category or si.Product.Category.CategoryName if relationship is set up.
                                   CashierName = si.Sale.Cashier.Username, // This needs to be linked to User.Username. Assuming Sale.customer_id is the Username.
                                   TotalSalesGross = si.Sale.total_price,
                                   AmountPaid = si.Sale.amount,
                                   ChangeGiven = si.Sale.change
                               });


            // Date/Time Filtering
            if (presetDateTime_comboBox.SelectedItem != null && presetDateTime_comboBox.SelectedItem.ToString() != "All")
            {
                DateTime startDate = startTime_picker.Value;
                DateTime endDate = endTime_picker.Value;

                switch (presetDateTime_comboBox.SelectedItem.ToString())
                {
                    case "Today":
                        startDate = DateTime.Today;
                        endDate = DateTime.Today.AddDays(1).AddSeconds(-1);
                        break;
                    case "Yesterday":
                        startDate = DateTime.Today.AddDays(-1);
                        endDate = DateTime.Today.AddSeconds(-1);
                        break;
                    case "Last 7 Days":
                        startDate = DateTime.Today.AddDays(-7);
                        endDate = DateTime.Today.AddDays(1).AddSeconds(-1);
                        break;
                    case "This Month":
                        startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        endDate = startDate.AddMonths(1).AddSeconds(-1);
                        break;
                    case "Last Month":
                        startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
                        endDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddSeconds(-1);
                        break;
                    case "Custom Range":
                        // Dates are already set by the pickers
                        break;
                }
                query = query.Where(item => item.SaleDate >= startDate && item.SaleDate <= endDate);
            }

            // Product Search
            if (!string.IsNullOrEmpty(productName_or_id_search.Text) && productName_or_id_search.Text != "Search product name or ID")
            {
                string searchText = productName_or_id_search.Text;
                query = query.Where(item => item.ProductName.Contains(searchText) || item.ProductCode.Contains(searchText));
            }

            // Cashier Filter
            if (cashier_Username.SelectedItem != null && cashier_Username.SelectedItem.ToString() != "All Cashiers")
            {
                string selectedCashier = cashier_Username.SelectedItem.ToString();
                query = query.Where(item => item.CashierName == selectedCashier);
            }

            // Category Filter
            if (FilterFortheTable.SelectedItem != null && FilterFortheTable.SelectedItem.ToString() != "All Categories")
            {
                string selectedFilter = FilterFortheTable.SelectedItem.ToString();
                switch (selectedFilter)
                {
                    case "Sales by Time Period":
                        // Handled by date/time filtering.
                        break;
                    case "Sales by Product Category":
                        query = query.Where(item => item.ProductCategory == selectedFilter);
                        break;
                    case "Sales by Product":
                        // This is handled by the product search bar
                        break;
                    case "Sales by Salesperson/Cashier":
                        // Handled by the cashier filter.
                        break;
                    case "Product Name/Description":
                    case "SKU/Product Code":
                        // Handled by the product search bar.
                        break;
                    case "Quantity Sold":
                        query = query.Where(item => item.Quantity > 0);
                        break;
                    case "Unit Price":
                        query = query.Where(item => item.UnitPrice > 0);
                        break;
                    case "Item-level Discounts":
                        query = query.Where(item => item.ItemDiscount > 0);
                        break;
                    case "Total Sales (Gross)":
                        query = query.Where(item => item.TotalSalesGross > 0);
                        break;
                    case "Total Discounts":
                        // This would require summing item-level discounts per sale, or a dedicated column.
                        // For now, filtering for Total Discounts > 0 would mean that there's at least one item with a discount.
                        query = query.Where(item => item.ItemDiscount > 0); // Placeholder, assuming item discount contributes to total.
                        break;
                    case "Total Returns/Refunds":
                        MessageBox.Show("Total Returns/Refunds filter not fully implemented due to missing database schema support.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // No EF Core equivalent without schema modification.
                        break;
                    case "Net Sales":
                        // Net Sales = Total Sales (Gross) - Total Discounts (sum of item discounts) - Total Returns/Refunds
                        // This requires aggregation for total discounts per sale which is complex in direct LINQ without grouping.
                        // For now, a basic filter for positive net sales (gross sales - item discount) where total returns is 0.
                        query = query.Where(item => (item.TotalSalesGross - item.ItemDiscount) > 0); // Simplified, adjust if total discounts are aggregated differently
                        break;
                    default:
                        // For specific category selection from the database
                        query = query.Where(item => item.ProductCategory == selectedFilter);
                        break;
                }
            }

            return query;
        }

        private void presetDateTime_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adjust date pickers based on selection
            switch (presetDateTime_comboBox.SelectedItem.ToString())
            {
                case "Today":
                    startTime_picker.Value = DateTime.Today;
                    endTime_picker.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
                    startTime_picker.Enabled = false;
                    endTime_picker.Enabled = false;
                    break;
                case "Yesterday":
                    startTime_picker.Value = DateTime.Today.AddDays(-1);
                    endTime_picker.Value = DateTime.Today.AddSeconds(-1);
                    startTime_picker.Enabled = false;
                    endTime_picker.Enabled = false;
                    break;
                case "Last 7 Days":
                    startTime_picker.Value = DateTime.Today.AddDays(-7);
                    endTime_picker.Value = DateTime.Today.AddDays(1).AddSeconds(-1);
                    startTime_picker.Enabled = false;
                    endTime_picker.Enabled = false;
                    break;
                case "This Month":
                    startTime_picker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    endTime_picker.Value = startTime_picker.Value.AddMonths(1).AddSeconds(-1);
                    startTime_picker.Enabled = false;
                    endTime_picker.Enabled = false;
                    break;
                case "Last Month":
                    startTime_picker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
                    endTime_picker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddSeconds(-1);
                    startTime_picker.Enabled = false;
                    endTime_picker.Enabled = false;
                    break;
                case "Custom Range":
                    startTime_picker.Enabled = true;
                    endTime_picker.Enabled = true;
                    break;
                case "All":
                    startTime_picker.Value = DateTimePicker.MinimumDateTime;
                    endTime_picker.Value = DateTime.Now.AddDays(1);
                    startTime_picker.Enabled = false;
                    endTime_picker.Enabled = false;
                    break;
            }
            LoadReportData(); // Reload data when preset changes
        }

        private void cashier_Username_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData(); // Reload data when cashier selection changes
        }

        private void FilterFortheTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData(); // Reload data when category filter changes
        }

        private void button5_Click(object sender, EventArgs e) // Search button click
        {
            LoadReportData(); // Reload data with search filter
        }

        private void button4_Click(object sender, EventArgs e) // Clear button click
        {
            ResetFilters();
            LoadReportData();
        }

        private void button6_Click(object sender, EventArgs e) // Refresh button click
        {
            ResetFilters();
            LoadReportData();
        }

        private void button2_Click(object sender, EventArgs e) // Print Report button click
        {
            // Placeholder for Print Report
            MessageBox.Show("Print Report functionality is not yet implemented.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoadCashiers()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // Assuming 'Users' table and 'Role' column
                    var cashiers = context.Users.Where(u => u.Role == "Cashier").ToList();
                    foreach (var cashier in cashiers)
                    {
                        cashier_Username.Items.Add(cashier.Username);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cashiers: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // Assuming a 'Categories' table with a 'CategoryName' column
                    var categories = context.Categories.Select(c => c.CategoryName).ToList();
                    foreach (var category in categories)
                    {
                        FilterFortheTable.Items.Add(category);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
