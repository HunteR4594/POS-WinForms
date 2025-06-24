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
            tSalesChartPanel = new Panel();
            cartesianChart_comboBox = new ComboBox();
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
            pieChart_ComboBox = new ComboBox();
            tOrderChartPie = new PieChart();
            mainPanel.SuspendLayout();
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
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.White;
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
            // tSalesChartPanel
            // 
            tSalesChartPanel.BackColor = Color.Teal;
            tSalesChartPanel.Controls.Add(cartesianChart_comboBox);
            tSalesChartPanel.Controls.Add(tSalesChart);
            tSalesChartPanel.Location = new Point(397, 139);
            tSalesChartPanel.Margin = new Padding(3, 2, 3, 2);
            tSalesChartPanel.Name = "tSalesChartPanel";
            tSalesChartPanel.Size = new Size(515, 402);
            tSalesChartPanel.TabIndex = 7;
            // 
            // cartesianChart_comboBox
            // 
            cartesianChart_comboBox.FormattingEnabled = true;
            cartesianChart_comboBox.Location = new Point(18, 13);
            cartesianChart_comboBox.Name = "cartesianChart_comboBox";
            cartesianChart_comboBox.Size = new Size(324, 23);
            cartesianChart_comboBox.TabIndex = 2;
            // 
            // tSalesChart
            // 
            tSalesChart.BackColor = Color.PaleTurquoise;
            tSalesChart.Location = new Point(18, 50);
            tSalesChart.Margin = new Padding(2);
            tSalesChart.MatchAxesScreenDataRatio = false;
            tSalesChart.Name = "tSalesChart";
            tSalesChart.Size = new Size(482, 332);
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
            tOrdChartPnl.Controls.Add(pieChart_ComboBox);
            tOrdChartPnl.Controls.Add(tOrderChartPie);
            tOrdChartPnl.Location = new Point(26, 139);
            tOrdChartPnl.Margin = new Padding(3, 2, 3, 2);
            tOrdChartPnl.Name = "tOrdChartPnl";
            tOrdChartPnl.Size = new Size(354, 402);
            tOrdChartPnl.TabIndex = 6;
            // 
            // pieChart_ComboBox
            // 
            pieChart_ComboBox.FormattingEnabled = true;
            pieChart_ComboBox.Location = new Point(16, 12);
            pieChart_ComboBox.Name = "pieChart_ComboBox";
            pieChart_ComboBox.Size = new Size(249, 23);
            pieChart_ComboBox.TabIndex = 1;
            // 
            // tOrderChartPie
            // 
            tOrderChartPie.BackColor = Color.White;
            tOrderChartPie.InitialRotation = 0D;
            tOrderChartPie.IsClockwise = true;
            tOrderChartPie.Location = new Point(16, 49);
            tOrderChartPie.Margin = new Padding(3, 2, 3, 2);
            tOrderChartPie.MaxAngle = 360D;
            tOrderChartPie.MaxValue = double.NaN;
            tOrderChartPie.MinValue = 0D;
            tOrderChartPie.Name = "tOrderChartPie";
            tOrderChartPie.Size = new Size(320, 332);
            tOrderChartPie.TabIndex = 0;
            // 
            // CA_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CA_Dashboard";
            Size = new Size(964, 720);
            mainPanel.ResumeLayout(false);
            tSalesChartPanel.ResumeLayout(false);
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
        private Panel tSalesChartPanel;
        private Panel tOrdChartPnl;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart tSalesChart;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart tOrderChartPie;
        private Panel mSalesPanel;
        private PictureBox mSaleIcon;
        private Label mSalesCount;
        private Label mSalesLbl;
        private ComboBox cartesianChart_comboBox;
        private ComboBox pieChart_ComboBox;
    }
}
