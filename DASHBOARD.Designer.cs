namespace POS_Gabayno
{
    partial class DASHBOARD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            mSalesPanel = new Panel();
            mSaleIcon = new PictureBox();
            mSalesCount = new Label();
            mSalesLbl = new Label();
            refundPanel = new Panel();
            refundIcon = new PictureBox();
            refundCount = new Label();
            refundLbl = new Label();
            tSalesPanel = new Panel();
            tSaleIcon = new PictureBox();
            tSalesCount = new Label();
            tSalesLbl = new Label();
            tOrderPanel = new Panel();
            tOrderIcon = new PictureBox();
            tOrderCount = new Label();
            tOrderLbl = new Label();
            sidebarPanel = new Panel();
            logoutBtn = new Button();
            inventoryBtn = new Button();
            employeeBtn = new Button();
            reportsBtn = new Button();
            salesTerminalBtn = new Button();
            dashboardBtn = new Button();
            dashSidebarLbl = new Label();
            tOrderChartLbl = new Label();
            tSalesChartPanel = new Panel();
            tSalesChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tOrdChartPnl = new Panel();
            label1 = new Label();
            tOrderChartPie = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            mSalesChartPnl = new Panel();
            mSaleChartLbl = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1 = new Panel();
            refundChartLbl = new Label();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            mainPanel.SuspendLayout();
            mSalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mSaleIcon).BeginInit();
            refundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refundIcon).BeginInit();
            tSalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tSaleIcon).BeginInit();
            tOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tOrderIcon).BeginInit();
            sidebarPanel.SuspendLayout();
            tSalesChartPanel.SuspendLayout();
            tOrdChartPnl.SuspendLayout();
            mSalesChartPnl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(mSalesChartPnl);
            mainPanel.Controls.Add(tSalesChartPanel);
            mainPanel.Controls.Add(mSalesPanel);
            mainPanel.Controls.Add(refundPanel);
            mainPanel.Controls.Add(tSalesPanel);
            mainPanel.Controls.Add(tOrderPanel);
            mainPanel.Controls.Add(tOrdChartPnl);
            mainPanel.Location = new Point(1, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1369, 742);
            mainPanel.TabIndex = 0;
            // 
            // mSalesPanel
            // 
            mSalesPanel.BackColor = Color.Teal;
            mSalesPanel.BorderStyle = BorderStyle.FixedSingle;
            mSalesPanel.Controls.Add(mSaleIcon);
            mSalesPanel.Controls.Add(mSalesCount);
            mSalesPanel.Controls.Add(mSalesLbl);
            mSalesPanel.Location = new Point(838, 64);
            mSalesPanel.Name = "mSalesPanel";
            mSalesPanel.Size = new Size(249, 153);
            mSalesPanel.TabIndex = 3;
            mSalesPanel.Paint += mSalesPanel_Paint;
            // 
            // mSaleIcon
            // 
            mSaleIcon.Image = Properties.Resources.mSale;
            mSaleIcon.Location = new Point(14, 56);
            mSaleIcon.Name = "mSaleIcon";
            mSaleIcon.Size = new Size(63, 62);
            mSaleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            mSaleIcon.TabIndex = 3;
            mSaleIcon.TabStop = false;
            // 
            // mSalesCount
            // 
            mSalesCount.AutoSize = true;
            mSalesCount.Font = new Font("Calisto MT", 16.2F);
            mSalesCount.ForeColor = Color.White;
            mSalesCount.Location = new Point(131, 66);
            mSalesCount.Name = "mSalesCount";
            mSalesCount.Size = new Size(28, 32);
            mSalesCount.TabIndex = 2;
            mSalesCount.Text = "0";
            // 
            // mSalesLbl
            // 
            mSalesLbl.AutoSize = true;
            mSalesLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            mSalesLbl.ForeColor = Color.White;
            mSalesLbl.Location = new Point(57, 12);
            mSalesLbl.Name = "mSalesLbl";
            mSalesLbl.Size = new Size(137, 24);
            mSalesLbl.TabIndex = 0;
            mSalesLbl.Text = "Monthly Sales";
            mSalesLbl.Click += label1_Click_1;
            // 
            // refundPanel
            // 
            refundPanel.BackColor = Color.Teal;
            refundPanel.BorderStyle = BorderStyle.FixedSingle;
            refundPanel.Controls.Add(refundIcon);
            refundPanel.Controls.Add(refundCount);
            refundPanel.Controls.Add(refundLbl);
            refundPanel.Location = new Point(1093, 64);
            refundPanel.Name = "refundPanel";
            refundPanel.Size = new Size(249, 153);
            refundPanel.TabIndex = 2;
            // 
            // refundIcon
            // 
            refundIcon.Image = Properties.Resources.refund;
            refundIcon.Location = new Point(3, 56);
            refundIcon.Name = "refundIcon";
            refundIcon.Size = new Size(74, 62);
            refundIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            refundIcon.TabIndex = 2;
            refundIcon.TabStop = false;
            // 
            // refundCount
            // 
            refundCount.AutoSize = true;
            refundCount.Font = new Font("Calisto MT", 16.2F);
            refundCount.ForeColor = Color.White;
            refundCount.Location = new Point(129, 66);
            refundCount.Name = "refundCount";
            refundCount.Size = new Size(28, 32);
            refundCount.TabIndex = 1;
            refundCount.Text = "0";
            // 
            // refundLbl
            // 
            refundLbl.AutoSize = true;
            refundLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            refundLbl.ForeColor = Color.White;
            refundLbl.Location = new Point(98, 12);
            refundLbl.Name = "refundLbl";
            refundLbl.Size = new Size(73, 24);
            refundLbl.TabIndex = 0;
            refundLbl.Text = "Refund";
            // 
            // tSalesPanel
            // 
            tSalesPanel.BackColor = Color.Teal;
            tSalesPanel.BorderStyle = BorderStyle.FixedSingle;
            tSalesPanel.Controls.Add(tSaleIcon);
            tSalesPanel.Controls.Add(tSalesCount);
            tSalesPanel.Controls.Add(tSalesLbl);
            tSalesPanel.Location = new Point(592, 64);
            tSalesPanel.Name = "tSalesPanel";
            tSalesPanel.Size = new Size(240, 153);
            tSalesPanel.TabIndex = 1;
            // 
            // tSaleIcon
            // 
            tSaleIcon.Image = Properties.Resources.realTsales;
            tSaleIcon.Location = new Point(12, 56);
            tSaleIcon.Name = "tSaleIcon";
            tSaleIcon.Size = new Size(74, 62);
            tSaleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            tSaleIcon.TabIndex = 4;
            tSaleIcon.TabStop = false;
            // 
            // tSalesCount
            // 
            tSalesCount.AutoSize = true;
            tSalesCount.Font = new Font("Calisto MT", 16.2F);
            tSalesCount.ForeColor = Color.White;
            tSalesCount.Location = new Point(119, 66);
            tSalesCount.Name = "tSalesCount";
            tSalesCount.Size = new Size(28, 32);
            tSalesCount.TabIndex = 3;
            tSalesCount.Text = "0";
            // 
            // tSalesLbl
            // 
            tSalesLbl.AutoSize = true;
            tSalesLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            tSalesLbl.ForeColor = Color.White;
            tSalesLbl.Location = new Point(51, 12);
            tSalesLbl.Name = "tSalesLbl";
            tSalesLbl.Size = new Size(131, 24);
            tSalesLbl.TabIndex = 1;
            tSalesLbl.Text = "Today's Sales";
            // 
            // tOrderPanel
            // 
            tOrderPanel.BackColor = Color.Teal;
            tOrderPanel.BorderStyle = BorderStyle.Fixed3D;
            tOrderPanel.Controls.Add(tOrderIcon);
            tOrderPanel.Controls.Add(tOrderCount);
            tOrderPanel.Controls.Add(tOrderLbl);
            tOrderPanel.Location = new Point(346, 64);
            tOrderPanel.Name = "tOrderPanel";
            tOrderPanel.Size = new Size(240, 153);
            tOrderPanel.TabIndex = 0;
            tOrderPanel.Paint += tOrderPanel_Paint;
            // 
            // tOrderIcon
            // 
            tOrderIcon.Image = Properties.Resources.rilTsale;
            tOrderIcon.Location = new Point(12, 55);
            tOrderIcon.Name = "tOrderIcon";
            tOrderIcon.Size = new Size(74, 62);
            tOrderIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            tOrderIcon.TabIndex = 3;
            tOrderIcon.TabStop = false;
            // 
            // tOrderCount
            // 
            tOrderCount.AutoSize = true;
            tOrderCount.Font = new Font("Calisto MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tOrderCount.ForeColor = Color.White;
            tOrderCount.Location = new Point(127, 65);
            tOrderCount.Name = "tOrderCount";
            tOrderCount.Size = new Size(28, 32);
            tOrderCount.TabIndex = 2;
            tOrderCount.Text = "0";
            tOrderCount.Click += label1_Click_2;
            // 
            // tOrderLbl
            // 
            tOrderLbl.AutoSize = true;
            tOrderLbl.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tOrderLbl.ForeColor = Color.White;
            tOrderLbl.Location = new Point(58, 11);
            tOrderLbl.Name = "tOrderLbl";
            tOrderLbl.Size = new Size(134, 24);
            tOrderLbl.TabIndex = 1;
            tOrderLbl.Text = "Today's Order";
            tOrderLbl.Click += tOrderLbl_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.Teal;
            sidebarPanel.Controls.Add(logoutBtn);
            sidebarPanel.Controls.Add(inventoryBtn);
            sidebarPanel.Controls.Add(employeeBtn);
            sidebarPanel.Controls.Add(reportsBtn);
            sidebarPanel.Controls.Add(salesTerminalBtn);
            sidebarPanel.Controls.Add(dashboardBtn);
            sidebarPanel.Controls.Add(dashSidebarLbl);
            sidebarPanel.Location = new Point(1, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(318, 742);
            sidebarPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.FromArgb(235, 226, 216);
            logoutBtn.Location = new Point(11, 468);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(295, 46);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // inventoryBtn
            // 
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryBtn.ForeColor = Color.FromArgb(235, 226, 216);
            inventoryBtn.Location = new Point(11, 312);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new Size(295, 46);
            inventoryBtn.TabIndex = 5;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += button5_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeBtn.ForeColor = Color.FromArgb(235, 226, 216);
            employeeBtn.Location = new Point(11, 416);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(295, 46);
            employeeBtn.TabIndex = 4;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = true;
            // 
            // reportsBtn
            // 
            reportsBtn.FlatStyle = FlatStyle.Flat;
            reportsBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportsBtn.ForeColor = Color.FromArgb(235, 226, 216);
            reportsBtn.Location = new Point(11, 364);
            reportsBtn.Name = "reportsBtn";
            reportsBtn.Size = new Size(295, 46);
            reportsBtn.TabIndex = 3;
            reportsBtn.Text = "Reports";
            reportsBtn.UseVisualStyleBackColor = true;
            // 
            // salesTerminalBtn
            // 
            salesTerminalBtn.FlatStyle = FlatStyle.Flat;
            salesTerminalBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesTerminalBtn.ForeColor = Color.FromArgb(235, 226, 216);
            salesTerminalBtn.Location = new Point(11, 260);
            salesTerminalBtn.Name = "salesTerminalBtn";
            salesTerminalBtn.Size = new Size(295, 46);
            salesTerminalBtn.TabIndex = 2;
            salesTerminalBtn.Text = "Sales Terminal";
            salesTerminalBtn.UseVisualStyleBackColor = true;
            salesTerminalBtn.Click += salesTerminalBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.White;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.Teal;
            dashboardBtn.Location = new Point(11, 208);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(295, 46);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "DASHBOARD";
            dashboardBtn.UseVisualStyleBackColor = false;
            // 
            // dashSidebarLbl
            // 
            dashSidebarLbl.AutoSize = true;
            dashSidebarLbl.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashSidebarLbl.ForeColor = Color.White;
            dashSidebarLbl.Location = new Point(40, 64);
            dashSidebarLbl.Name = "dashSidebarLbl";
            dashSidebarLbl.Size = new Size(233, 70);
            dashSidebarLbl.TabIndex = 0;
            dashSidebarLbl.Text = "DASHBOARD\r\nPAGE\r\n";
            dashSidebarLbl.Click += label1_Click;
            // 
            // tOrderChartLbl
            // 
            tOrderChartLbl.AutoSize = true;
            tOrderChartLbl.BackColor = Color.Teal;
            tOrderChartLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            tOrderChartLbl.ForeColor = Color.White;
            tOrderChartLbl.Location = new Point(13, 8);
            tOrderChartLbl.Name = "tOrderChartLbl";
            tOrderChartLbl.Size = new Size(218, 24);
            tOrderChartLbl.TabIndex = 5;
            tOrderChartLbl.Text = "TODAY's ORDER CHART";
            tOrderChartLbl.Click += label1_Click_3;
            // 
            // tSalesChartPanel
            // 
            tSalesChartPanel.BackColor = Color.Teal;
            tSalesChartPanel.Controls.Add(label1);
            tSalesChartPanel.Controls.Add(tSalesChart);
            tSalesChartPanel.Location = new Point(605, 236);
            tSalesChartPanel.Name = "tSalesChartPanel";
            tSalesChartPanel.Size = new Size(737, 242);
            tSalesChartPanel.TabIndex = 7;
            // 
            // tSalesChart
            // 
            tSalesChart.BackColor = Color.PaleTurquoise;
            tSalesChart.Location = new Point(21, 35);
            tSalesChart.Margin = new Padding(2);
            tSalesChart.MatchAxesScreenDataRatio = false;
            tSalesChart.Name = "tSalesChart";
            tSalesChart.Size = new Size(694, 192);
            tSalesChart.TabIndex = 4;
            tSalesChart.Load += cartesianChart1_Load;
            // 
            // tOrdChartPnl
            // 
            tOrdChartPnl.BackColor = Color.Teal;
            tOrdChartPnl.BorderStyle = BorderStyle.FixedSingle;
            tOrdChartPnl.Controls.Add(tOrderChartPie);
            tOrdChartPnl.Controls.Add(tOrderChartLbl);
            tOrdChartPnl.Location = new Point(346, 236);
            tOrdChartPnl.Name = "tOrdChartPnl";
            tOrdChartPnl.Size = new Size(240, 242);
            tOrdChartPnl.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 24);
            label1.TabIndex = 5;
            label1.Text = "TODAY's SALES";
            label1.Click += label1_Click_4;
            // 
            // tOrderChartPie
            // 
            tOrderChartPie.BackColor = Color.White;
            tOrderChartPie.InitialRotation = 0D;
            tOrderChartPie.IsClockwise = true;
            tOrderChartPie.Location = new Point(29, 55);
            tOrderChartPie.MaxAngle = 360D;
            tOrderChartPie.MaxValue = double.NaN;
            tOrderChartPie.MinValue = 0D;
            tOrderChartPie.Name = "tOrderChartPie";
            tOrderChartPie.Size = new Size(176, 161);
            tOrderChartPie.TabIndex = 0;
            // 
            // mSalesChartPnl
            // 
            mSalesChartPnl.BackColor = Color.Teal;
            mSalesChartPnl.Controls.Add(cartesianChart1);
            mSalesChartPnl.Controls.Add(mSaleChartLbl);
            mSalesChartPnl.Location = new Point(346, 497);
            mSalesChartPnl.Name = "mSalesChartPnl";
            mSalesChartPnl.Size = new Size(600, 223);
            mSalesChartPnl.TabIndex = 8;
            // 
            // mSaleChartLbl
            // 
            mSaleChartLbl.AutoSize = true;
            mSaleChartLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            mSaleChartLbl.ForeColor = Color.White;
            mSaleChartLbl.Location = new Point(14, 10);
            mSaleChartLbl.Name = "mSaleChartLbl";
            mSaleChartLbl.Size = new Size(163, 24);
            mSaleChartLbl.TabIndex = 0;
            mSaleChartLbl.Text = "MONTHLY SALES";
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.PaleTurquoise;
            cartesianChart1.Location = new Point(14, 46);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(574, 162);
            cartesianChart1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(cartesianChart2);
            panel1.Controls.Add(refundChartLbl);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(952, 497);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 223);
            panel1.TabIndex = 9;
            // 
            // refundChartLbl
            // 
            refundChartLbl.AutoSize = true;
            refundChartLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            refundChartLbl.Location = new Point(31, 9);
            refundChartLbl.Name = "refundChartLbl";
            refundChartLbl.Size = new Size(86, 24);
            refundChartLbl.TabIndex = 0;
            refundChartLbl.Text = "REFUND";
            // 
            // cartesianChart2
            // 
            cartesianChart2.BackColor = Color.PaleTurquoise;
            cartesianChart2.Location = new Point(18, 46);
            cartesianChart2.MatchAxesScreenDataRatio = false;
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(354, 162);
            cartesianChart2.TabIndex = 1;
            // 
            // DASHBOARD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 742);
            Controls.Add(sidebarPanel);
            Controls.Add(mainPanel);
            Name = "DASHBOARD";
            Text = "DASHBOARD";
            mainPanel.ResumeLayout(false);
            mSalesPanel.ResumeLayout(false);
            mSalesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mSaleIcon).EndInit();
            refundPanel.ResumeLayout(false);
            refundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)refundIcon).EndInit();
            tSalesPanel.ResumeLayout(false);
            tSalesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tSaleIcon).EndInit();
            tOrderPanel.ResumeLayout(false);
            tOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tOrderIcon).EndInit();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            tSalesChartPanel.ResumeLayout(false);
            tSalesChartPanel.PerformLayout();
            tOrdChartPnl.ResumeLayout(false);
            tOrdChartPnl.PerformLayout();
            mSalesChartPnl.ResumeLayout(false);
            mSalesChartPnl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel sidebarPanel;
        private Label dashSidebarLbl;
        private Button logoutBtn;
        private Button inventoryBtn;
        private Button employeeBtn;
        private Button reportsBtn;
        private Button salesTerminalBtn;
        private Button dashboardBtn;
        private Panel mSalesPanel;
        private Panel refundPanel;
        private Panel tSalesPanel;
        private Panel tOrderPanel;
        private Label tOrderLbl;
        private Label refundLbl;
        private Label tSalesLbl;
        private Label mSalesLbl;
        private Label tOrderCount;
        private Label tSalesCount;
        private Label refundCount;
        private Label mSalesCount;
        private PictureBox tOrderIcon;
        private PictureBox tSaleIcon;
        private PictureBox mSaleIcon;
        private PictureBox refundIcon;
        private Label tOrderChartLbl;
        private Panel tSalesChartPanel;
        private Panel tOrdChartPnl;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart tSalesChart;
        private Label label1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart tOrderChartPie;
        private Panel panel1;
        private Panel mSalesChartPnl;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label mSaleChartLbl;
        private Label refundChartLbl;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
    }
}
