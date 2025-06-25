using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_Gabayno
{
    public partial class Inventory : Form
    
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
            invMainPanel = new Panel();
            ProductGridView = new DataGridView();
            productNamecol = new DataGridViewTextBoxColumn();
            categoryCol = new DataGridViewTextBoxColumn();
            quantityCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            addstockCol = new DataGridViewTextBoxColumn();
            deleteCol = new DataGridViewTextBoxColumn();
            addproductBtn = new Button();
            label1 = new Label();
            invSidebarPanel = new Panel();
            logoutBtn = new Button();
            employeeBtn = new Button();
            reportsBtn = new Button();
            inventoryBtn = new Button();
            sTerminalBtn = new Button();
            dashboardBtn = new Button();
            invSidebarLbl = new Label();
            invMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            invSidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // invMainPanel
            // 
            invMainPanel.BackColor = Color.FromArgb(235, 226, 216);
            invMainPanel.Controls.Add(ProductGridView);
            invMainPanel.Controls.Add(addproductBtn);
            invMainPanel.Controls.Add(label1);
            invMainPanel.Controls.Add(invSidebarPanel);
            invMainPanel.Location = new Point(-1, 0);
            invMainPanel.Margin = new Padding(3, 2, 3, 2);
            invMainPanel.Name = "invMainPanel";
            invMainPanel.Size = new Size(1202, 565);
            invMainPanel.TabIndex = 0;
            // 
            // ProductGridView
            // 
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Columns.AddRange(new DataGridViewColumn[] { productNamecol, categoryCol, quantityCol, statusCol, addstockCol, deleteCol });
            ProductGridView.Location = new Point(335, 104);
            ProductGridView.Margin = new Padding(3, 2, 3, 2);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(812, 361);
            ProductGridView.TabIndex = 3;
            // 
            // productNamecol
            // 
            productNamecol.HeaderText = "Product Name";
            productNamecol.MinimumWidth = 6;
            productNamecol.Name = "productNamecol";
            productNamecol.Width = 200;
            // 
            // categoryCol
            // 
            categoryCol.HeaderText = "Category";
            categoryCol.MinimumWidth = 6;
            categoryCol.Name = "categoryCol";
            categoryCol.Width = 150;
            // 
            // quantityCol
            // 
            quantityCol.HeaderText = "Quantity";
            quantityCol.MinimumWidth = 6;
            quantityCol.Name = "quantityCol";
            quantityCol.ReadOnly = true;
            quantityCol.Width = 125;
            // 
            // statusCol
            // 
            statusCol.HeaderText = "Status";
            statusCol.MinimumWidth = 6;
            statusCol.Name = "statusCol";
            statusCol.ReadOnly = true;
            statusCol.Width = 150;
            // 
            // addstockCol
            // 
            addstockCol.HeaderText = "Add Stock";
            addstockCol.MinimumWidth = 6;
            addstockCol.Name = "addstockCol";
            addstockCol.ReadOnly = true;
            addstockCol.Width = 125;
            // 
            // deleteCol
            // 
            deleteCol.HeaderText = "Delete Product";
            deleteCol.MinimumWidth = 6;
            deleteCol.Name = "deleteCol";
            deleteCol.ReadOnly = true;
            deleteCol.Width = 150;
            // 
            // addproductBtn
            // 
            addproductBtn.FlatStyle = FlatStyle.Flat;
            addproductBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            addproductBtn.ForeColor = Color.FromArgb(139, 85, 53);
            addproductBtn.Location = new Point(344, 49);
            addproductBtn.Margin = new Padding(3, 2, 3, 2);
            addproductBtn.Name = "addproductBtn";
            addproductBtn.Size = new Size(168, 28);
            addproductBtn.TabIndex = 2;
            addproductBtn.Text = "ADD PRODUCT";
            addproductBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 238);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // invSidebarPanel
            // 
            invSidebarPanel.BackColor = Color.FromArgb(139, 85, 53);
            invSidebarPanel.Controls.Add(logoutBtn);
            invSidebarPanel.Controls.Add(employeeBtn);
            invSidebarPanel.Controls.Add(reportsBtn);
            invSidebarPanel.Controls.Add(inventoryBtn);
            invSidebarPanel.Controls.Add(sTerminalBtn);
            invSidebarPanel.Controls.Add(dashboardBtn);
            invSidebarPanel.Controls.Add(invSidebarLbl);
            invSidebarPanel.Location = new Point(3, 0);
            invSidebarPanel.Margin = new Padding(3, 2, 3, 2);
            invSidebarPanel.Name = "invSidebarPanel";
            invSidebarPanel.Size = new Size(278, 556);
            invSidebarPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.FromArgb(235, 226, 216);
            logoutBtn.Location = new Point(9, 352);
            logoutBtn.Margin = new Padding(3, 2, 3, 2);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(258, 36);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // employeeBtn
            // 
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            employeeBtn.ForeColor = Color.FromArgb(235, 226, 216);
            employeeBtn.Location = new Point(9, 311);
            employeeBtn.Margin = new Padding(3, 2, 3, 2);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(258, 36);
            employeeBtn.TabIndex = 5;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = true;
            // 
            // reportsBtn
            // 
            reportsBtn.FlatStyle = FlatStyle.Flat;
            reportsBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            reportsBtn.ForeColor = Color.FromArgb(235, 226, 216);
            reportsBtn.Location = new Point(9, 272);
            reportsBtn.Margin = new Padding(3, 2, 3, 2);
            reportsBtn.Name = "reportsBtn";
            reportsBtn.Size = new Size(258, 34);
            reportsBtn.TabIndex = 4;
            reportsBtn.Text = "Reports";
            reportsBtn.UseVisualStyleBackColor = true;
            // 
            // inventoryBtn
            // 
            inventoryBtn.BackColor = Color.FromArgb(235, 226, 216);
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            inventoryBtn.ForeColor = Color.FromArgb(139, 85, 53);
            inventoryBtn.Location = new Point(9, 233);
            inventoryBtn.Margin = new Padding(3, 2, 3, 2);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new Size(258, 34);
            inventoryBtn.TabIndex = 3;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.UseVisualStyleBackColor = false;
            // 
            // sTerminalBtn
            // 
            sTerminalBtn.FlatStyle = FlatStyle.Flat;
            sTerminalBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            sTerminalBtn.ForeColor = Color.FromArgb(235, 226, 216);
            sTerminalBtn.Location = new Point(9, 194);
            sTerminalBtn.Margin = new Padding(3, 2, 3, 2);
            sTerminalBtn.Name = "sTerminalBtn";
            sTerminalBtn.Size = new Size(258, 34);
            sTerminalBtn.TabIndex = 2;
            sTerminalBtn.Text = "Sales Terminal";
            sTerminalBtn.UseVisualStyleBackColor = true;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dashboardBtn.ForeColor = Color.FromArgb(235, 226, 216);
            dashboardBtn.Location = new Point(9, 155);
            dashboardBtn.Margin = new Padding(3, 2, 3, 2);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(258, 34);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "DASHBOARD";
            dashboardBtn.UseVisualStyleBackColor = true;
            // 
            // invSidebarLbl
            // 
            invSidebarLbl.AutoSize = true;
            invSidebarLbl.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold);
            invSidebarLbl.ForeColor = Color.FromArgb(235, 226, 216);
            invSidebarLbl.Location = new Point(38, 47);
            invSidebarLbl.Name = "invSidebarLbl";
            invSidebarLbl.Size = new Size(190, 58);
            invSidebarLbl.TabIndex = 0;
            invSidebarLbl.Text = "INVENTORY \r\nPAGE";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 555);
            Controls.Add(invMainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventory";
            Text = "Inventory";
            invMainPanel.ResumeLayout(false);
            invMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            invSidebarPanel.ResumeLayout(false);
            invSidebarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel invMainPanel;
        private Panel invSidebarPanel;
        private Label invSidebarLbl;
        private Label label1;
        private Button logoutBtn;
        private Button employeeBtn;
        private Button reportsBtn;
        private Button inventoryBtn;
        private Button sTerminalBtn;
        private Button dashboardBtn;
        private Button addproductBtn;
        private DataGridView ProductGridView;
        private DataGridViewTextBoxColumn productNamecol;
        private DataGridViewTextBoxColumn categoryCol;
        private DataGridViewTextBoxColumn quantityCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewTextBoxColumn addstockCol;
        private DataGridViewTextBoxColumn deleteCol;
    }
}

        