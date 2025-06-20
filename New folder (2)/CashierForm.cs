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
                CashierForm loginForm = new CashierForm();
                loginForm.Show();
                this.Hide();
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
            POS_project.CashierOrder myControl = new POS_project.CashierOrder();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);
        }
    }
}
