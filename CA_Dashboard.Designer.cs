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
            pictureBox1 = new PictureBox();
            tOrdersLbl = new Label();
            label10 = new Label();
            kpiPanel2 = new Panel();
            tSalesLbl = new Label();
            label6 = new Label();
            kpiPanel3 = new Panel();
            mSalesLbl = new Label();
            label8 = new Label();
            kpiPanel4 = new Panel();
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
            kpiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            kpiPanel2.SuspendLayout();
            kpiPanel3.SuspendLayout();
            kpiPanel4.SuspendLayout();
            pieChartPanel.SuspendLayout();
            salesChartPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // kpiPanel1
            // 
            kpiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel1.BackColor = Color.Teal;
            kpiPanel1.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel1.Controls.Add(pictureBox1);
            kpiPanel1.Controls.Add(tOrdersLbl);
            kpiPanel1.Controls.Add(label10);
            kpiPanel1.Location = new Point(3, 2);
            kpiPanel1.Margin = new Padding(3, 2, 3, 2);
            kpiPanel1.Name = "kpiPanel1";
            kpiPanel1.Size = new Size(223, 121);
            kpiPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tOrdersLbl
            // 
            tOrdersLbl.AutoSize = true;
            tOrdersLbl.Font = new Font("Calisto MT", 16.2F);
            tOrdersLbl.ForeColor = Color.White;
            tOrdersLbl.Location = new Point(84, 50);
            tOrdersLbl.Name = "tOrdersLbl";
            tOrdersLbl.Size = new Size(23, 25);
            tOrdersLbl.TabIndex = 2;
            tOrdersLbl.Text = "0";
            tOrdersLbl.TextAlign = ContentAlignment.MiddleCenter;
            tOrdersLbl.Click += tOrdersLbl_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiLight", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(5, 9);
            label10.Name = "label10";
            label10.Size = new Size(200, 19);
            label10.TabIndex = 1;
            label10.Text = "TOP 5 SELLING PRODUCTS";
            // 
            // kpiPanel2
            // 
            kpiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel2.BackColor = Color.Teal;
            kpiPanel2.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel2.Controls.Add(tSalesLbl);
            kpiPanel2.Controls.Add(label6);
            kpiPanel2.Location = new Point(232, 2);
            kpiPanel2.Margin = new Padding(3, 2, 3, 2);
            kpiPanel2.Name = "kpiPanel2";
            kpiPanel2.Size = new Size(223, 121);
            kpiPanel2.TabIndex = 1;
            // 
            // tSalesLbl
            // 
            tSalesLbl.AutoSize = true;
            tSalesLbl.Font = new Font("Calisto MT", 16.2F);
            tSalesLbl.ForeColor = Color.White;
            tSalesLbl.Location = new Point(81, 50);
            tSalesLbl.Name = "tSalesLbl";
            tSalesLbl.Size = new Size(51, 25);
            tSalesLbl.TabIndex = 2;
            tSalesLbl.Text = "0.00";
            tSalesLbl.TextAlign = ContentAlignment.MiddleCenter;
            tSalesLbl.Click += tSalesLbl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiLight", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 9);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 1;
            label6.Text = "Today's Sales";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // kpiPanel3
            // 
            kpiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel3.BackColor = Color.Teal;
            kpiPanel3.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel3.Controls.Add(mSalesLbl);
            kpiPanel3.Controls.Add(label8);
            kpiPanel3.Location = new Point(461, 2);
            kpiPanel3.Margin = new Padding(3, 2, 3, 2);
            kpiPanel3.Name = "kpiPanel3";
            kpiPanel3.Size = new Size(223, 121);
            kpiPanel3.TabIndex = 3;
            // 
            // mSalesLbl
            // 
            mSalesLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mSalesLbl.AutoSize = true;
            mSalesLbl.Font = new Font("Calisto MT", 16.2F);
            mSalesLbl.ForeColor = Color.White;
            mSalesLbl.Location = new Point(83, 50);
            mSalesLbl.Name = "mSalesLbl";
            mSalesLbl.Size = new Size(51, 25);
            mSalesLbl.TabIndex = 2;
            mSalesLbl.Text = "0.00";
            mSalesLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiLight", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 9);
            label8.Name = "label8";
            label8.Size = new Size(185, 19);
            label8.TabIndex = 1;
            label8.Text = "MONTHLY SALES TREND";
            // 
            // kpiPanel4
            // 
            kpiPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel4.BackColor = Color.Teal;
            kpiPanel4.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel4.Controls.Add(totalDiscLbl);
            kpiPanel4.Controls.Add(label3);
            kpiPanel4.Location = new Point(690, 2);
            kpiPanel4.Margin = new Padding(3, 2, 3, 2);
            kpiPanel4.Name = "kpiPanel4";
            kpiPanel4.Size = new Size(224, 121);
            kpiPanel4.TabIndex = 4;
            // 
            // totalDiscLbl
            // 
            totalDiscLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalDiscLbl.AutoSize = true;
            totalDiscLbl.Font = new Font("Calisto MT", 16.2F);
            totalDiscLbl.ForeColor = Color.White;
            totalDiscLbl.Location = new Point(95, 50);
            totalDiscLbl.Name = "totalDiscLbl";
            totalDiscLbl.Size = new Size(23, 25);
            totalDiscLbl.TabIndex = 1;
            totalDiscLbl.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(204, 19);
            label3.TabIndex = 0;
            label3.Text = "DISCOUNTED ITEMS TODAY";
            // 
            // pieChartPanel
            // 
            pieChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pieChartPanel.BorderStyle = BorderStyle.FixedSingle;
            pieChartPanel.Controls.Add(pieChartComboBox);
            pieChartPanel.Controls.Add(label2);
            pieChartPanel.Controls.Add(pieChart1);
            pieChartPanel.Location = new Point(3, 2);
            pieChartPanel.Margin = new Padding(3, 2, 3, 2);
            pieChartPanel.Name = "pieChartPanel";
            pieChartPanel.Size = new Size(449, 334);
            pieChartPanel.TabIndex = 5;
            // 
            // pieChartComboBox
            // 
            pieChartComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pieChartComboBox.FormattingEnabled = true;
            pieChartComboBox.Items.AddRange(new object[] { "Top 5 Selling Products by Revenue", "Sales by Category" });
            pieChartComboBox.Location = new Point(12, 30);
            pieChartComboBox.Margin = new Padding(3, 2, 3, 2);
            pieChartComboBox.Name = "pieChartComboBox";
            pieChartComboBox.Size = new Size(228, 23);
            pieChartComboBox.TabIndex = 9;
            pieChartComboBox.SelectedIndexChanged += pieChartComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 12F);
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 1;
            label2.Text = "PIE CHART";
            // 
            // pieChart1
            // 
            pieChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(11, 64);
            pieChart1.Margin = new Padding(3, 2, 3, 2);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(424, 252);
            pieChart1.TabIndex = 8;
            pieChart1.Total = null;
            // 
            // salesChartPanel
            // 
            salesChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            salesChartPanel.BorderStyle = BorderStyle.FixedSingle;
            salesChartPanel.Controls.Add(salesChartComboBox);
            salesChartPanel.Controls.Add(tSalesChartTitleLbl);
            salesChartPanel.Controls.Add(cartesianChart3);
            salesChartPanel.Location = new Point(458, 2);
            salesChartPanel.Margin = new Padding(3, 2, 3, 2);
            salesChartPanel.Name = "salesChartPanel";
            salesChartPanel.Size = new Size(450, 334);
            salesChartPanel.TabIndex = 6;
            // 
            // salesChartComboBox
            // 
            salesChartComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            salesChartComboBox.FormattingEnabled = true;
            salesChartComboBox.Items.AddRange(new object[] { "Daily Sales", "Monthly Sales", "Yearly Sales" });
            salesChartComboBox.Location = new Point(12, 30);
            salesChartComboBox.Margin = new Padding(3, 2, 3, 2);
            salesChartComboBox.Name = "salesChartComboBox";
            salesChartComboBox.Size = new Size(228, 23);
            salesChartComboBox.TabIndex = 10;
            salesChartComboBox.SelectedIndexChanged += salesChartComboBox_SelectedIndexChanged;
            // 
            // tSalesChartTitleLbl
            // 
            tSalesChartTitleLbl.AutoSize = true;
            tSalesChartTitleLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            tSalesChartTitleLbl.Location = new Point(9, 8);
            tSalesChartTitleLbl.Name = "tSalesChartTitleLbl";
            tSalesChartTitleLbl.Size = new Size(111, 19);
            tSalesChartTitleLbl.TabIndex = 2;
            tSalesChartTitleLbl.Text = "SALES CHART";
            // 
            // cartesianChart3
            // 
            cartesianChart3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart3.Location = new Point(11, 64);
            cartesianChart3.Margin = new Padding(3, 2, 3, 2);
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(421, 252);
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
            tableLayoutPanel1.Controls.Add(kpiPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(kpiPanel4, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(917, 125);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(salesChartPanel, 1, 0);
            tableLayoutPanel2.Controls.Add(pieChartPanel, 0, 0);
            tableLayoutPanel2.Location = new Point(10, 153);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(911, 338);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // CA_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CA_Dashboard";
            Padding = new Padding(10);
            Size = new Size(937, 561);
            Load += CA_Dashboard_Load;
            kpiPanel1.ResumeLayout(false);
            kpiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            kpiPanel2.ResumeLayout(false);
            kpiPanel2.PerformLayout();
            kpiPanel3.ResumeLayout(false);
            kpiPanel3.PerformLayout();
            kpiPanel4.ResumeLayout(false);
            kpiPanel4.PerformLayout();
            pieChartPanel.ResumeLayout(false);
            pieChartPanel.PerformLayout();
            salesChartPanel.ResumeLayout(false);
            salesChartPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
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
    }
}
