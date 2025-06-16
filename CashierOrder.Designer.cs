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
            panel1 = new Panel();
            Clear_CashierOr = new Button();
            Remove_CashierOr = new Button();
            Add_CashierOr = new Button();
            Cashier_PriceOr = new Label();
            Cashier_Product_NameOr = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cashier_QuantityOr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel1.Location = new Point(27, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 692);
            panel1.TabIndex = 0;

            // 
            // Clear_CashierOr
            // 
            Clear_CashierOr.BackColor = Color.Teal;
            Clear_CashierOr.FlatStyle = FlatStyle.Flat;
            Clear_CashierOr.ForeColor = Color.White;
            Clear_CashierOr.Location = new Point(489, 598);
            Clear_CashierOr.Name = "Clear_CashierOr";
            Clear_CashierOr.Size = new Size(133, 43);
            Clear_CashierOr.TabIndex = 14;
            Clear_CashierOr.Text = "Clear";
            Clear_CashierOr.UseVisualStyleBackColor = false;
            // 
            // Remove_CashierOr
            // 
            Remove_CashierOr.BackColor = Color.Teal;
            Remove_CashierOr.FlatStyle = FlatStyle.Flat;
            Remove_CashierOr.ForeColor = Color.White;
            Remove_CashierOr.Location = new Point(227, 598);
            Remove_CashierOr.Name = "Remove_CashierOr";
            Remove_CashierOr.Size = new Size(133, 43);
            Remove_CashierOr.TabIndex = 13;
            Remove_CashierOr.Text = "Remove";
            Remove_CashierOr.UseVisualStyleBackColor = false;
            // 
            // Add_CashierOr
            // 
            Add_CashierOr.BackColor = Color.Teal;
            Add_CashierOr.FlatStyle = FlatStyle.Flat;
            Add_CashierOr.ForeColor = Color.White;
            Add_CashierOr.Location = new Point(51, 598);
            Add_CashierOr.Name = "Add_CashierOr";
            Add_CashierOr.Size = new Size(133, 43);
            Add_CashierOr.TabIndex = 12;
            Add_CashierOr.Text = "Add";
            Add_CashierOr.UseVisualStyleBackColor = false;
            // 
            // Cashier_PriceOr
            // 
            Cashier_PriceOr.AutoSize = true;
            Cashier_PriceOr.Location = new Point(143, 524);
            Cashier_PriceOr.Name = "Cashier_PriceOr";
            Cashier_PriceOr.Size = new Size(77, 20);
            Cashier_PriceOr.TabIndex = 11;
            Cashier_PriceOr.Text = "Category:";
            // 
            // Cashier_Product_NameOr
            // 
            Cashier_Product_NameOr.AutoSize = true;
            Cashier_Product_NameOr.Location = new Point(143, 459);
            Cashier_Product_NameOr.Name = "Cashier_Product_NameOr";
            Cashier_Product_NameOr.Size = new Size(77, 20);
            Cashier_Product_NameOr.TabIndex = 10;
            Cashier_Product_NameOr.Text = "Category:";
            // 
            // Cashier_QuantityOr
            // 
            Cashier_QuantityOr.Font = new Font("Segoe UI", 10.8F);
            Cashier_QuantityOr.Location = new Point(457, 448);
            Cashier_QuantityOr.Name = "Cashier_QuantityOr";
            Cashier_QuantityOr.Size = new Size(150, 31);
            Cashier_QuantityOr.TabIndex = 9;
            Cashier_QuantityOr.ValueChanged += Cashier_QuantityOr_ValueChanged;
            // 
            // Cashier_ProductIDOr
            // 
            Cashier_ProductIDOr.Font = new Font("Segoe UI", 10.8F);
            Cashier_ProductIDOr.FormattingEnabled = true;
            Cashier_ProductIDOr.Location = new Point(451, 385);
            Cashier_ProductIDOr.Name = "Cashier_ProductIDOr";
            Cashier_ProductIDOr.Size = new Size(182, 33);
            Cashier_ProductIDOr.TabIndex = 8;
            // 
            // Cashier_CategoryOr
            // 
            Cashier_CategoryOr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cashier_CategoryOr.FormattingEnabled = true;
            Cashier_CategoryOr.Location = new Point(143, 385);
            Cashier_CategoryOr.Name = "Cashier_CategoryOr";
            Cashier_CategoryOr.Size = new Size(182, 33);
            Cashier_CategoryOr.TabIndex = 7;
            Cashier_CategoryOr.SelectedIndexChanged += Cashier_CategoryOr_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 459);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 6;
            label6.Text = "Product Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 524);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 5;
            label5.Text = "Price (₱):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 454);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 392);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 392);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Category:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Available Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(619, 283);
            dataGridView1.TabIndex = 0;
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
            panel2.Location = new Point(704, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 692);
            panel2.TabIndex = 1;
            // 
            // Cashier_ChangeOr
            // 
            Cashier_ChangeOr.AutoSize = true;
            Cashier_ChangeOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_ChangeOr.Location = new Point(133, 502);
            Cashier_ChangeOr.Name = "Cashier_ChangeOr";
            Cashier_ChangeOr.Size = new Size(40, 20);
            Cashier_ChangeOr.TabIndex = 18;
            Cashier_ChangeOr.Text = "0.00";
            // 
            // Cashier_Total_PriceOr
            // 
            Cashier_Total_PriceOr.AutoSize = true;
            Cashier_Total_PriceOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_Total_PriceOr.Location = new Point(133, 392);
            Cashier_Total_PriceOr.Name = "Cashier_Total_PriceOr";
            Cashier_Total_PriceOr.Size = new Size(40, 20);
            Cashier_Total_PriceOr.TabIndex = 17;
            Cashier_Total_PriceOr.Text = "0.00";
            // 
            // Cashier_ReceiptOr
            // 
            Cashier_ReceiptOr.BackColor = Color.Teal;
            Cashier_ReceiptOr.FlatStyle = FlatStyle.Flat;
            Cashier_ReceiptOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_ReceiptOr.ForeColor = Color.White;
            Cashier_ReceiptOr.Location = new Point(30, 618);
            Cashier_ReceiptOr.Name = "Cashier_ReceiptOr";
            Cashier_ReceiptOr.Size = new Size(282, 43);
            Cashier_ReceiptOr.TabIndex = 16;
            Cashier_ReceiptOr.Text = "Receipt";
            Cashier_ReceiptOr.UseVisualStyleBackColor = false;
            // 
            // Cashier_Pay_OrdersOr
            // 
            Cashier_Pay_OrdersOr.BackColor = Color.Teal;
            Cashier_Pay_OrdersOr.FlatStyle = FlatStyle.Flat;
            Cashier_Pay_OrdersOr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_Pay_OrdersOr.ForeColor = Color.White;
            Cashier_Pay_OrdersOr.Location = new Point(30, 546);
            Cashier_Pay_OrdersOr.Name = "Cashier_Pay_OrdersOr";
            Cashier_Pay_OrdersOr.Size = new Size(282, 43);
            Cashier_Pay_OrdersOr.TabIndex = 15;
            Cashier_Pay_OrdersOr.Text = "Pay Orders";
            Cashier_Pay_OrdersOr.UseVisualStyleBackColor = false;
            // 
            // Cashier_AmountOr
            // 
            Cashier_AmountOr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cashier_AmountOr.Location = new Point(133, 445);
            Cashier_AmountOr.Name = "Cashier_AmountOr";
            Cashier_AmountOr.Size = new Size(179, 31);
            Cashier_AmountOr.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(62, 502);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 14;
            label11.Text = "Change:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 448);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 13;
            label10.Text = "Amount (₱):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 392);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 12;
            label9.Text = "Total Price (₱):";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 24);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(316, 327);
            dataGridView2.TabIndex = 12;
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(1072, 748);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Cashier_QuantityOr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label Cashier_PriceOr;
        private Label Cashier_Product_NameOr;
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
    }
}
