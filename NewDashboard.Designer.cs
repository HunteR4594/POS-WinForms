namespace POS_project
{
    partial class NewDashboard
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
            salesChartComboBox = new ComboBox();
            cartesianChart3 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            salesChartPanel = new Panel();
            tSalesChartTitleLbl = new Label();
            pieChartComboBox = new ComboBox();
            label2 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            pieChartPanel = new Panel();
            totalDiscLbl = new Label();
            label3 = new Label();
            kpiPanel4 = new Panel();
            mSalesLbl = new Label();
            label8 = new Label();
            kpiPanel3 = new Panel();
            tSalesLbl = new Label();
            label6 = new Label();
            kpiPanel2 = new Panel();
            tOrdersLbl = new Label();
            label10 = new Label();
            kpiPanel1 = new Panel();
            salesChartPanel.SuspendLayout();
            pieChartPanel.SuspendLayout();
            kpiPanel4.SuspendLayout();
            kpiPanel3.SuspendLayout();
            kpiPanel2.SuspendLayout();
            kpiPanel1.SuspendLayout();
            SuspendLayout();
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
            // 
            // cartesianChart3
            // 
            cartesianChart3.Location = new Point(16, 64);
            cartesianChart3.Margin = new Padding(3, 2, 3, 2);
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(505, 387);
            cartesianChart3.TabIndex = 9;
            // 
            // salesChartPanel
            // 
            salesChartPanel.BorderStyle = BorderStyle.FixedSingle;
            salesChartPanel.Controls.Add(salesChartComboBox);
            salesChartPanel.Controls.Add(tSalesChartTitleLbl);
            salesChartPanel.Controls.Add(cartesianChart3);
            salesChartPanel.Location = new Point(522, 191);
            salesChartPanel.Margin = new Padding(3, 2, 3, 2);
            salesChartPanel.Name = "salesChartPanel";
            salesChartPanel.Size = new Size(538, 477);
            salesChartPanel.TabIndex = 12;
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
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(11, 64);
            pieChart1.Margin = new Padding(3, 2, 3, 2);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(458, 387);
            pieChart1.TabIndex = 8;
            pieChart1.Total = null;
            // 
            // pieChartPanel
            // 
            pieChartPanel.BorderStyle = BorderStyle.FixedSingle;
            pieChartPanel.Controls.Add(pieChartComboBox);
            pieChartPanel.Controls.Add(label2);
            pieChartPanel.Controls.Add(pieChart1);
            pieChartPanel.Location = new Point(23, 191);
            pieChartPanel.Margin = new Padding(3, 2, 3, 2);
            pieChartPanel.Name = "pieChartPanel";
            pieChartPanel.Size = new Size(481, 477);
            pieChartPanel.TabIndex = 11;
            // 
            // totalDiscLbl
            // 
            totalDiscLbl.AutoSize = true;
            totalDiscLbl.Font = new Font("Calisto MT", 16.2F);
            totalDiscLbl.ForeColor = Color.White;
            totalDiscLbl.Location = new Point(113, 50);
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
            label3.Location = new Point(18, 9);
            label3.Name = "label3";
            label3.Size = new Size(204, 19);
            label3.TabIndex = 0;
            label3.Text = "DISCOUNTED ITEMS TODAY";
            // 
            // kpiPanel4
            // 
            kpiPanel4.BackColor = Color.Teal;
            kpiPanel4.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel4.Controls.Add(totalDiscLbl);
            kpiPanel4.Controls.Add(label3);
            kpiPanel4.Location = new Point(379, 150);
            kpiPanel4.Margin = new Padding(3, 2, 3, 2);
            kpiPanel4.Name = "kpiPanel4";
            kpiPanel4.Size = new Size(244, 115);
            kpiPanel4.TabIndex = 10;
            // 
            // mSalesLbl
            // 
            mSalesLbl.AutoSize = true;
            mSalesLbl.Font = new Font("Calisto MT", 16.2F);
            mSalesLbl.ForeColor = Color.White;
            mSalesLbl.Location = new Point(115, 50);
            mSalesLbl.Name = "mSalesLbl";
            mSalesLbl.Size = new Size(51, 25);
            mSalesLbl.TabIndex = 2;
            mSalesLbl.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiLight", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(33, 9);
            label8.Name = "label8";
            label8.Size = new Size(185, 19);
            label8.TabIndex = 1;
            label8.Text = "MONTHLY SALES TREND";
            // 
            // kpiPanel3
            // 
            kpiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kpiPanel3.BackColor = Color.Teal;
            kpiPanel3.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel3.Controls.Add(mSalesLbl);
            kpiPanel3.Controls.Add(label8);
            kpiPanel3.Location = new Point(59, 150);
            kpiPanel3.Margin = new Padding(3, 2, 3, 2);
            kpiPanel3.Name = "kpiPanel3";
            kpiPanel3.Size = new Size(244, 115);
            kpiPanel3.TabIndex = 9;
            // 
            // tSalesLbl
            // 
            tSalesLbl.AutoSize = true;
            tSalesLbl.Font = new Font("Calisto MT", 16.2F);
            tSalesLbl.ForeColor = Color.White;
            tSalesLbl.Location = new Point(104, 50);
            tSalesLbl.Name = "tSalesLbl";
            tSalesLbl.Size = new Size(51, 25);
            tSalesLbl.TabIndex = 2;
            tSalesLbl.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiLight", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(67, 9);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 1;
            label6.Text = "Today's Sales";
            // 
            // kpiPanel2
            // 
            kpiPanel2.BackColor = Color.Teal;
            kpiPanel2.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel2.Controls.Add(tSalesLbl);
            kpiPanel2.Controls.Add(label6);
            kpiPanel2.Location = new Point(290, 31);
            kpiPanel2.Margin = new Padding(3, 2, 3, 2);
            kpiPanel2.Name = "kpiPanel2";
            kpiPanel2.Size = new Size(244, 115);
            kpiPanel2.TabIndex = 8;
            // 
            // tOrdersLbl
            // 
            tOrdersLbl.AutoSize = true;
            tOrdersLbl.Font = new Font("Calisto MT", 16.2F);
            tOrdersLbl.ForeColor = Color.White;
            tOrdersLbl.Location = new Point(104, 50);
            tOrdersLbl.Name = "tOrdersLbl";
            tOrdersLbl.Size = new Size(23, 25);
            tOrdersLbl.TabIndex = 2;
            tOrdersLbl.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiLight", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(21, 9);
            label10.Name = "label10";
            label10.Size = new Size(200, 19);
            label10.TabIndex = 1;
            label10.Text = "TOP 5 SELLING PRODUCTS";
            // 
            // kpiPanel1
            // 
            kpiPanel1.BackColor = Color.Teal;
            kpiPanel1.BorderStyle = BorderStyle.FixedSingle;
            kpiPanel1.Controls.Add(tOrdersLbl);
            kpiPanel1.Controls.Add(label10);
            kpiPanel1.Location = new Point(23, 31);
            kpiPanel1.Margin = new Padding(3, 2, 3, 2);
            kpiPanel1.Name = "kpiPanel1";
            kpiPanel1.Size = new Size(244, 115);
            kpiPanel1.TabIndex = 7;
            // 
            // NewDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(salesChartPanel);
            Controls.Add(pieChartPanel);
            Controls.Add(kpiPanel4);
            Controls.Add(kpiPanel3);
            Controls.Add(kpiPanel2);
            Controls.Add(kpiPanel1);
            Name = "NewDashboard";
            Size = new Size(1072, 785);
            salesChartPanel.ResumeLayout(false);
            salesChartPanel.PerformLayout();
            pieChartPanel.ResumeLayout(false);
            pieChartPanel.PerformLayout();
            kpiPanel4.ResumeLayout(false);
            kpiPanel4.PerformLayout();
            kpiPanel3.ResumeLayout(false);
            kpiPanel3.PerformLayout();
            kpiPanel2.ResumeLayout(false);
            kpiPanel2.PerformLayout();
            kpiPanel1.ResumeLayout(false);
            kpiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox salesChartComboBox;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart3;
        private Panel salesChartPanel;
        private Label tSalesChartTitleLbl;
        private ComboBox pieChartComboBox;
        private Label label2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Panel pieChartPanel;
        private Label totalDiscLbl;
        private Label label3;
        private Panel kpiPanel4;
        private Label mSalesLbl;
        private Label label8;
        private Panel kpiPanel3;
        private Label tSalesLbl;
        private Label label6;
        private Panel kpiPanel2;
        private Label tOrdersLbl;
        private Label label10;
        private Panel kpiPanel1;
    }
}
