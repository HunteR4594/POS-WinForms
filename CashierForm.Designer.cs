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
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            cashierOrder1 = new CashierOrder();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 32);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Clothing";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(116, 104);
            panel4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(215, 20);
            label3.TabIndex = 1;
            label3.Text = "Points of Sale | Cashier's Portal";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 37);
            panel2.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1162, 9);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 0;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Teal;
            button5.Image = Properties.Resources.Untitled_design__2_;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(0, 224);
            button5.Name = "button5";
            button5.Size = new Size(116, 69);
            button5.TabIndex = 16;
            button5.Text = "Report";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Teal;
            button4.Image = Properties.Resources.custom;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(-2, 323);
            button4.Name = "button4";
            button4.Size = new Size(120, 69);
            button4.TabIndex = 14;
            button4.Text = "Customer";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Teal;
            button1.Image = Properties.Resources.dash;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(-2, 133);
            button1.Name = "button1";
            button1.Size = new Size(120, 69);
            button1.TabIndex = 12;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 748);
            panel1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Teal;
            button3.Image = Properties.Resources.ptodu;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(1, 427);
            button3.Name = "button3";
            button3.Size = new Size(114, 69);
            button3.TabIndex = 15;
            button3.Text = "Order";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(34, 661);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 37);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cashierOrder1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(120, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 748);
            panel3.TabIndex = 9;
            // 
            // cashierOrder1
            // 
            cashierOrder1.Location = new Point(0, 2);
            cashierOrder1.Name = "cashierOrder1";
            cashierOrder1.Size = new Size(1340, 935);
            cashierOrder1.TabIndex = 0;
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel4;
        private Label label3;
        private Panel panel2;
        private Label label8;
        private Button button5;
        private Button button4;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox6;
        private Button button3;
        private Panel panel3;
        private CashierOrder cashierOrder1;
    }
}