namespace POS_project
{
    partial class AddProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            dataGridViewproducts = new DataGridView();
            panel2 = new Panel();
            Clear_Product = new Button();
            Remove_Product = new Button();
            Update_Product = new Button();
            Add_Product = new Button();
            Import = new Button();
            panel3 = new Panel();
            Import_pic = new PictureBox();
            Add_Product_Status = new ComboBox();
            Add_Category = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            Add_Product_Stock = new TextBox();
            add_product_name = new Label();
            Product_Name = new TextBox();
            label2 = new Label();
            add_Product_Price = new TextBox();
            label1 = new Label();
            add_product_ID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Import_pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dataGridViewproducts);
            panel1.Location = new Point(24, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 307);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 20);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 12;
            label6.Text = "All Product";
            // 
            // dataGridViewproducts
            // 
            dataGridViewproducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewproducts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewproducts.Location = new Point(26, 56);
            dataGridViewproducts.Name = "dataGridViewproducts";
            dataGridViewproducts.RowHeadersWidth = 51;
            dataGridViewproducts.Size = new Size(971, 229);
            dataGridViewproducts.TabIndex = 0;
            dataGridViewproducts.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Clear_Product);
            panel2.Controls.Add(Remove_Product);
            panel2.Controls.Add(Update_Product);
            panel2.Controls.Add(Add_Product);
            panel2.Controls.Add(Import);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Add_Product_Status);
            panel2.Controls.Add(Add_Category);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Add_Product_Stock);
            panel2.Controls.Add(add_product_name);
            panel2.Controls.Add(Product_Name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(add_Product_Price);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(add_product_ID);
            panel2.Location = new Point(24, 335);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 384);
            panel2.TabIndex = 1;
            // 
            // Clear_Product
            // 
            Clear_Product.BackColor = Color.Teal;
            Clear_Product.FlatStyle = FlatStyle.Flat;
            Clear_Product.ForeColor = Color.White;
            Clear_Product.Location = new Point(757, 256);
            Clear_Product.Name = "Clear_Product";
            Clear_Product.Size = new Size(162, 42);
            Clear_Product.TabIndex = 17;
            Clear_Product.Text = "Clear";
            Clear_Product.UseVisualStyleBackColor = false;
            Clear_Product.Click += Clear_Product_Click;
            // 
            // Remove_Product
            // 
            Remove_Product.BackColor = Color.Teal;
            Remove_Product.FlatStyle = FlatStyle.Flat;
            Remove_Product.ForeColor = Color.White;
            Remove_Product.Location = new Point(523, 256);
            Remove_Product.Name = "Remove_Product";
            Remove_Product.Size = new Size(162, 42);
            Remove_Product.TabIndex = 16;
            Remove_Product.Text = "Remove";
            Remove_Product.UseVisualStyleBackColor = false;
            Remove_Product.Click += Remove_Product_Click;
            // 
            // Update_Product
            // 
            Update_Product.BackColor = Color.Teal;
            Update_Product.FlatStyle = FlatStyle.Flat;
            Update_Product.ForeColor = Color.White;
            Update_Product.Location = new Point(288, 256);
            Update_Product.Name = "Update_Product";
            Update_Product.Size = new Size(162, 42);
            Update_Product.TabIndex = 15;
            Update_Product.Text = "Update";
            Update_Product.UseVisualStyleBackColor = false;
            Update_Product.Click += Update_Product_Click;
            // 
            // Add_Product
            // 
            Add_Product.BackColor = Color.Teal;
            Add_Product.FlatStyle = FlatStyle.Flat;
            Add_Product.ForeColor = Color.White;
            Add_Product.Location = new Point(50, 256);
            Add_Product.Name = "Add_Product";
            Add_Product.Size = new Size(162, 42);
            Add_Product.TabIndex = 14;
            Add_Product.Text = "Add";
            Add_Product.UseVisualStyleBackColor = false;
            Add_Product.Click += Add_Product_Click;
            // 
            // Import
            // 
            Import.BackColor = Color.Teal;
            Import.FlatStyle = FlatStyle.Flat;
            Import.ForeColor = Color.White;
            Import.Location = new Point(849, 144);
            Import.Name = "Import";
            Import.Size = new Size(94, 35);
            Import.TabIndex = 13;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = false;
            Import.Click += Import_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Import_pic);
            panel3.Location = new Point(824, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(151, 97);
            panel3.TabIndex = 12;
            // 
            // Import_pic
            // 
            Import_pic.Location = new Point(0, 0);
            Import_pic.Name = "Import_pic";
            Import_pic.Size = new Size(151, 97);
            Import_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Import_pic.TabIndex = 0;
            Import_pic.TabStop = false;
            // 
            // Add_Product_Status
            // 
            Add_Product_Status.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Product_Status.FormattingEnabled = true;
            Add_Product_Status.Items.AddRange(new object[] { "Available", "Not Available" });
            Add_Product_Status.Location = new Point(421, 167);
            Add_Product_Status.Name = "Add_Product_Status";
            Add_Product_Status.Size = new Size(279, 33);
            Add_Product_Status.TabIndex = 11;
            // 
            // Add_Category
            // 
            Add_Category.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Category.FormattingEnabled = true;
            Add_Category.Location = new Point(44, 167);
            Add_Category.Name = "Add_Category";
            Add_Category.Size = new Size(293, 33);
            Add_Category.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 144);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 9;
            label4.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 144);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 8;
            label5.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 77);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Stock:";
            // 
            // Add_Product_Stock
            // 
            Add_Product_Stock.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Product_Stock.Location = new Point(421, 100);
            Add_Product_Stock.Name = "Add_Product_Stock";
            Add_Product_Stock.Size = new Size(279, 31);
            Add_Product_Stock.TabIndex = 6;
            // 
            // add_product_name
            // 
            add_product_name.AutoSize = true;
            add_product_name.Location = new Point(44, 77);
            add_product_name.Name = "add_product_name";
            add_product_name.Size = new Size(107, 20);
            add_product_name.TabIndex = 5;
            add_product_name.Text = "Product Name:";
            // 
            // Product_Name
            // 
            Product_Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product_Name.Location = new Point(44, 100);
            Product_Name.Name = "Product_Name";
            Product_Name.Size = new Size(293, 31);
            Product_Name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 14);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // add_Product_Price
            // 
            add_Product_Price.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_Product_Price.Location = new Point(421, 37);
            add_Product_Price.Name = "add_Product_Price";
            add_Product_Price.Size = new Size(279, 31);
            add_Product_Price.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Product ID:";
            // 
            // add_product_ID
            // 
            add_product_ID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_product_ID.Location = new Point(44, 37);
            add_product_ID.Name = "add_product_ID";
            add_product_ID.Size = new Size(293, 31);
            add_product_ID.TabIndex = 0;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddProducts";
            Size = new Size(1072, 748);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Import_pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewproducts;
        private Panel panel2;
        private Label label2;
        private TextBox add_Product_Price;
        private Label label1;
        private TextBox add_product_ID;
        private ComboBox Add_Product_Status;
        private ComboBox Add_Category;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox Add_Product_Stock;
        private Label add_product_name;
        private TextBox Product_Name;
        private Label label6;
        private Button Import;
        private Panel panel3;
        private PictureBox Import_pic;
        private Button Clear_Product;
        private Button Remove_Product;
        private Button Update_Product;
        private Button Add_Product;
    }
}
