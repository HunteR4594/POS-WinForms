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
            button6 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            addminAddEmp3 = new AddminAddEmp();
            cashierOrder1 = new CashierOrder();
            addProducts4 = new AddProducts();
            adminAddCategories3 = new AdminAddCategories();
            addProducts3 = new AddProducts();
            dashboard3 = new Dashboard();
            addProducts2 = new AddProducts();
            adminAddCategories2 = new AdminAddCategories();
            addProducts1 = new AddProducts();
            adminAddCategories1 = new AdminAddCategories();
            addminAddEmp2 = new AddminAddEmp();
            dashboard2 = new Dashboard();
            addminAddEmp1 = new AddminAddEmp();
            dashboard1 = new Dashboard();
            addProducts5 = new AddProducts();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 748);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Teal;
            button6.Image = Properties.Resources.ptodu;
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(-1, 315);
            button6.Name = "button6";
            button6.Size = new Size(115, 69);
            button6.TabIndex = 18;
            button6.Text = "Category";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Teal;
            button5.Image = Properties.Resources.Untitled_design__2_;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(-2, 556);
            button5.Name = "button5";
            button5.Size = new Size(114, 69);
            button5.TabIndex = 16;
            button5.Text = "Report";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Teal;
            button3.Image = Properties.Resources.ptodu;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(-3, 390);
            button3.Name = "button3";
            button3.Size = new Size(115, 69);
            button3.TabIndex = 15;
            button3.Text = "Product";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Teal;
            button4.Image = Properties.Resources.custom;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(-3, 465);
            button4.Name = "button4";
            button4.Size = new Size(114, 69);
            button4.TabIndex = 14;
            button4.Text = "Customer";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Teal;
            button2.Image = Properties.Resources.emp;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(-2, 223);
            button2.Name = "button2";
            button2.Size = new Size(120, 69);
            button2.TabIndex = 13;
            button2.Text = "Users";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            button1.Click += button1_Click;
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
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 37);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(227, 20);
            label3.TabIndex = 1;
            label3.Text = "Points of Sale | Manager's Portal";
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
            panel3.Controls.Add(addProducts5);
            panel3.Controls.Add(addminAddEmp3);
            panel3.Controls.Add(cashierOrder1);
            panel3.Controls.Add(addProducts4);
            panel3.Controls.Add(adminAddCategories3);
            panel3.Controls.Add(addProducts3);
            panel3.Controls.Add(dashboard3);
            panel3.Controls.Add(addProducts2);
            panel3.Controls.Add(adminAddCategories2);
            panel3.Controls.Add(addProducts1);
            panel3.Controls.Add(adminAddCategories1);
            panel3.Controls.Add(addminAddEmp2);
            panel3.Controls.Add(dashboard2);
            panel3.Controls.Add(addminAddEmp1);
            panel3.Controls.Add(dashboard1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(120, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 748);
            panel3.TabIndex = 7;
            // 
            // addminAddEmp3
            // 
            addminAddEmp3.BackColor = SystemColors.ControlLight;
            addminAddEmp3.Location = new Point(0, 0);
            addminAddEmp3.Name = "addminAddEmp3";
            addminAddEmp3.Size = new Size(1340, 935);
            addminAddEmp3.TabIndex = 13;
            // 
            // cashierOrder1
            // 
            cashierOrder1.BackColor = SystemColors.ControlLight;
            cashierOrder1.Location = new Point(0, 0);
            cashierOrder1.Name = "cashierOrder1";
            cashierOrder1.Size = new Size(1340, 935);
            cashierOrder1.TabIndex = 12;
            // 
            // addProducts4
            // 
            addProducts4.BackColor = SystemColors.ControlLight;
            addProducts4.Location = new Point(0, 0);
            addProducts4.Name = "addProducts4";
            addProducts4.Size = new Size(1340, 935);
            addProducts4.TabIndex = 11;
            // 
            // adminAddCategories3
            // 
            adminAddCategories3.Location = new Point(0, 0);
            adminAddCategories3.Name = "adminAddCategories3";
            adminAddCategories3.Size = new Size(1340, 935);
            adminAddCategories3.TabIndex = 10;
            // 
            // addProducts3
            // 
            addProducts3.BackColor = SystemColors.ControlLight;
            addProducts3.Location = new Point(0, 0);
            addProducts3.Name = "addProducts3";
            addProducts3.Size = new Size(1340, 935);
            addProducts3.TabIndex = 9;
            // 
            // dashboard3
            // 
            dashboard3.BackColor = SystemColors.ControlLight;
            dashboard3.Location = new Point(0, 0);
            dashboard3.Name = "dashboard3";
            dashboard3.Size = new Size(1340, 935);
            dashboard3.TabIndex = 8;
            // 
            // addProducts2
            // 
            addProducts2.BackColor = SystemColors.ControlLight;
            addProducts2.Location = new Point(0, 0);
            addProducts2.Name = "addProducts2";
            addProducts2.Size = new Size(1340, 935);
            addProducts2.TabIndex = 7;
            addProducts2.Load += addProducts2_Load;
            // 
            // adminAddCategories2
            // 
            adminAddCategories2.Location = new Point(35, 145);
            adminAddCategories2.Name = "adminAddCategories2";
            adminAddCategories2.Size = new Size(1340, 935);
            adminAddCategories2.TabIndex = 6;
            // 
            // addProducts1
            // 
            addProducts1.BackColor = SystemColors.ControlLight;
            addProducts1.Location = new Point(6, 145);
            addProducts1.Name = "addProducts1";
            addProducts1.Size = new Size(1340, 935);
            addProducts1.TabIndex = 5;
            // 
            // adminAddCategories1
            // 
            adminAddCategories1.Location = new Point(-9, 91);
            adminAddCategories1.Name = "adminAddCategories1";
            adminAddCategories1.Size = new Size(1340, 935);
            adminAddCategories1.TabIndex = 4;
            // 
            // addminAddEmp2
            // 
            addminAddEmp2.BackColor = SystemColors.ControlLight;
            addminAddEmp2.Location = new Point(17, 91);
            addminAddEmp2.Name = "addminAddEmp2";
            addminAddEmp2.Size = new Size(1340, 935);
            addminAddEmp2.TabIndex = 3;
            // 
            // dashboard2
            // 
            dashboard2.BackColor = SystemColors.ControlLight;
            dashboard2.Location = new Point(0, 54);
            dashboard2.Name = "dashboard2";
            dashboard2.Size = new Size(1340, 935);
            dashboard2.TabIndex = 2;
            // 
            // addminAddEmp1
            // 
            addminAddEmp1.BackColor = SystemColors.ControlLight;
            addminAddEmp1.Location = new Point(35, 281);
            addminAddEmp1.Name = "addminAddEmp1";
            addminAddEmp1.Size = new Size(1340, 935);
            addminAddEmp1.TabIndex = 1;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = SystemColors.ControlLight;
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1340, 935);
            dashboard1.TabIndex = 0;
            dashboard1.Load += dashboard1_Load;
            // 
            // addProducts5
            // 
            addProducts5.BackColor = SystemColors.ControlLight;
            addProducts5.Location = new Point(-1, 0);
            addProducts5.Name = "addProducts5";
            addProducts5.Size = new Size(1340, 935);
            addProducts5.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 785);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
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
            panel3.ResumeLayout(false);
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
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button5;
        private Panel panel4;
        private Dashboard dashboard1;

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
        private AddminAddEmp addminAddEmp1;
        private AddminAddEmp addminAddEmp2;
        private Dashboard dashboard2;
        private AdminAddCategories adminAddCategories1;
        private AddProducts addProducts1;
        private AdminAddCategories adminAddCategories2;
        private AddProducts addProducts2;
        private AddProducts addProducts4;
        private AdminAddCategories adminAddCategories3;
        private AddProducts addProducts3;
        private Dashboard dashboard3;
        private CashierOrder cashierOrder1;
        private Button button6;
        private AddminAddEmp addminAddEmp3;
        private AddProducts addProducts5;
    }
}