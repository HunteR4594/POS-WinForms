using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Microsoft.EntityFrameworkCore;
using POS_project.Migrations;
using SkiaSharp;

namespace POS_project
{
    public partial class NewDashboard : UserControl
    {
        public NewDashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            using (var context = new AppDbContext())
            {
                // Calculate total discounts for the day
                var today = DateTime.Today;
                var salesToday = context.Sales
                    .Include(s => s.SaleItems)
                    .Where(s => s.order_date.Date == today)
                    .ToList();

                decimal totalDiscountToday = 0;
                foreach (var sale in salesToday)
                {
                    foreach (var item in sale.SaleItems)
                    {
                        totalDiscountToday += (item.OrigPrice * item.Quantity) - item.TotalPrice;
                    }
                }
                totalDiscLbl.Text = totalDiscountToday.ToString("C2");

                // Unavailable Stocks Chart
                var unavailableCount = context.Products.Count(p => p.status == "Unavailable");
                var availableCount = context.Products.Count(p => p.status == "Available");

                pieChart1.Series = new ISeries[]
                {
                    new PieSeries<int> { Values = new int[] { unavailableCount }, Name = "Unavailable" },
                    new PieSeries<int> { Values = new int[] { availableCount }, Name = "Available" }
                };
            }
        }

        private void pieChartPanel_Click(object sender, System.EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var unavailableProducts = context.Products.Where(p => p.status == "Unavailable").ToList();
                string productList = string.Join("\n", unavailableProducts.Select(p => $"{p.prod_id} - {p.prod_name}"));
                if (string.IsNullOrEmpty(productList))
                {
                    productList = "No unavailable products found.";
                }
                MessageBox.Show("Unavailable Products:\n" + productList, "Unavailable Products");
            }
        }
    }
}
