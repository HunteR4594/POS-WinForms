using System.Windows.Forms;

namespace POS_project
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LiveChartsCore.SkiaSharpView.Axis axis3 = new LiveChartsCore.SkiaSharpView.Axis();
            LiveChartsCore.Drawing.Padding padding5 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.Drawing.Padding padding6 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.Axis axis4 = new LiveChartsCore.SkiaSharpView.Axis();
            LiveChartsCore.Drawing.Padding padding7 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.Drawing.Padding padding8 = new LiveChartsCore.Drawing.Padding();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            btnUsers = new Button();
            btnReports = new Button();
            btnProduct = new Button();
            btnCategory = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            cA_Dashboard1 = new CA_Dashboard();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 734);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnDashboard, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 6);
            tableLayoutPanel1.Controls.Add(btnUsers, 0, 2);
            tableLayoutPanel1.Controls.Add(btnReports, 0, 5);
            tableLayoutPanel1.Controls.Add(btnProduct, 0, 4);
            tableLayoutPanel1.Controls.Add(btnCategory, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(131, 730);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BackgroundImageLayout = ImageLayout.Center;
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Teal;
            btnDashboard.Location = new Point(10, 152);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(111, 85);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.BottomCenter;
            btnDashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(13, 580);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 137);
            panel4.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(32, 37);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.Teal;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.Location = new Point(13, 240);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(105, 79);
            btnUsers.TabIndex = 13;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.BottomCenter;
            btnUsers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += button2_Click;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.Teal;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.Location = new Point(13, 495);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(105, 79);
            btnReports.TabIndex = 16;
            btnReports.Text = "Report";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += button5_Click;
            // 
            // btnProduct
            // 
            btnProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.Teal;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.Location = new Point(13, 410);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(105, 79);
            btnProduct.TabIndex = 15;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.BottomCenter;
            btnProduct.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += button3_Click;
            // 
            // btnCategory
            // 
            btnCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ForeColor = Color.Teal;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.Location = new Point(13, 325);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(105, 79);
            btnCategory.TabIndex = 18;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.BottomCenter;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 51);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(130, 3);
            label4.Name = "label4";
            label4.Size = new Size(33, 41);
            label4.TabIndex = 3;
            label4.Text = "-";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 31);
            label1.TabIndex = 2;
            label1.Text = "▢";
            label1.Click += label1_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(590, 51);
            label3.TabIndex = 1;
            label3.Text = "Points of Sale | Manager's Portal";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(213, 9);
            label8.Name = "label8";
            label8.Size = new Size(29, 31);
            label8.TabIndex = 0;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(133, 51);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1059, 734);
            panel3.TabIndex = 7;
            // 
            // cA_Dashboard1
            // 
            cA_Dashboard1.BackColor = SystemColors.ControlLight;
            cA_Dashboard1.Location = new Point(0, 0);
            cA_Dashboard1.Margin = new Padding(3, 2, 3, 2);
            cA_Dashboard1.Name = "cA_Dashboard1";
            cA_Dashboard1.Padding = new Padding(11, 13, 11, 13);
            cA_Dashboard1.Size = new Size(1043, 561);
            cA_Dashboard1.TabIndex = 0;
            cA_Dashboard1.tOrderChartSeries = null;
            cA_Dashboard1.tSalesChartSeries = null;
            axis3.AnimationsSpeed = null;
            axis3.CrosshairLabelsBackground = null;
            axis3.CrosshairLabelsPaint = null;
            axis3.CrosshairPadding = null;
            axis3.CrosshairPaint = null;
            axis3.CrosshairSnapEnabled = false;
            axis3.CustomSeparators = null;
            axis3.DrawTicksPath = false;
            axis3.EasingFunction = null;
            axis3.ForceStepToMin = false;
            axis3.InLineNamePlacement = false;
            axis3.IsInverted = false;
            axis3.IsVisible = false;
            axis3.Labels = null;
            axis3.LabelsAlignment = null;
            axis3.LabelsPaint = null;
            axis3.LabelsRotation = 0D;
            axis3.MaxLimit = null;
            axis3.MinLimit = null;
            axis3.MinStep = 0D;
            axis3.MinZoomDelta = null;
            axis3.Name = null;
            padding5.Bottom = 5F;
            padding5.Left = 5F;
            padding5.Right = 5F;
            padding5.Top = 5F;
            axis3.NamePadding = padding5;
            axis3.NamePaint = null;
            axis3.NameTextSize = 20D;
            padding6.Bottom = 0F;
            padding6.Left = 0F;
            padding6.Right = 0F;
            padding6.Top = 0F;
            axis3.Padding = padding6;
            axis3.Position = LiveChartsCore.Measure.AxisPosition.Start;
            axis3.SeparatorsAtCenter = true;
            axis3.SeparatorsBrush = null;
            axis3.SeparatorsPaint = null;
            axis3.SharedWith = null;
            axis3.ShowSeparatorLines = true;
            axis3.SubseparatorsCount = 3;
            axis3.SubseparatorsPaint = null;
            axis3.SubticksPaint = null;
            axis3.Tag = null;
            axis3.TextBrush = null;
            axis3.TextSize = 16D;
            axis3.TicksAtCenter = true;
            axis3.TicksPaint = null;
            axis3.UnitWidth = 1D;
            axis3.ZeroPaint = null;
            cA_Dashboard1.tSalesChartXAxes = new LiveChartsCore.SkiaSharpView.Axis[]
    {
    axis3
    };
            axis4.AnimationsSpeed = null;
            axis4.CrosshairLabelsBackground = null;
            axis4.CrosshairLabelsPaint = null;
            axis4.CrosshairPadding = null;
            axis4.CrosshairPaint = null;
            axis4.CrosshairSnapEnabled = false;
            axis4.CustomSeparators = null;
            axis4.DrawTicksPath = false;
            axis4.EasingFunction = null;
            axis4.ForceStepToMin = false;
            axis4.InLineNamePlacement = false;
            axis4.IsInverted = false;
            axis4.IsVisible = false;
            axis4.Labels = null;
            axis4.LabelsAlignment = null;
            axis4.LabelsPaint = null;
            axis4.LabelsRotation = 0D;
            axis4.MaxLimit = null;
            axis4.MinLimit = null;
            axis4.MinStep = 0D;
            axis4.MinZoomDelta = null;
            axis4.Name = null;
            padding7.Bottom = 5F;
            padding7.Left = 5F;
            padding7.Right = 5F;
            padding7.Top = 5F;
            axis4.NamePadding = padding7;
            axis4.NamePaint = null;
            axis4.NameTextSize = 20D;
            padding8.Bottom = 0F;
            padding8.Left = 0F;
            padding8.Right = 0F;
            padding8.Top = 0F;
            axis4.Padding = padding8;
            axis4.Position = LiveChartsCore.Measure.AxisPosition.Start;
            axis4.SeparatorsAtCenter = true;
            axis4.SeparatorsBrush = null;
            axis4.SeparatorsPaint = null;
            axis4.SharedWith = null;
            axis4.ShowSeparatorLines = true;
            axis4.SubseparatorsCount = 3;
            axis4.SubseparatorsPaint = null;
            axis4.SubticksPaint = null;
            axis4.Tag = null;
            axis4.TextBrush = null;
            axis4.TextSize = 16D;
            axis4.TicksAtCenter = true;
            axis4.TicksPaint = null;
            axis4.UnitWidth = 1D;
            axis4.ZeroPaint = null;
            cA_Dashboard1.tSalesChartYAxes = new LiveChartsCore.SkiaSharpView.Axis[]
    {
    axis4
    };
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel5, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1192, 51);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(939, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 45);
            panel5.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1192, 785);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox6;
        private Panel panel2;
        private Label label8;
        private Label label2;
        private Panel panel3;
        private Button btnProduct;
        private Button btnUsers;
        private Button btnDashboard;
        private Button btnReports;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Add your custom painting logic here if needed.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Add your logic for button4 click event here.
            MessageBox.Show("Customer button clicked!");
        }

        private Label label3;
        private CashierOrder cashierOrder1;
        private Button btnCategory;
        private CA_Dashboard cA_Dashboard1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Label label1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
    }
}