using System;
using System.Linq;
using System.Windows.Forms;
using POS_project.Migrations;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.EntityFrameworkCore;
using LiveChartsCore.Defaults;
using System.Collections.Generic;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.WinForms;
//using LiveChartsCore.SkiaSharpView.Labelers;    
using System.Data;
using System.Drawing;


namespace POS_project
{
    public partial class CA_Dashboard : UserControl
    {
        private readonly AppDbContext _context;

        public ISeries[] tOrderChartSeries { get; set; }
        public ISeries[] tSalesChartSeries { get; set; }
        public Axis[] tSalesChartXAxes { get; set; } = new Axis[] { new Axis { IsVisible = false } };
        public Axis[] tSalesChartYAxes { get; set; } = new Axis[] { new Axis { IsVisible = false } };


        public CA_Dashboard()
        {
            InitializeComponent();
            _context = new AppDbContext();
            this.Load += CA_Dashboard_Load;
        }

        private void CA_Dashboard_Load(object sender, EventArgs e)
        {
            // Set default selections for dropdowns
            if (pieChartComboBox.Items.Count > 0)
                pieChartComboBox.SelectedIndex = 0;
            if (salesChartComboBox.Items.Count > 0)
                salesChartComboBox.SelectedIndex = 0;

            PopulateKpis();
            UpdatePieChart();
            UpdateSalesChart();
        }

        private void PopulateKpis()
        {
            var today = DateTime.Today;

            // Top 5 Selling Products (count)
            var top5Products = _context.SaleItems
                .Where(si => si.Sale.order_date.Date == today)
                .GroupBy(si => si.Product.prod_name)
                .Select(g => new { ProductName = g.Key, Quantity = g.Sum(si => si.Quantity) })
                .OrderByDescending(x => x.Quantity)
                .Take(5)
                .ToList();
            tOrdersLbl.Text = top5Products.Count().ToString();

            // Today's Sales
            var todaysSales = _context.Sales
                .Where(s => s.order_date.Date == today)
                .Sum(s => (decimal?)s.total_price) ?? 0;
            tSalesLbl.Text = todaysSales.ToString("C2");

            // Monthly Sales
            var monthlySales = _context.Sales
                .Where(s => s.order_date.Year == today.Year && s.order_date.Month == today.Month)
                .Sum(s => (decimal?)s.total_price) ?? 0;
            mSalesLbl.Text = monthlySales.ToString("C2");

            // Total Discount
            var discountedItemsToday = _context.SaleItems
                 .Where(si => si.Sale.order_date.Date == today && si.OrigPrice != si.TotalPrice)
                 .Count();
            totalDiscLbl.Text = discountedItemsToday.ToString();
        }

        private void UpdatePieChart()
        {
            if (pieChartComboBox.SelectedItem == null) return;

            string selectedOption = pieChartComboBox.SelectedItem.ToString();
            ISeries[] pieSeries;

            if (selectedOption == "Sales by Category")
            {
                label2.Text = "SALES BY CATEGORY";
                var salesByCategory = _context.SaleItems
                    .Include(si => si.Product.Category)
                    .GroupBy(si => si.Product.Category.CategoryName)
                    .Select(g => new { Category = g.Key, TotalSales = g.Sum(si => (double)si.TotalPrice) })
                    .ToList();

                pieSeries = salesByCategory.Select(s => new PieSeries<double>
                {
                    Values = new[] { s.TotalSales },
                    Name = s.Category
                }).ToArray();
            }
            else // Top 5 Selling Products by Revenue
            {
                label2.Text = "TOP 5 SELLING PRODUCTS BY REVENUE";
                var topProducts = _context.SaleItems
                    .GroupBy(si => si.Product.prod_name)
                    .Select(g => new { Name = g.Key, Revenue = g.Sum(si => (double)si.TotalPrice) })
                    .OrderByDescending(x => x.Revenue)
                    .Take(5)
                    .ToList();

                pieSeries = topProducts.Select(p => new PieSeries<double>
                {
                    Values = new[] { p.Revenue },
                    Name = p.Name
                }).ToArray();
            }
            pieChart1.Series = pieSeries;
        }

        private void UpdateSalesChart()
        {
            if (salesChartComboBox.SelectedItem == null) return;

            string selectedOption = salesChartComboBox.SelectedItem.ToString();
            List<ISeries> series = new List<ISeries>();
            List<string> labels = new List<string>();

            if (selectedOption == "Daily Sales")
            {
                tSalesChartTitleLbl.Text = "DAILY SALES";
                var salesData = _context.Sales
                    .Where(s => s.order_date >= DateTime.Today.AddDays(-6))
                    .GroupBy(s => s.order_date.Date)
                    .Select(g => new { Date = g.Key, Total = g.Sum(s => (double)s.total_price) })
                    .OrderBy(x => x.Date)
                    .ToList();

                series.Add(new ColumnSeries<double> { Values = salesData.Select(s => s.Total).ToList(), Name = "Sales" }); labels = salesData.Select(s => s.Date.ToString("ddd")).ToList();
            }
            else if (selectedOption == "Monthly Sales")
            {
                tSalesChartTitleLbl.Text = "MONTHLY SALES";
                var salesData = _context.Sales
                    .Where(s => s.order_date.Year == DateTime.Now.Year)
                    .GroupBy(s => s.order_date.Month)
                    .Select(g => new { Month = g.Key, Total = g.Sum(s => (double)s.total_price) })
                    .OrderBy(x => x.Month)
                    .ToList();
                series.Add(new ColumnSeries<double> { Values = salesData.Select(s => s.Total).ToList(), Name = "Sales" }); labels = salesData.Select(s => new DateTime(DateTime.Now.Year, s.Month, 1).ToString("MMM")).ToList();
            }
            else // Yearly Sales
            {
                tSalesChartTitleLbl.Text = "YEARLY SALES";
                var salesData = _context.Sales
                    .GroupBy(s => s.order_date.Year)
                    .Select(g => new { Year = g.Key, Total = g.Sum(s => (double)s.total_price) })
                    .OrderBy(x => x.Year)
                    .ToList();
                series.Add(new ColumnSeries<double> { Values = salesData.Select(s => s.Total).ToList(), Name = "Sales" }); labels = salesData.Select(s => s.Year.ToString()).ToList();
            }

            cartesianChart3.Series = series;
            cartesianChart3.XAxes = new[]
            {
                new Axis { Labels = labels, Name = "Date" }
            };
            cartesianChart3.YAxes = new[]
            {
                new Axis { Name = "Revenue", Labeler = value => value.ToString("C") }
            };
        }

        private void pieChartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePieChart();
        }

        private void salesChartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSalesChart();
        }

        private void tOrdersLbl_Click(object sender, EventArgs e)
        {

        }

        private void tSalesLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
