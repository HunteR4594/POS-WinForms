namespace POS_project
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label8 = new Label();
            button5 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(590, 51);
            label3.TabIndex = 1;
            label3.Text = "Points of Sale | Cashier's Portal";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 51);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(135, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 41);
            label4.TabIndex = 6;
            label4.Text = "-";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(174, 8);
            label1.Name = "label1";
            label1.Size = new Size(35, 31);
            label1.TabIndex = 5;
            label1.Text = "▢";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(215, 13);
            label8.Name = "label8";
            label8.Size = new Size(24, 24);
            label8.TabIndex = 0;
            label8.Text = "X";
            label8.TextAlign = ContentAlignment.MiddleRight;
            label8.Click += label8_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Teal;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(3, 180);
            button5.Name = "button5";
            button5.Size = new Size(101, 112);
            button5.TabIndex = 16;
            button5.Text = "Inventory";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Teal;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(3, 298);
            button4.Name = "button4";
            button4.Size = new Size(101, 112);
            button4.TabIndex = 14;
            button4.Text = "Customer Transaction";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 51);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(131, 734);
            panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 4);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 3);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9750233F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6833172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6833172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6833172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9750233F));
            tableLayoutPanel1.Size = new Size(107, 710);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 534);
            panel4.Name = "panel4";
            panel4.Size = new Size(101, 173);
            panel4.TabIndex = 12;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(27, 20);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 141);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Teal;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(3, 416);
            button3.Name = "button3";
            button3.Size = new Size(101, 112);
            button3.TabIndex = 15;
            button3.Text = "Order";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(131, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1061, 734);
            panel3.TabIndex = 9;
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
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(939, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 45);
            panel5.TabIndex = 1;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 785);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierForm";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Panel panel2;
        private Label label8;
        private Button button5;
        private Button button4;
        private Panel panel1;
        private PictureBox pictureBox6;
        private Button button3;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
    }
}