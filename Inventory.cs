using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_Gabayno
{
    public partial class Inventory


    {
        public Inventory()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void inventoryDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public class Product
        {
            public int ProductID { get; set; }
            public required string ProductName { get; set; }
            public required string Category { get; set; }
            public int Quantity { get; set; }
            public required string Status { get; set; }
            public int AddStock { get; set; }
            public int DeleteProduct { get; set; }

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            DASHBOARD dASHBOARD = new DASHBOARD();
            dASHBOARD.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addproductBtn_Click(object sender, EventArgs e)
        {
   

        }
    }
}

