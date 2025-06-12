namespace POS_project
{
    partial class Dashboard
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
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 197);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(782, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 118);
            panel4.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Total_inc;
            pictureBox4.Location = new Point(12, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.Teal;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(526, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(246, 118);
            panel5.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.inc;
            pictureBox3.Location = new Point(12, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += this.pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(269, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 118);
            panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cust;
            pictureBox2.Location = new Point(14, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 118);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 82);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 2;
            label3.Text = "All Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(113, 25);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.emp1;
            pictureBox1.Location = new Point(14, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(16, 266);
            panel6.Name = "panel6";
            panel6.Size = new Size(1040, 460);
            panel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 1;
            label1.Text = "All Today's Customer";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1004, 360);
            dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(108, 79);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 4;
            label4.Text = "All Customers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(108, 22);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 3;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(109, 82);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 6;
            label6.Text = "Today's Income";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(109, 25);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 5;
            label7.Text = "$10.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(106, 82);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 8;
            label8.Text = "Total Income";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(106, 25);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 7;
            label9.Text = "$10.00";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(1072, 748);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel6;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
    }
}
