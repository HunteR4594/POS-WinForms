using System;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace POS_project
{
    partial class CA_Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CA_Dashboard));
            kpiPanel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label10 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tOrdersLbl = new Label();
            pictureBox1 = new PictureBox();
            kpiPanel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            tSalesLbl = new Label();
            kpiPanel3 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label8 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            mSalesLbl = new Label();
            kpiPanel4 = new Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            totalDiscLbl = new Label();
            label3 = new Label();
            pieChartPanel = new Panel();
            pieChartComboBox = new ComboBox();
            label2 = new Label();
            pieChart1 = new PieChart();
            salesChartPanel = new Panel();
            salesChartComboBox = new ComboBox();
            tSalesChartTitleLbl = new Label();
            cartesianChart3 = new CartesianChart();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            kpiPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            kpiPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            kpiPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            kpiPanel4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            pieChartPanel.SuspendLayout();
            salesChartPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // kpiPanel1
            // 
            kpiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel1.BackColor = Color.Teal;
            kpiPanel1.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel1.Controls.Add(tableLayoutPanel5);
            kpiPanel1.Location = new Point(3, 3);
            kpiPanel1.Name = "kpiPanel1";
            kpiPanel1.Size = new Size(256, 161);
            kpiPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label10, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel5.Size = new Size(254, 159);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Bahnschrift SemiLight", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(248, 55);
            label10.TabIndex = 1;
            label10.Text = "TOP 5 SELLING PRODUCTS";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel6.Controls.Add(tOrdersLbl, 1, 0);
            tableLayoutPanel6.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel6.Location = new Point(3, 58);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(248, 98);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tOrdersLbl
            // 
            tOrdersLbl.AutoSize = true;
            tOrdersLbl.Dock = DockStyle.Fill;
            tOrdersLbl.Font = new Font("Microsoft Sans Serif", 16.2F);
            tOrdersLbl.ForeColor = Color.White;
            tOrdersLbl.Location = new Point(102, 0);
            tOrdersLbl.Name = "tOrdersLbl";
            tOrdersLbl.Size = new Size(143, 98);
            tOrdersLbl.TabIndex = 2;
            tOrdersLbl.Text = "0";
            tOrdersLbl.TextAlign = ContentAlignment.MiddleCenter;
            tOrdersLbl.Click += tOrdersLbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // kpiPanel2
            // 
            kpiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel2.BackColor = Color.Teal;
            kpiPanel2.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel2.Controls.Add(tableLayoutPanel3);
            kpiPanel2.Location = new Point(265, 3);
            kpiPanel2.Name = "kpiPanel2";
            kpiPanel2.Size = new Size(256, 161);
            kpiPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Size = new Size(254, 159);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiLight", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(248, 55);
            label6.TabIndex = 1;
            label6.Text = "Today's Sales";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel4.Controls.Add(tSalesLbl, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 58);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(248, 98);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // tSalesLbl
            // 
            tSalesLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tSalesLbl.AutoSize = true;
            tSalesLbl.Font = new Font("Microsoft Sans Serif", 16.2F);
            tSalesLbl.ForeColor = Color.White;
            tSalesLbl.Location = new Point(102, 0);
            tSalesLbl.Name = "tSalesLbl";
            tSalesLbl.Size = new Size(143, 98);
            tSalesLbl.TabIndex = 2;
            tSalesLbl.Text = "0.00";
            tSalesLbl.TextAlign = ContentAlignment.MiddleCenter;
            tSalesLbl.Click += tSalesLbl_Click;
            // 
            // kpiPanel3
            // 
            kpiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel3.BackColor = Color.Teal;
            kpiPanel3.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel3.Controls.Add(tableLayoutPanel7);
            kpiPanel3.Location = new Point(527, 3);
            kpiPanel3.Name = "kpiPanel3";
            kpiPanel3.Size = new Size(256, 161);
            kpiPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel7.Size = new Size(254, 159);
            tableLayoutPanel7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Bahnschrift SemiLight", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(248, 55);
            label8.TabIndex = 1;
            label8.Text = "Monthly Sales Trend";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel8.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel8.Controls.Add(mSalesLbl, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 58);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(248, 98);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // mSalesLbl
            // 
            mSalesLbl.AutoSize = true;
            mSalesLbl.Dock = DockStyle.Fill;
            mSalesLbl.Font = new Font("Microsoft Sans Serif", 16.2F);
            mSalesLbl.ForeColor = Color.White;
            mSalesLbl.Location = new Point(102, 0);
            mSalesLbl.Name = "mSalesLbl";
            mSalesLbl.Size = new Size(143, 98);
            mSalesLbl.TabIndex = 2;
            mSalesLbl.Text = "0.00";
            mSalesLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kpiPanel4
            // 
            kpiPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel4.BackColor = Color.Teal;
            kpiPanel4.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel4.Controls.Add(tableLayoutPanel9);
            kpiPanel4.Location = new Point(789, 3);
            kpiPanel4.Name = "kpiPanel4";
            kpiPanel4.Size = new Size(259, 161);
            kpiPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel9.Controls.Add(label3, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel9.Size = new Size(257, 159);
            tableLayoutPanel9.TabIndex = 11;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel10.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel10.Controls.Add(totalDiscLbl, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 58);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(251, 98);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // totalDiscLbl
            // 
            totalDiscLbl.AutoSize = true;
            totalDiscLbl.Dock = DockStyle.Fill;
            totalDiscLbl.Font = new Font("Microsoft Sans Serif", 16.2F);
            totalDiscLbl.ForeColor = Color.White;
            totalDiscLbl.Location = new Point(103, 0);
            totalDiscLbl.Name = "totalDiscLbl";
            totalDiscLbl.Size = new Size(145, 98);
            totalDiscLbl.TabIndex = 1;
            totalDiscLbl.Text = "0";
            totalDiscLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bahnschrift SemiLight", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(251, 55);
            label3.TabIndex = 0;
            label3.Text = "DISCOUNTED ITEMS TODAY";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pieChartPanel
            // 
            pieChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pieChartPanel.BackColor = Color.White;
            pieChartPanel.BorderStyle = BorderStyle.FixedSingle;
            pieChartPanel.Controls.Add(pieChartComboBox);
            pieChartPanel.Controls.Add(label2);
            pieChartPanel.Controls.Add(pieChart1);
            pieChartPanel.Location = new Point(18, 18);
            pieChartPanel.Name = "pieChartPanel";
            pieChartPanel.Size = new Size(478, 466);
            pieChartPanel.TabIndex = 5;
            // 
            // pieChartComboBox
            // 
            pieChartComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pieChartComboBox.Font = new Font("Segoe UI", 10.2F);
            pieChartComboBox.FormattingEnabled = true;
            pieChartComboBox.Items.AddRange(new object[] { "Top 5 Selling Products by Revenue", "Sales by Category" });
            pieChartComboBox.Location = new Point(14, 40);
            pieChartComboBox.Name = "pieChartComboBox";
            pieChartComboBox.Size = new Size(313, 31);
            pieChartComboBox.TabIndex = 9;
            pieChartComboBox.SelectedIndexChanged += pieChartComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 12F);
            label2.Location = new Point(10, 11);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 1;
            label2.Text = "PIE CHART";
            // 
            // pieChart1
            // 
            pieChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(13, 96);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(450, 346);
            pieChart1.TabIndex = 8;
            pieChart1.Total = null;
            // 
            // salesChartPanel
            // 
            salesChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salesChartPanel.BackColor = Color.White;
            salesChartPanel.BorderStyle = BorderStyle.FixedSingle;
            salesChartPanel.Controls.Add(salesChartComboBox);
            salesChartPanel.Controls.Add(tSalesChartTitleLbl);
            salesChartPanel.Controls.Add(cartesianChart3);
            salesChartPanel.Location = new Point(502, 18);
            salesChartPanel.Name = "salesChartPanel";
            salesChartPanel.Size = new Size(479, 466);
            salesChartPanel.TabIndex = 6;
            // 
            // salesChartComboBox
            // 
            salesChartComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            salesChartComboBox.Font = new Font("Segoe UI", 10.2F);
            salesChartComboBox.FormattingEnabled = true;
            salesChartComboBox.Items.AddRange(new object[] { "Daily Sales", "Monthly Sales", "Yearly Sales" });
            salesChartComboBox.Location = new Point(14, 40);
            salesChartComboBox.Name = "salesChartComboBox";
            salesChartComboBox.Size = new Size(313, 31);
            salesChartComboBox.TabIndex = 10;
            salesChartComboBox.SelectedIndexChanged += salesChartComboBox_SelectedIndexChanged;
            // 
            // tSalesChartTitleLbl
            // 
            tSalesChartTitleLbl.AutoSize = true;
            tSalesChartTitleLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            tSalesChartTitleLbl.Location = new Point(10, 11);
            tSalesChartTitleLbl.Name = "tSalesChartTitleLbl";
            tSalesChartTitleLbl.Size = new Size(137, 24);
            tSalesChartTitleLbl.TabIndex = 2;
            tSalesChartTitleLbl.Text = "SALES CHART";
            // 
            // cartesianChart3
            // 
            cartesianChart3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart3.Location = new Point(10, 96);
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(446, 346);
            cartesianChart3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(kpiPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(kpiPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(kpiPanel4, 3, 0);
            tableLayoutPanel1.Controls.Add(kpiPanel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1051, 167);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.Azure;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(salesChartPanel, 1, 0);
            tableLayoutPanel2.Controls.Add(pieChartPanel, 0, 0);
            tableLayoutPanel2.Location = new Point(19, 20);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(15);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(999, 502);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(11, 182);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1046, 553);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // CA_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "CA_Dashboard";
            Padding = new Padding(10);
            Size = new Size(1071, 748);
            Load += CA_Dashboard_Load;
            kpiPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            kpiPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            kpiPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            kpiPanel4.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            pieChartPanel.ResumeLayout(false);
            pieChartPanel.PerformLayout();
            salesChartPanel.ResumeLayout(false);
            salesChartPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel kpiPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel kpiPanel2;
        private System.Windows.Forms.Label tSalesLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel kpiPanel3;
        private System.Windows.Forms.Label mSalesLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel kpiPanel4;
        private System.Windows.Forms.Label totalDiscLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pieChartPanel;
        private System.Windows.Forms.Label label2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Panel salesChartPanel;
        private System.Windows.Forms.Label tSalesChartTitleLbl;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart3;
        private System.Windows.Forms.ComboBox pieChartComboBox;
        private System.Windows.Forms.ComboBox salesChartComboBox;
        private Label tOrdersLbl;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
