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
    }
}
