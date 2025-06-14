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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            invSidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // invMainPanel
            // 
            invMainPanel.BackColor = Color.FromArgb(235, 226, 216);
            invMainPanel.Controls.Add(dataGridView1);
            invMainPanel.Controls.Add(addproductBtn);
            invMainPanel.Controls.Add(label1);
            invMainPanel.Controls.Add(invSidebarPanel);
            invMainPanel.Location = new Point(-1, 0);
            invMainPanel.Name = "invMainPanel";
            invMainPanel.Size = new Size(1374, 753);
            invMainPanel.TabIndex = 0;
            invMainPanel.Paint += invMainPanel_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productNamecol, categoryCol, quantityCol, statusCol, addstockCol, deleteCol });
            dataGridView1.Location = new Point(383, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(928, 481);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            addproductBtn.Location = new Point(393, 65);
            addproductBtn.Name = "addproductBtn";
            addproductBtn.Size = new Size(192, 37);
            addproductBtn.TabIndex = 2;
            addproductBtn.Text = "ADD PRODUCT";
            addproductBtn.UseVisualStyleBackColor = true;
            addproductBtn.Click += addproductBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 317);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
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
            invSidebarPanel.Name = "invSidebarPanel";
            invSidebarPanel.Size = new Size(318, 742);
            invSidebarPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.FromArgb(235, 226, 216);
            logoutBtn.Location = new Point(10, 469);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(295, 48);
            logoutBtn.TabIndex = 6;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += button6_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            employeeBtn.ForeColor = Color.FromArgb(235, 226, 216);
            employeeBtn.Location = new Point(10, 415);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(295, 48);
            employeeBtn.TabIndex = 5;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = true;
            // 
            // reportsBtn
            // 
            reportsBtn.FlatStyle = FlatStyle.Flat;
            reportsBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            reportsBtn.ForeColor = Color.FromArgb(235, 226, 216);
            reportsBtn.Location = new Point(10, 363);
            reportsBtn.Name = "reportsBtn";
            reportsBtn.Size = new Size(295, 46);
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
            inventoryBtn.Location = new Point(10, 311);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Size = new Size(295, 46);
            inventoryBtn.TabIndex = 3;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.UseVisualStyleBackColor = false;
            // 
            // sTerminalBtn
            // 
            sTerminalBtn.FlatStyle = FlatStyle.Flat;
            sTerminalBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            sTerminalBtn.ForeColor = Color.FromArgb(235, 226, 216);
            sTerminalBtn.Location = new Point(10, 259);
            sTerminalBtn.Name = "sTerminalBtn";
            sTerminalBtn.Size = new Size(295, 46);
            sTerminalBtn.TabIndex = 2;
            sTerminalBtn.Text = "Sales Terminal";
            sTerminalBtn.UseVisualStyleBackColor = true;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dashboardBtn.ForeColor = Color.FromArgb(235, 226, 216);
            dashboardBtn.Location = new Point(10, 207);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(295, 46);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "DASHBOARD";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // invSidebarLbl
            // 
            invSidebarLbl.AutoSize = true;
            invSidebarLbl.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold);
            invSidebarLbl.ForeColor = Color.FromArgb(235, 226, 216);
            invSidebarLbl.Location = new Point(44, 63);
            invSidebarLbl.Name = "invSidebarLbl";
            invSidebarLbl.Size = new Size(228, 70);
            invSidebarLbl.TabIndex = 0;
            invSidebarLbl.Text = "INVENTORY \r\nPAGE";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 740);
            Controls.Add(invMainPanel);
            Name = "Inventory";
            Text = "Inventory";
            invMainPanel.ResumeLayout(false);
            invMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productNamecol;
        private DataGridViewTextBoxColumn categoryCol;
        private DataGridViewTextBoxColumn quantityCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewTextBoxColumn addstockCol;
        private DataGridViewTextBoxColumn deleteCol;
    }
}

        