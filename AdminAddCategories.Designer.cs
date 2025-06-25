namespace POS_project
{
    partial class AdminAddCategories
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Add_Cat = new TextBox();
            Clear_Category = new Button();
            Remove_Category = new Button();
            Update_Category = new Button();
            Add_Category = new Button();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 216, 216);
            panel1.Controls.Add(Add_Cat);
            panel1.Controls.Add(Clear_Category);
            panel1.Controls.Add(Remove_Category);
            panel1.Controls.Add(Update_Category);
            panel1.Controls.Add(Add_Category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 18);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 525);
            panel1.TabIndex = 4;
            // 
            // Add_Cat
            // 
            Add_Cat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Cat.Location = new Point(29, 69);
            Add_Cat.Margin = new Padding(3, 2, 3, 2);
            Add_Cat.Name = "Add_Cat";
            Add_Cat.Size = new Size(224, 27);
            Add_Cat.TabIndex = 12;
            // 
            // Clear_Category
            // 
            Clear_Category.BackColor = Color.Goldenrod;
            Clear_Category.FlatStyle = FlatStyle.Popup;
            Clear_Category.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            Clear_Category.ForeColor = SystemColors.ButtonFace;
            Clear_Category.Location = new Point(151, 174);
            Clear_Category.Margin = new Padding(3, 2, 3, 2);
            Clear_Category.Name = "Clear_Category";
            Clear_Category.Size = new Size(102, 31);
            Clear_Category.TabIndex = 11;
            Clear_Category.Text = "Clear";
            Clear_Category.UseVisualStyleBackColor = false;
            Clear_Category.Click += Clear_Category_Click;
            // 
            // Remove_Category
            // 
            Remove_Category.BackColor = Color.Maroon;
            Remove_Category.FlatStyle = FlatStyle.Popup;
            Remove_Category.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            Remove_Category.ForeColor = SystemColors.ButtonFace;
            Remove_Category.Location = new Point(33, 174);
            Remove_Category.Margin = new Padding(3, 2, 3, 2);
            Remove_Category.Name = "Remove_Category";
            Remove_Category.Size = new Size(102, 31);
            Remove_Category.TabIndex = 10;
            Remove_Category.Text = "Remove";
            Remove_Category.UseVisualStyleBackColor = false;
            Remove_Category.Click += Remove_Category_Click;
            // 
            // Update_Category
            // 
            Update_Category.BackColor = Color.ForestGreen;
            Update_Category.FlatStyle = FlatStyle.Popup;
            Update_Category.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            Update_Category.ForeColor = SystemColors.ButtonFace;
            Update_Category.Location = new Point(151, 120);
            Update_Category.Margin = new Padding(3, 2, 3, 2);
            Update_Category.Name = "Update_Category";
            Update_Category.Size = new Size(102, 31);
            Update_Category.TabIndex = 9;
            Update_Category.Text = "Update";
            Update_Category.UseVisualStyleBackColor = false;
            Update_Category.Click += Update_Category_Click;
            // 
            // Add_Category
            // 
            Add_Category.BackColor = Color.Teal;
            Add_Category.FlatStyle = FlatStyle.Popup;
            Add_Category.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold);
            Add_Category.ForeColor = SystemColors.ButtonFace;
            Add_Category.Location = new Point(33, 120);
            Add_Category.Margin = new Padding(3, 2, 3, 2);
            Add_Category.Name = "Add_Category";
            Add_Category.Size = new Size(102, 31);
            Add_Category.TabIndex = 8;
            Add_Category.Text = "Add";
            Add_Category.UseVisualStyleBackColor = false;
            Add_Category.Click += Add_Category_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold);
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 216, 216);
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(339, 18);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 525);
            panel2.TabIndex = 5;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.Teal;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(24, 45);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(526, 461);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            label5.Location = new Point(24, 14);
            label5.Name = "label5";
            label5.Size = new Size(122, 19);
            label5.TabIndex = 0;
            label5.Text = "All Categories";
            // 
            // AdminAddCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 178, 178);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminAddCategories";
            Size = new Size(938, 561);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Clear_Category;
        private Button Remove_Category;
        private Button Update_Category;
        private Button Add_Category;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView;
        private Label label5;
        private TextBox Add_Cat;
    }
}
