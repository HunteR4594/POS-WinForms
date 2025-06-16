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
            panel1 = new Panel();
            btnCategory = new Button();
            panel4 = new Panel();
            label1 = new Label();
            btnReports = new Button();
            btnProduct = new Button();
            btnCustomer = new Button();
            btnUsers = new Button();
            btnDashboard = new Button();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(btnCustomer);
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
            btnCategory.ImageAlign = ContentAlignment.TopCenter;
            btnCategory.Location = new Point(-1, 236);
            btnCategory.Margin = new Padding(3, 2, 3, 2);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(101, 50);
            btnCategory.TabIndex = 18;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.BottomCenter;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(102, 78);
            panel4.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Clothing";
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.Teal;
            btnReports.ImageAlign = ContentAlignment.TopCenter;
            btnReports.Location = new Point(-1, 417);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(99, 50);
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
            btnProduct.ImageAlign = ContentAlignment.TopCenter;
            btnProduct.Location = new Point(-3, 293);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(101, 50);
            btnProduct.TabIndex = 15;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.BottomCenter;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += button3_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = Color.Teal;
            btnCustomer.ImageAlign = ContentAlignment.TopCenter;
            btnCustomer.Location = new Point(-3, 349);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(99, 50);
            btnCustomer.TabIndex = 14;
            btnCustomer.Text = "Customer";
            btnCustomer.TextAlign = ContentAlignment.BottomCenter;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += button4_Click;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.Teal;
            btnUsers.ImageAlign = ContentAlignment.TopCenter;
            btnUsers.Location = new Point(-1, 167);
            btnUsers.Margin = new Padding(3, 2, 3, 2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(105, 50);
            btnUsers.TabIndex = 13;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.BottomCenter;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Teal;
            btnDashboard.ImageAlign = ContentAlignment.TopCenter;
            btnDashboard.Location = new Point(-1, 100);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(105, 52);
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
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 7);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 1;
            label3.Text = "Points of Sale | Manager's Portal";
            // 
            // label8
            // 
            label8.AutoSize = true;
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
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(106, 28);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(937, 561);
            panel3.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox6;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private Label label2;
        private Panel panel3;
        private Button btnProduct;
        private Button btnCustomer;
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Add your logic for button2 click event here.
            MessageBox.Show("Add Users button clicked!");

            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            POS_project.AddminAddEmp myControl = new POS_project.AddminAddEmp();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add your logic for button1 click event here.
            MessageBox.Show("Dashboard button clicked!");
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            // Add your logic for the Dashboard load event here.
            //MessageBox.Show("Dashboard loaded!");
        }
        private Label label3;
        private CashierOrder cashierOrder1;
        private Button btnCategory;
    }
}