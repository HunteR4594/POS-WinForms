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
            mainPanel = new Panel();
            panel1 = new Panel();
            cartesianChart2 = new CartesianChart();
            refundChartLbl = new Label();
            mSalesChartPnl = new Panel();
            cartesianChart1 = new CartesianChart();
            mSaleChartLbl = new Label();
            tSalesChartPanel = new Panel();
            label1 = new Label();
            tSalesChart = new CartesianChart();
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
            tOrdChartPnl = new Panel();
            tOrderChartPie = new PieChart();
            tOrderChartLbl = new Label();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            mSalesChartPnl.SuspendLayout();
            tSalesChartPanel.SuspendLayout();
            mSalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mSaleIcon).BeginInit();
            refundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refundIcon).BeginInit();
            tSalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tSaleIcon).BeginInit();
            tOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tOrderIcon).BeginInit();
            tOrdChartPnl.SuspendLayout();
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
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(963, 556);
            mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(cartesianChart2);
            panel1.Controls.Add(refundChartLbl);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(572, 354);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 167);
            panel1.TabIndex = 9;
            // 
            // cartesianChart2
            // 
            cartesianChart2.BackColor = Color.PaleTurquoise;
            cartesianChart2.Location = new Point(16, 34);
            cartesianChart2.Margin = new Padding(3, 2, 3, 2);
            cartesianChart2.MatchAxesScreenDataRatio = false;
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(310, 122);
            cartesianChart2.TabIndex = 1;
            // 
            // refundChartLbl
            // 
            refundChartLbl.AutoSize = true;
            refundChartLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            refundChartLbl.Location = new Point(27, 7);
            refundChartLbl.Name = "refundChartLbl";
            refundChartLbl.Size = new Size(70, 19);
            refundChartLbl.TabIndex = 0;
            refundChartLbl.Text = "REFUND";
            // 
            // mSalesChartPnl
            // 
            mSalesChartPnl.BackColor = Color.Teal;
            mSalesChartPnl.Controls.Add(cartesianChart1);
            mSalesChartPnl.Controls.Add(mSaleChartLbl);
            mSalesChartPnl.Location = new Point(26, 354);
            mSalesChartPnl.Margin = new Padding(3, 2, 3, 2);
            mSalesChartPnl.Name = "mSalesChartPnl";
            mSalesChartPnl.Size = new Size(525, 167);
            mSalesChartPnl.TabIndex = 8;
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.PaleTurquoise;
            cartesianChart1.Location = new Point(12, 34);
            cartesianChart1.Margin = new Padding(3, 2, 3, 2);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(502, 122);
            cartesianChart1.TabIndex = 1;
            // 
            // mSaleChartLbl
            // 
            mSaleChartLbl.AutoSize = true;
            mSaleChartLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            mSaleChartLbl.ForeColor = Color.White;
            mSaleChartLbl.Location = new Point(12, 8);
            mSaleChartLbl.Name = "mSaleChartLbl";
            mSaleChartLbl.Size = new Size(58, 19);
            mSaleChartLbl.TabIndex = 0;
            mSaleChartLbl.Text = "SALES";
            // 
            // tSalesChartPanel
            // 
            tSalesChartPanel.BackColor = Color.Teal;
            tSalesChartPanel.Controls.Add(label1);
            tSalesChartPanel.Controls.Add(tSalesChart);
            tSalesChartPanel.Location = new Point(267, 139);
            tSalesChartPanel.Margin = new Padding(3, 2, 3, 2);
            tSalesChartPanel.Name = "tSalesChartPanel";
            tSalesChartPanel.Size = new Size(645, 192);
            tSalesChartPanel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 5);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 5;
            label1.Text = "SALES";
            // 
            // tSalesChart
            // 
            tSalesChart.BackColor = Color.PaleTurquoise;
            tSalesChart.Location = new Point(18, 26);
            tSalesChart.Margin = new Padding(2);
            tSalesChart.MatchAxesScreenDataRatio = false;
            tSalesChart.Name = "tSalesChart";
            tSalesChart.Size = new Size(607, 156);
            tSalesChart.TabIndex = 4;
            // 
            // mSalesPanel
            // 
            mSalesPanel.BackColor = Color.Teal;
            mSalesPanel.BorderStyle = BorderStyle.FixedSingle;
            mSalesPanel.Controls.Add(mSaleIcon);
            mSalesPanel.Controls.Add(mSalesCount);
            mSalesPanel.Controls.Add(mSalesLbl);
            mSalesPanel.Location = new Point(470, 22);
            mSalesPanel.Margin = new Padding(3, 2, 3, 2);
            mSalesPanel.Name = "mSalesPanel";
            mSalesPanel.Size = new Size(218, 89);
            mSalesPanel.TabIndex = 3;
            // 
            // mSaleIcon
            // 
            mSaleIcon.Location = new Point(17, 38);
            mSaleIcon.Margin = new Padding(3, 2, 3, 2);
            mSaleIcon.Name = "mSaleIcon";
            mSaleIcon.Size = new Size(56, 37);
            mSaleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            mSaleIcon.TabIndex = 3;
            mSaleIcon.TabStop = false;
            // 
            // mSalesCount
            // 
            mSalesCount.AutoSize = true;
            mSalesCount.Font = new Font("Calisto MT", 16.2F);
            mSalesCount.ForeColor = Color.White;
            mSalesCount.Location = new Point(115, 42);
            mSalesCount.Name = "mSalesCount";
            mSalesCount.Size = new Size(23, 25);
            mSalesCount.TabIndex = 2;
            mSalesCount.Text = "0";
            // 
            // mSalesLbl
            // 
            mSalesLbl.AutoSize = true;
            mSalesLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            mSalesLbl.ForeColor = Color.White;
            mSalesLbl.Location = new Point(50, 9);
            mSalesLbl.Name = "mSalesLbl";
            mSalesLbl.Size = new Size(111, 19);
            mSalesLbl.TabIndex = 0;
            mSalesLbl.Text = "Monthly Sales";
            // 
            // refundPanel
            // 
            refundPanel.BackColor = Color.Teal;
            refundPanel.BorderStyle = BorderStyle.FixedSingle;
            refundPanel.Controls.Add(refundIcon);
            refundPanel.Controls.Add(refundCount);
            refundPanel.Controls.Add(refundLbl);
            refundPanel.Location = new Point(694, 22);
            refundPanel.Margin = new Padding(3, 2, 3, 2);
            refundPanel.Name = "refundPanel";
            refundPanel.Size = new Size(218, 89);
            refundPanel.TabIndex = 2;
            // 
            // refundIcon
            // 
            refundIcon.Location = new Point(12, 38);
            refundIcon.Margin = new Padding(3, 2, 3, 2);
            refundIcon.Name = "refundIcon";
            refundIcon.Size = new Size(56, 37);
            refundIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            refundIcon.TabIndex = 2;
            refundIcon.TabStop = false;
            // 
            // refundCount
            // 
            refundCount.AutoSize = true;
            refundCount.Font = new Font("Calisto MT", 16.2F);
            refundCount.ForeColor = Color.White;
            refundCount.Location = new Point(111, 42);
            refundCount.Name = "refundCount";
            refundCount.Size = new Size(23, 25);
            refundCount.TabIndex = 1;
            refundCount.Text = "0";
            // 
            // refundLbl
            // 
            refundLbl.AutoSize = true;
            refundLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            refundLbl.ForeColor = Color.White;
            refundLbl.Location = new Point(92, 9);
            refundLbl.Name = "refundLbl";
            refundLbl.Size = new Size(60, 19);
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
            tSalesPanel.Location = new Point(242, 22);
            tSalesPanel.Margin = new Padding(3, 2, 3, 2);
            tSalesPanel.Name = "tSalesPanel";
            tSalesPanel.Size = new Size(210, 89);
            tSalesPanel.TabIndex = 1;
            // 
            // tSaleIcon
            // 
            tSaleIcon.Location = new Point(25, 38);
            tSaleIcon.Margin = new Padding(3, 2, 3, 2);
            tSaleIcon.Name = "tSaleIcon";
            tSaleIcon.Size = new Size(61, 37);
            tSaleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            tSaleIcon.TabIndex = 4;
            tSaleIcon.TabStop = false;
            // 
            // tSalesCount
            // 
            tSalesCount.AutoSize = true;
            tSalesCount.Font = new Font("Calisto MT", 16.2F);
            tSalesCount.ForeColor = Color.White;
            tSalesCount.Location = new Point(104, 42);
            tSalesCount.Name = "tSalesCount";
            tSalesCount.Size = new Size(23, 25);
            tSalesCount.TabIndex = 3;
            tSalesCount.Text = "0";
            // 
            // tSalesLbl
            // 
            tSalesLbl.AutoSize = true;
            tSalesLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            tSalesLbl.ForeColor = Color.White;
            tSalesLbl.Location = new Point(45, 9);
            tSalesLbl.Name = "tSalesLbl";
            tSalesLbl.Size = new Size(107, 19);
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
            tOrderPanel.Location = new Point(26, 22);
            tOrderPanel.Margin = new Padding(3, 2, 3, 2);
            tOrderPanel.Name = "tOrderPanel";
            tOrderPanel.Size = new Size(210, 89);
            tOrderPanel.TabIndex = 0;
            // 
            // tOrderIcon
            // 
            tOrderIcon.Location = new Point(21, 37);
            tOrderIcon.Margin = new Padding(3, 2, 3, 2);
            tOrderIcon.Name = "tOrderIcon";
            tOrderIcon.Size = new Size(58, 37);
            tOrderIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            tOrderIcon.TabIndex = 3;
            tOrderIcon.TabStop = false;
            // 
            // tOrderCount
            // 
            tOrderCount.AutoSize = true;
            tOrderCount.Font = new Font("Calisto MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tOrderCount.ForeColor = Color.White;
            tOrderCount.Location = new Point(111, 41);
            tOrderCount.Name = "tOrderCount";
            tOrderCount.Size = new Size(23, 25);
            tOrderCount.TabIndex = 2;
            tOrderCount.Text = "0";
            // 
            // tOrderLbl
            // 
            tOrderLbl.AutoSize = true;
            tOrderLbl.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tOrderLbl.ForeColor = Color.White;
            tOrderLbl.Location = new Point(51, 8);
            tOrderLbl.Name = "tOrderLbl";
            tOrderLbl.Size = new Size(108, 19);
            tOrderLbl.TabIndex = 1;
            tOrderLbl.Text = "Today's Order";
            // 
            // tOrdChartPnl
            // 
            tOrdChartPnl.BackColor = Color.Teal;
            tOrdChartPnl.BorderStyle = BorderStyle.FixedSingle;
            tOrdChartPnl.Controls.Add(tOrderChartPie);
            tOrdChartPnl.Controls.Add(tOrderChartLbl);
            tOrdChartPnl.Location = new Point(26, 139);
            tOrdChartPnl.Margin = new Padding(3, 2, 3, 2);
            tOrdChartPnl.Name = "tOrdChartPnl";
            tOrdChartPnl.Size = new Size(210, 192);
            tOrdChartPnl.TabIndex = 6;
            // 
            // tOrderChartPie
            // 
            tOrderChartPie.BackColor = Color.White;
            tOrderChartPie.InitialRotation = 0D;
            tOrderChartPie.IsClockwise = true;
            tOrderChartPie.Location = new Point(16, 27);
            tOrderChartPie.Margin = new Padding(3, 2, 3, 2);
            tOrderChartPie.MaxAngle = 360D;
            tOrderChartPie.MaxValue = double.NaN;
            tOrderChartPie.MinValue = 0D;
            tOrderChartPie.Name = "tOrderChartPie";
            tOrderChartPie.Size = new Size(171, 142);
            tOrderChartPie.TabIndex = 0;
            // 
            // tOrderChartLbl
            // 
            tOrderChartLbl.AutoSize = true;
            tOrderChartLbl.BackColor = Color.Teal;
            tOrderChartLbl.Font = new Font("Bahnschrift SemiLight", 12F);
            tOrderChartLbl.ForeColor = Color.White;
            tOrderChartLbl.Location = new Point(11, 4);
            tOrderChartLbl.Name = "tOrderChartLbl";
            tOrderChartLbl.Size = new Size(144, 19);
            tOrderChartLbl.TabIndex = 5;
            tOrderChartLbl.Text = "INVENTORY CHART";
            // 
            // CA_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CA_Dashboard";
            Size = new Size(964, 556);
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mSalesChartPnl.ResumeLayout(false);
            mSalesChartPnl.PerformLayout();
            tSalesChartPanel.ResumeLayout(false);
            tSalesChartPanel.PerformLayout();
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
            tOrdChartPnl.ResumeLayout(false);
            tOrdChartPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel refundPanel;
        private Panel tSalesPanel;
        private Panel tOrderPanel;
        private Label tOrderLbl;
        private Label refundLbl;
        private Label tSalesLbl;
        private Label tOrderCount;
        private Label tSalesCount;
        private Label refundCount;
        private PictureBox tOrderIcon;
        private PictureBox tSaleIcon;
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
        private Panel mSalesPanel;
        private PictureBox mSaleIcon;
        private Label mSalesCount;
        private Label mSalesLbl;
    }
}
