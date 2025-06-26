namespace POS_project
{
    partial class CA_Inventory
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
            label1 = new Label();
            ProductGridView = new DataGridView();
            invMainPanel = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            invMainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 317);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // ProductGridView
            // 
            ProductGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Dock = DockStyle.Fill;
            ProductGridView.Location = new Point(25, 19);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersVisible = false;
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(979, 582);
            ProductGridView.TabIndex = 3;
            // 
            // invMainPanel
            // 
            invMainPanel.BackColor = Color.Azure;
            invMainPanel.Controls.Add(ProductGridView);
            invMainPanel.Controls.Add(label1);
            invMainPanel.Dock = DockStyle.Fill;
            invMainPanel.Location = new Point(23, 93);
            invMainPanel.Name = "invMainPanel";
            invMainPanel.Size = new Size(1026, 624);
            invMainPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(271, 54);
            label2.TabIndex = 4;
            label2.Text = "Inventory Products";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(387, 12);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(199, 32);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(885, 18);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(133, 37);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.PowderBlue;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(invMainPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1072, 740);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 5);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.27273F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.0909081F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.636364F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(23, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1026, 64);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(285, 8);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(594, 48);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // CA_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableLayoutPanel1);
            Name = "CA_Inventory";
            Size = new Size(1072, 740);
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            invMainPanel.ResumeLayout(false);
            invMainPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView ProductGridView;
        private Panel invMainPanel;
        private Label label2;
        private TextBox txtSearch;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
