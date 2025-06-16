namespace POS_project
{
    partial class CashierOrder
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Clear_CashierOr = new Button();
            Remove_CashierOr = new Button();
            Add_CashierOr = new Button();
            Cashier_QuantityOr = new NumericUpDown();
            Cashier_ProductIDOr = new ComboBox();
            Cashier_CategoryOr = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            Cashier_ChangeOr = new Label();
            Cashier_Total_PriceOr = new Label();
            Cashier_ReceiptOr = new Button();
            Cashier_Pay_OrdersOr = new Button();
            Cashier_AmountOr = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            appDbContextBindingSource = new BindingSource(components);
            Cashier_PriceOr = new Label();
            Cashier_Product_NameOr = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cashier_QuantityOr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Clear_CashierOr);
            panel1.Controls.Add(Remove_CashierOr);
            panel1.Controls.Add(Add_CashierOr);
            panel1.Controls.Add(Cashier_PriceOr);
            panel1.Controls.Add(Cashier_Product_NameOr);
            panel1.Controls.Add(Cashier_QuantityOr);
            panel1.Controls.Add(Cashier_ProductIDOr);
            panel1.Controls.Add(Cashier_CategoryOr);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(24, 21);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 519);
            panel1.TabIndex = 0;
            // 
            // Clear_CashierOr
            // 
            Clear_CashierOr.BackColor = Color.Teal;
            Clear_CashierOr.FlatStyle = FlatStyle.Flat;
            Clear_CashierOr.ForeColor = Color.White;
            Clear_CashierOr.Location = new Point(428, 448);
            Clear_CashierOr.Margin = new Padding(3, 2, 3, 2);
            Clear_CashierOr.Name = "Clear_CashierOr";
            Clear_CashierOr.Size = new Size(116, 32);
            Clear_CashierOr.TabIndex = 14;
            Clear_CashierOr.Text = "Clear";
            Clear_CashierOr.UseVisualStyleBackColor = false;
            this.Clear_CashierOr.Click += new System.EventHandler(this.Clear_CashierOr_Click); // ADD THIS LINE
            // 
            // Remove_CashierOr
            // 
            Remove_CashierOr.BackColor = Color.Teal;
            Remove_CashierOr.FlatStyle = FlatStyle.Flat;
            Remove_CashierOr.ForeColor = Color.White;
            Remove_CashierOr.Location = new Point(199, 448);
            Remove_CashierOr.Margin = new Padding(3, 2, 3, 2);
            Remove_CashierOr.Name = "Remove_CashierOr";
            Remove_CashierOr.Size = new Size(116, 32);
            Remove_CashierOr.TabIndex = 13;
            Remove_CashierOr.Text = "Remove";
            Remove_CashierOr.UseVisualStyleBackColor = false;
            this.Remove_CashierOr.Click += new System.EventHandler(this.Remove_CashierOr_Click); // ADD THIS LINE
            // 
            // Add_CashierOr
            // 
            Add_CashierOr.BackColor = Color.Teal;
            Add_CashierOr.FlatStyle = FlatStyle.Flat;
            Add_CashierOr.ForeColor = Color.White;
            Add_CashierOr.Location = new Point(45, 448);
            Add_CashierOr.Margin = new Padding(3, 2, 3, 2);
            Add_CashierOr.Name = "Add_CashierOr";
            Add_CashierOr.Size = new Size(116, 32);
            Add_CashierOr.TabIndex = 12;
            Add_CashierOr.Text = "Add";
            Add_CashierOr.UseVisualStyleBackColor = false;
            this.Add_CashierOr.Click += new System.EventHandler(this.Add_CashierOr_Click); // ADD THIS LINE
            // 
            // Cashier_QuantityOr
            // 
            Cashier_QuantityOr.Font = new Font("Segoe UI", 10.8F);
            Cashier_QuantityOr.Location = new Point(400, 336);
            Cashier_QuantityOr.Margin = new Padding(3, 2, 3, 2);
            Cashier_QuantityOr.Name = "Cashier_QuantityOr";
            Cashier_QuantityOr.Size = new Size(131, 27);
            Cashier_QuantityOr.TabIndex = 9;
            Cashier_QuantityOr.ValueChanged += Cashier_QuantityOr_ValueChanged;
            // 
            // Cashier_ProductIDOr
            // 
            Cashier_ProductIDOr.Font = new Font("Segoe UI", 10.8F);
            Cashier_ProductIDOr.FormattingEnabled = true;
            Cashier_ProductIDOr.Location = new Point(395, 289);
            Cashier_ProductIDOr.Margin = new Padding(3, 2, 3, 2);
            Cashier_ProductIDOr.Name = "Cashier_ProductIDOr";
            Cashier_ProductIDOr.Size = new Size(160, 27);
            Cashier_ProductIDOr.TabIndex = 8;
            // 
            // Cashier_CategoryOr
            // 
            Cashier_CategoryOr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cashier_CategoryOr.FormattingEnabled = true;
            Cashier_CategoryOr.Location = new Point(125, 289);
            Cashier_CategoryOr.Margin = new Padding(3, 2, 3, 2);
            Cashier_CategoryOr.Name = "Cashier_CategoryOr";
            Cashier_CategoryOr.Size = new Size(160, 27);
            Cashier_CategoryOr.TabIndex = 7;
            Cashier_CategoryOr.SelectedIndexChanged += Cashier_CategoryOr_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 344);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 6;
            label6.Text = "Product Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 393);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Price (₱):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 340);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 294);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 294);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Category:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Available Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 35);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(542, 212);
            dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick); // ADD THIS LINE
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Cashier_ChangeOr);
            panel2.Controls.Add(Cashier_Total_PriceOr);
            panel2.Controls.Add(Cashier_ReceiptOr);
            panel2.Controls.Add(Cashier_Pay_OrdersOr);
            panel2.Controls.Add(Cashier_AmountOr);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(616, 21);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 519);
            panel2.TabIndex = 1;
            // 
            // Cashier_ChangeOr
            // 
            Cashier_ChangeOr.AutoSize = true;
            Cashier_ChangeOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_ChangeOr.Location = new Point(116, 376);
            Cashier_ChangeOr.Name = "Cashier_ChangeOr";
            Cashier_ChangeOr.Size = new Size(31, 15);
            Cashier_ChangeOr.TabIndex = 18;
            Cashier_ChangeOr.Text = "0.00";
            // 
            // Cashier_Total_PriceOr
            // 
            Cashier_Total_PriceOr.AutoSize = true;
            Cashier_Total_PriceOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_Total_PriceOr.Location = new Point(116, 294);
            Cashier_Total_PriceOr.Name = "Cashier_Total_PriceOr";
            Cashier_Total_PriceOr.Size = new Size(31, 15);
            Cashier_Total_PriceOr.TabIndex = 17;
            Cashier_Total_PriceOr.Text = "0.00";
            // 
            // Cashier_ReceiptOr
            // 
            Cashier_ReceiptOr.BackColor = Color.Teal;
            Cashier_ReceiptOr.FlatStyle = FlatStyle.Flat;
            Cashier_ReceiptOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_ReceiptOr.ForeColor = Color.White;
            Cashier_ReceiptOr.Location = new Point(26, 464);
            Cashier_ReceiptOr.Margin = new Padding(3, 2, 3, 2);
            Cashier_ReceiptOr.Name = "Cashier_ReceiptOr";
            Cashier_ReceiptOr.Size = new Size(247, 32);
            Cashier_ReceiptOr.TabIndex = 16;
            Cashier_ReceiptOr.Text = "Receipt";
            Cashier_ReceiptOr.UseVisualStyleBackColor = false;
            this.Cashier_ReceiptOr.Click += new System.EventHandler(this.Cashier_ReceiptOr_Click); // ADD THIS LINE
            // 
            // Cashier_Pay_OrdersOr
            // 
            Cashier_Pay_OrdersOr.BackColor = Color.Teal;
            Cashier_Pay_OrdersOr.FlatStyle = FlatStyle.Flat;
            Cashier_Pay_OrdersOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_Pay_OrdersOr.ForeColor = Color.White;
            Cashier_Pay_OrdersOr.Location = new Point(26, 410);
            Cashier_Pay_OrdersOr.Margin = new Padding(3, 2, 3, 2);
            Cashier_Pay_OrdersOr.Name = "Cashier_Pay_OrdersOr";
            Cashier_Pay_OrdersOr.Size = new Size(247, 32);
            Cashier_Pay_OrdersOr.TabIndex = 15;
            Cashier_Pay_OrdersOr.Text = "Pay Orders";
            Cashier_Pay_OrdersOr.UseVisualStyleBackColor = false;
            this.Cashier_Pay_OrdersOr.Click += new System.EventHandler(this.Cashier_Pay_OrdersOr_Click); // ADD THIS LINE

            // 
            // Cashier_AmountOr
            // 
            Cashier_AmountOr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cashier_AmountOr.Location = new Point(116, 334);
            Cashier_AmountOr.Margin = new Padding(3, 2, 3, 2);
            Cashier_AmountOr.Name = "Cashier_AmountOr";
            Cashier_AmountOr.Size = new Size(157, 27);
            Cashier_AmountOr.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(54, 376);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 14;
            label11.Text = "Change:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 336);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 13;
            label10.Text = "Amount (₱):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 294);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 12;
            label9.Text = "Total Price (₱):";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 18);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(276, 245);
            dataGridView2.TabIndex = 12;
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(AppDbContext);
            // 
            // Cashier_PriceOr
            // 
            Cashier_PriceOr.AutoSize = true;
            Cashier_PriceOr.Location = new Point(125, 393);
            Cashier_PriceOr.Name = "Cashier_PriceOr";
            Cashier_PriceOr.Size = new Size(60, 15);
            Cashier_PriceOr.TabIndex = 11;
            Cashier_PriceOr.Text = "Category:";
            // 
            // Cashier_Product_NameOr
            // 
            Cashier_Product_NameOr.AutoSize = true;
            Cashier_Product_NameOr.Location = new Point(125, 344);
            Cashier_Product_NameOr.Name = "Cashier_Product_NameOr";
            Cashier_Product_NameOr.Size = new Size(60, 15);
            Cashier_Product_NameOr.TabIndex = 10;
            Cashier_Product_NameOr.Text = "Category:";
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CashierOrder";
            Size = new Size(938, 561);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Cashier_QuantityOr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private NumericUpDown Cashier_QuantityOr;
        private ComboBox Cashier_ProductIDOr;
        private ComboBox Cashier_CategoryOr;
        private Label label10;
        private Label label9;
        private DataGridView dataGridView2;
        private Button Remove_CashierOr;
        private Button Add_CashierOr;
        private TextBox Cashier_AmountOr;
        private Label label11;
        private Button Clear_CashierOr;
        private Button Cashier_ReceiptOr;
        private Button Cashier_Pay_OrdersOr;
        private Label Cashier_ChangeOr;
        private Label Cashier_Total_PriceOr;
        private BindingSource appDbContextBindingSource;
        private Label Cashier_PriceOr;
        private Label Cashier_Product_NameOr;
    }
}
