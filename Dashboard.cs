using System.Windows.Forms.DataVisualization;
namespace POS_project
{
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class Dashboard : UserControl
    {
        private Chart salesChart;
        private Chart topProductsChart;
        public Dashboard()
        {
            InitializeComponent();
            InitializeSalesChart();
            InitializeTopProductsChart();
        }

        private void InitializeSalesChart()
        {
            salesChart = new Chart();
            salesChart.Location = new System.Drawing.Point(16, 740); // Adjust as needed
            salesChart.Size = new System.Drawing.Size(1040, 300);
            var chartArea = new ChartArea();
            salesChart.ChartAreas.Add(chartArea);
            salesChart.Series.Add("Sales");
            salesChart.Series["Sales"].ChartType = SeriesChartType.Column;
            Controls.Add(salesChart);
        }

        private void InitializeTopProductsChart()
        {
            topProductsChart = new Chart();
            topProductsChart.Location = new System.Drawing.Point(16, 1050); // Adjust as needed
            topProductsChart.Size = new System.Drawing.Size(1040, 300);
            var chartArea = new ChartArea();
            topProductsChart.ChartAreas.Add(chartArea);
            topProductsChart.Series.Add("Top Products");
            topProductsChart.Series["Top Products"].ChartType = SeriesChartType.Bar;
            Controls.Add(topProductsChart);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = "Low Stock Products";
            dataGridView1.DataSource = ProductData.GetLowStockProducts();

            // --- Sales Trends Chart ---
            salesChart.Series["Sales"].Points.Clear();
            using (var context = new AppDbContext())
            {
                var today = DateTime.Today;
                var salesData = context.Sales
                    .Where(s => s.SaleDate >= today.AddDays(-6))
                    .GroupBy(s => s.SaleDate.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        Total = g.Sum(s => s.TotalAmount)
                    })
                    .ToList();

                for (int i = 6; i >= 0; i--)
                {
                    var date = today.AddDays(-i);
                    var daySales = salesData.FirstOrDefault(s => s.Date == date);
                    decimal total = daySales?.Total ?? 0;
                    salesChart.Series["Sales"].Points.AddXY(date.ToString("MM-dd"), total);
                }
            }

            // --- Top-Selling Products Chart ---
            topProductsChart.Series["Top Products"].Points.Clear();
            using (var context = new AppDbContext())
            {
                var today = DateTime.Today;
                var weekAgo = today.AddDays(-6);
                var topProducts = context.Set<CustomerOrderEntry>()
                    .Where(e => e.order_date >= weekAgo)
                    .GroupBy(e => e.prod_id)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        QuantitySold = g.Count()
                    })
                    .OrderByDescending(g => g.QuantitySold)
                    .Take(10)
                    .ToList();

                foreach (var item in topProducts)
                {
                    topProductsChart.Series["Top Products"].Points.AddXY(item.ProductId, item.QuantitySold);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
