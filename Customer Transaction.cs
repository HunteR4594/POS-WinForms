using POS_project.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_project
{
    public partial class Customer_Transaction : UserControl
    {
        private readonly AppDbContext _context;
        private readonly int _cashierId;

        public Customer_Transaction(int cashierId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _cashierId = cashierId;


            LoadTransactions();
        }

        private void LoadTransactions()
        {
            try
            {
                // Query the database for sales processed by the current cashier
                var transactions = _context.Sales
                    .Where(s => s.CashierId == _cashierId)
                    .Select(s => new
                    {
                        SaleId = s.id,
                        Total = s.total_price,
                        AmountPaid = s.amount,
                        Change = s.change,
                        Date = s.order_date
                    })
                    .ToList();

                // Bind the results to the DataGridView
                dataGridView1.DataSource = transactions;

                // Optionally, customize column headers for better readability
                dataGridView1.Columns["SaleId"].HeaderText = "Transaction ID";
                dataGridView1.Columns["Total"].HeaderText = "Total Price";
                dataGridView1.Columns["AmountPaid"].HeaderText = "Amount Paid";
                dataGridView1.Columns["Change"].HeaderText = "Change";
                dataGridView1.Columns["Date"].HeaderText = "Order Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
