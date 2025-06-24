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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            dataGridViewproducts = new DataGridView();
            panel2 = new Panel();
            barcodePreview = new PictureBox();
            label7 = new Label();
            Clear_Product = new Button();
            Remove_Product = new Button();
            Update_Product = new Button();
            Add_Product = new Button();
            GenerateBarcode = new Button();
            Add_Product_Status = new ComboBox();
            Add_Category = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            Add_Product_stock = new TextBox();
            add_product_name = new Label();
            Product_Name = new TextBox();
            label2 = new Label();
            add_Product_Price = new TextBox();
            label1 = new Label();
            add_product_id = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)barcodePreview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dataGridViewproducts);
            panel1.Location = new Point(21, 16);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 230);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 15);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 12;
            label6.Text = "All Product";
            // 
            // dataGridViewproducts
            // 
            dataGridViewproducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Teal;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewproducts.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewproducts.Location = new Point(23, 42);
            dataGridViewproducts.Margin = new Padding(3, 2, 3, 2);
            dataGridViewproducts.Name = "dataGridViewproducts";
            dataGridViewproducts.RowHeadersWidth = 51;
            dataGridViewproducts.Size = new Size(850, 172);
            dataGridViewproducts.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(barcodePreview);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Clear_Product);
            panel2.Controls.Add(Remove_Product);
            panel2.Controls.Add(Update_Product);
            panel2.Controls.Add(Add_Product);
            panel2.Controls.Add(GenerateBarcode);
            panel2.Controls.Add(Add_Product_Status);
            panel2.Controls.Add(Add_Category);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Add_Product_stock);
            panel2.Controls.Add(add_product_name);
            panel2.Controls.Add(Product_Name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(add_Product_Price);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(add_product_id);
            panel2.Location = new Point(21, 251);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(897, 288);
            panel2.TabIndex = 1;
            // 
            // barcodePreview
            // 
            barcodePreview.Location = new Point(635, 58);
            barcodePreview.Margin = new Padding(3, 2, 3, 2);
            barcodePreview.Name = "barcodePreview";
            barcodePreview.Size = new Size(237, 94);
            barcodePreview.SizeMode = PictureBoxSizeMode.Zoom;
            barcodePreview.TabIndex = 18;
            barcodePreview.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 108);
            label7.Name = "label7";
            label7.Size = new Size(112, 17);
            label7.TabIndex = 17;
            label7.Text = "Barcode Preview:";
            // 
            // Clear_Product
            // 
            Clear_Product.BackColor = Color.Teal;
            Clear_Product.BackgroundImageLayout = ImageLayout.None;
            Clear_Product.FlatStyle = FlatStyle.Flat;
            Clear_Product.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear_Product.ForeColor = Color.White;
            Clear_Product.Location = new Point(662, 192);
            Clear_Product.Margin = new Padding(3, 2, 3, 2);
            Clear_Product.Name = "Clear_Product";
            Clear_Product.Size = new Size(142, 32);
            Clear_Product.TabIndex = 17;
            Clear_Product.Text = "Clear";
            Clear_Product.UseVisualStyleBackColor = false;
            Clear_Product.Click += Clear_Product_Click;
            // 
            // Remove_Product
            // 
            Remove_Product.BackColor = Color.Teal;
            Remove_Product.BackgroundImageLayout = ImageLayout.None;
            Remove_Product.FlatStyle = FlatStyle.Flat;
            Remove_Product.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove_Product.ForeColor = Color.White;
            Remove_Product.Location = new Point(458, 192);
            Remove_Product.Margin = new Padding(3, 2, 3, 2);
            Remove_Product.Name = "Remove_Product";
            Remove_Product.Size = new Size(142, 32);
            Remove_Product.TabIndex = 16;
            Remove_Product.Text = "Remove";
            Remove_Product.UseVisualStyleBackColor = false;
            Remove_Product.Click += Remove_Product_Click;
            // 
            // Update_Product
            // 
            Update_Product.BackColor = Color.Teal;
            Update_Product.BackgroundImageLayout = ImageLayout.None;
            Update_Product.FlatStyle = FlatStyle.Flat;
            Update_Product.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_Product.ForeColor = Color.White;
            Update_Product.Location = new Point(252, 192);
            Update_Product.Margin = new Padding(3, 2, 3, 2);
            Update_Product.Name = "Update_Product";
            Update_Product.Size = new Size(142, 32);
            Update_Product.TabIndex = 15;
            Update_Product.Text = "Update";
            Update_Product.UseVisualStyleBackColor = false;
            Update_Product.Click += Update_Product_Click;
            // 
            // Add_Product
            // 
            Add_Product.BackColor = Color.Teal;
            Add_Product.BackgroundImageLayout = ImageLayout.None;
            Add_Product.FlatStyle = FlatStyle.Flat;
            Add_Product.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Product.ForeColor = Color.White;
            Add_Product.Location = new Point(44, 192);
            Add_Product.Margin = new Padding(3, 2, 3, 2);
            Add_Product.Name = "Add_Product";
            Add_Product.Size = new Size(142, 32);
            Add_Product.TabIndex = 14;
            Add_Product.Text = "Add";
            Add_Product.UseVisualStyleBackColor = false;
            Add_Product.Click += Add_Product_Click;
            // 
            // GenerateBarcode
            // 
            GenerateBarcode.BackColor = Color.Teal;
            GenerateBarcode.BackgroundImageLayout = ImageLayout.None;
            GenerateBarcode.FlatStyle = FlatStyle.Flat;
            GenerateBarcode.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateBarcode.ForeColor = Color.White;
            GenerateBarcode.Location = new Point(672, 28);
            GenerateBarcode.Margin = new Padding(3, 2, 3, 2);
            GenerateBarcode.Name = "GenerateBarcode";
            GenerateBarcode.Size = new Size(166, 26);
            GenerateBarcode.TabIndex = 13;
            GenerateBarcode.Text = "Generate Bar code";
            GenerateBarcode.UseVisualStyleBackColor = false;
            GenerateBarcode.Click += GenerateBarcode_Click;
            // 
            // Add_Product_Status
            // 
            Add_Product_Status.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Product_Status.FormattingEnabled = true;
            Add_Product_Status.Items.AddRange(new object[] { "Available", "Not Available" });
            Add_Product_Status.Location = new Point(368, 125);
            Add_Product_Status.Margin = new Padding(3, 2, 3, 2);
            Add_Product_Status.Name = "Add_Product_Status";
            Add_Product_Status.Size = new Size(245, 27);
            Add_Product_Status.TabIndex = 11;
            // 
            // Add_Category
            // 
            Add_Category.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Category.FormattingEnabled = true;
            Add_Category.Location = new Point(38, 125);
            Add_Category.Margin = new Padding(3, 2, 3, 2);
            Add_Category.Name = "Add_Category";
            Add_Category.Size = new Size(257, 27);
            Add_Category.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(368, 106);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 9;
            label4.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 108);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 58);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 7;
            label3.Text = "Stock:";
            // 
            // Add_Product_stock
            // 
            Add_Product_stock.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Product_stock.Location = new Point(368, 75);
            Add_Product_stock.Margin = new Padding(3, 2, 3, 2);
            Add_Product_stock.Name = "Add_Product_stock";
            Add_Product_stock.Size = new Size(245, 27);
            Add_Product_stock.TabIndex = 6;
            // 
            // add_product_name
            // 
            add_product_name.AutoSize = true;
            add_product_name.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_product_name.Location = new Point(38, 58);
            add_product_name.Name = "add_product_name";
            add_product_name.Size = new Size(99, 17);
            add_product_name.TabIndex = 5;
            add_product_name.Text = "Product Name:";
            // 
            // Product_Name
            // 
            Product_Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product_Name.Location = new Point(38, 75);
            Product_Name.Margin = new Padding(3, 2, 3, 2);
            Product_Name.Name = "Product_Name";
            Product_Name.Size = new Size(257, 27);
            Product_Name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 10);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // add_Product_Price
            // 
            add_Product_Price.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_Product_Price.Location = new Point(368, 28);
            add_Product_Price.Margin = new Padding(3, 2, 3, 2);
            add_Product_Price.Name = "add_Product_Price";
            add_Product_Price.Size = new Size(245, 27);
            add_Product_Price.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 16);
            label1.TabIndex = 1;
            label1.Text = "Product ID:";
            // 
            // add_product_id
            // 
            add_product_id.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_product_id.Location = new Point(38, 28);
            add_product_id.Margin = new Padding(3, 2, 3, 2);
            add_product_id.Name = "add_product_id";
            add_product_id.Size = new Size(257, 27);
            add_product_id.TabIndex = 0;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddProducts";
            Size = new Size(938, 561);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)barcodePreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewproducts;
        private Panel panel2;
        private Label label2;
        private TextBox add_Product_Price;
        private Label label1;
        private TextBox add_product_id;
        private ComboBox Add_Product_Status;
        private ComboBox Add_Category;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox Add_Product_stock;
        private Label add_product_name;
        private TextBox Product_Name;
        private Label label6;
        private Button GenerateBarcode;
        private Button Clear_Product;
        private Button Remove_Product;
        private Button Update_Product;
        private Button Add_Product;
        private PictureBox barcodePreview;
        private Label label7;
    }
}
