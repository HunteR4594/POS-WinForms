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
            LiveChartsCore.SkiaSharpView.Axis axis1 = new LiveChartsCore.SkiaSharpView.Axis();
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.Axis axis2 = new LiveChartsCore.SkiaSharpView.Axis();
            LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
            panel1 = new Panel();
            btnCategory = new Button();
            panel4 = new Panel();
            btnReports = new Button();
            btnProduct = new Button();
            btnUsers = new Button();
            btnDashboard = new Button();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            cA_Dashboard1 = new CA_Dashboard();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 561);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // btnCategory
            // 
            btnCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ForeColor = Color.Teal;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.TopCenter;
            btnCategory.Location = new Point(1, 236);
            btnCategory.Margin = new Padding(3, 2, 3, 2);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(101, 69);
            btnCategory.TabIndex = 18;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.BottomCenter;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(102, 78);
            panel4.TabIndex = 17;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.Teal;
            //btnReports.Image = POS_project._._6; 
            btnReports.ImageAlign = ContentAlignment.TopCenter;
            btnReports.Location = new Point(1, 390);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(99, 69);
            btnReports.TabIndex = 16;
            btnReports.Text = "Report";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += button5_Click;
            // 
            // btnProduct
            // 
            btnProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.Teal;
            //btnProduct.Image = POS_project._.ptodu;
            btnProduct.ImageAlign = ContentAlignment.TopCenter;
            btnProduct.Location = new Point(1, 320);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(101, 66);
            btnProduct.TabIndex = 15;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.BottomCenter;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += button3_Click;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.Teal;
            //btnUsers.Image = POS_project._.emp;
            btnUsers.ImageAlign = ContentAlignment.TopCenter;
            btnUsers.Location = new Point(1, 166);
            btnUsers.Margin = new Padding(3, 2, 3, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(102, 75);
            btnUsers.TabIndex = 13;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.BottomCenter;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BackgroundImageLayout = ImageLayout.Center;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Teal;
            btnDashboard.ImageAlign = ContentAlignment.TopRight;
            btnDashboard.Location = new Point(-1, 73);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(105, 80);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.BottomCenter;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(29, 496);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 28);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 7);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 1;
            label3.Text = "Points of Sale | Manager's Portal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(1016, 7);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 0;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // panel3
            // 
            panel3.Location = new Point(107, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(937, 561);
            panel3.TabIndex = 7;
            // 
            // cA_Dashboard1
            // 
            cA_Dashboard1.Location = new Point(0, 0);
            cA_Dashboard1.Margin = new Padding(3, 2, 3, 2);
            cA_Dashboard1.Name = "cA_Dashboard1";
            cA_Dashboard1.Size = new Size(1043, 561);
            cA_Dashboard1.TabIndex = 0;
            cA_Dashboard1.tOrderChartSeries = null;
            cA_Dashboard1.tSalesChartSeries = null;
            axis1.AnimationsSpeed = null;
            axis1.CrosshairLabelsBackground = null;
            axis1.CrosshairLabelsPaint = null;
            axis1.CrosshairPadding = null;
            axis1.CrosshairPaint = null;
            axis1.CrosshairSnapEnabled = false;
            axis1.CustomSeparators = null;
            axis1.DrawTicksPath = false;
            axis1.EasingFunction = null;
            axis1.ForceStepToMin = false;
            axis1.InLineNamePlacement = false;
            axis1.IsInverted = false;
            axis1.IsVisible = false;
            axis1.Labels = null;
            axis1.LabelsAlignment = null;
            axis1.LabelsPaint = null;
            axis1.LabelsRotation = 0D;
            axis1.MaxLimit = null;
            axis1.MinLimit = null;
            axis1.MinStep = 0D;
            axis1.MinZoomDelta = null;
            axis1.Name = null;
            padding1.Bottom = 5F;
            padding1.Left = 5F;
            padding1.Right = 5F;
            padding1.Top = 5F;
            axis1.NamePadding = padding1;
            axis1.NamePaint = null;
            axis1.NameTextSize = 20D;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            axis1.Padding = padding2;
            axis1.Position = LiveChartsCore.Measure.AxisPosition.Start;
            axis1.SeparatorsAtCenter = true;
            axis1.SeparatorsBrush = null;
            axis1.SeparatorsPaint = null;
            axis1.SharedWith = null;
            axis1.ShowSeparatorLines = true;
            axis1.SubseparatorsCount = 3;
            axis1.SubseparatorsPaint = null;
            axis1.SubticksPaint = null;
            axis1.Tag = null;
            axis1.TextBrush = null;
            axis1.TextSize = 16D;
            axis1.TicksAtCenter = true;
            axis1.TicksPaint = null;
            axis1.UnitWidth = 1D;
            axis1.ZeroPaint = null;
            cA_Dashboard1.tSalesChartXAxes = new LiveChartsCore.SkiaSharpView.Axis[]
    {
    axis1
    };
            axis2.AnimationsSpeed = null;
            axis2.CrosshairLabelsBackground = null;
            axis2.CrosshairLabelsPaint = null;
            axis2.CrosshairPadding = null;
            axis2.CrosshairPaint = null;
            axis2.CrosshairSnapEnabled = false;
            axis2.CustomSeparators = null;
            axis2.DrawTicksPath = false;
            axis2.EasingFunction = null;
            axis2.ForceStepToMin = false;
            axis2.InLineNamePlacement = false;
            axis2.IsInverted = false;
            axis2.IsVisible = false;
            axis2.Labels = null;
            axis2.LabelsAlignment = null;
            axis2.LabelsPaint = null;
            axis2.LabelsRotation = 0D;
            axis2.MaxLimit = null;
            axis2.MinLimit = null;
            axis2.MinStep = 0D;
            axis2.MinZoomDelta = null;
            axis2.Name = null;
            padding3.Bottom = 5F;
            padding3.Left = 5F;
            padding3.Right = 5F;
            padding3.Top = 5F;
            axis2.NamePadding = padding3;
            axis2.NamePaint = null;
            axis2.NameTextSize = 20D;
            padding4.Bottom = 0F;
            padding4.Left = 0F;
            padding4.Right = 0F;
            padding4.Top = 0F;
            axis2.Padding = padding4;
            axis2.Position = LiveChartsCore.Measure.AxisPosition.Start;
            axis2.SeparatorsAtCenter = true;
            axis2.SeparatorsBrush = null;
            axis2.SeparatorsPaint = null;
            axis2.SharedWith = null;
            axis2.ShowSeparatorLines = true;
            axis2.SubseparatorsCount = 3;
            axis2.SubseparatorsPaint = null;
            axis2.SubticksPaint = null;
            axis2.Tag = null;
            axis2.TextBrush = null;
            axis2.TextSize = 16D;
            axis2.TicksAtCenter = true;
            axis2.TicksPaint = null;
            axis2.UnitWidth = 1D;
            axis2.ZeroPaint = null;
            cA_Dashboard1.tSalesChartYAxes = new LiveChartsCore.SkiaSharpView.Axis[]
    {
    axis2
    };
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1043, 589);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel4;

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
    }
}