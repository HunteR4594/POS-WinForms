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
    public partial class CashierForm : Form
    {
        private POS_project.CashierOrder currentOrderControl;

        public CashierForm()
        {
            InitializeComponent();
            MessageBox.Show("CashierForm Loaded");

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm1 = new Form1();
                this.Close();
                loginForm1.Show();
            }
        }

        private void cashierOrder1_Load(object sender, EventArgs e)
        {

        }

        //Order Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Add your logic for button2 click event here.
            MessageBox.Show("Add Users button clicked!");

            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            currentOrderControl = new POS_project.CashierOrder();
            currentOrderControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(currentOrderControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear any existing control in the panel3
            panel3.Controls.Clear();

            // Create an instance of your Barcode UserControl
            POS_project.Barcode barcodeUserControl = new POS_project.Barcode();

            // Subscribe to the BarcodeScanned event
            barcodeUserControl.BarcodeScanned += BarcodeUserControl_BarcodeScanned;

            // Make it fill the panel
            barcodeUserControl.Dock = DockStyle.Fill;

            // Add the UserControl to panel3
            panel3.Controls.Add(barcodeUserControl);
        }

        private void BarcodeUserControl_BarcodeScanned(object sender, string barcode)
        {
            using (var context = new AppDbContext())
            {
                var product = context.Products.FirstOrDefault(p => p.prod_id == barcode);
                if (product != null)
                {
                    if (currentOrderControl != null)
                    {
                        currentOrderControl.AddProductByBarcode(barcode);
                    }
                    else
                    {
                        MessageBox.Show("Order screen is not open. Please open the order screen to add products.", "Order Screen Not Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"No product found for barcode: {barcode}", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
    
}
