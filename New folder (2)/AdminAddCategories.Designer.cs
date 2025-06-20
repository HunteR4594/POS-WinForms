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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Add_Cat);
            panel1.Controls.Add(Clear_Category);
            panel1.Controls.Add(Remove_Category);
            panel1.Controls.Add(Update_Category);
            panel1.Controls.Add(Add_Category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 700);
            panel1.TabIndex = 4;
            // 
            // Add_Cat
            // 
            Add_Cat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Cat.Location = new Point(33, 95);
            Add_Cat.Name = "Add_Cat";
            Add_Cat.Size = new Size(256, 31);
            Add_Cat.TabIndex = 12;
            // 
            // Clear_Category
            // 
            Clear_Category.BackColor = Color.Teal;
            Clear_Category.FlatStyle = FlatStyle.Flat;
            Clear_Category.ForeColor = Color.White;
            Clear_Category.Location = new Point(173, 232);
            Clear_Category.Name = "Clear_Category";
            Clear_Category.Size = new Size(116, 41);
            Clear_Category.TabIndex = 11;
            Clear_Category.Text = "Clear";
            Clear_Category.UseVisualStyleBackColor = false;
            Clear_Category.Click += Clear_Category_Click;
            // 
            // Remove_Category
            // 
            Remove_Category.BackColor = Color.Teal;
            Remove_Category.FlatStyle = FlatStyle.Flat;
            Remove_Category.ForeColor = Color.White;
            Remove_Category.Location = new Point(38, 232);
            Remove_Category.Name = "Remove_Category";
            Remove_Category.Size = new Size(116, 41);
            Remove_Category.TabIndex = 10;
            Remove_Category.Text = "Remove";
            Remove_Category.UseVisualStyleBackColor = false;
            Remove_Category.Click += Remove_Category_Click;
            // 
            // Update_Category
            // 
            Update_Category.BackColor = Color.Teal;
            Update_Category.FlatStyle = FlatStyle.Flat;
            Update_Category.ForeColor = Color.White;
            Update_Category.Location = new Point(173, 160);
            Update_Category.Name = "Update_Category";
            Update_Category.Size = new Size(116, 41);
            Update_Category.TabIndex = 9;
            Update_Category.Text = "Update";
            Update_Category.UseVisualStyleBackColor = false;
            Update_Category.Click += Update_Category_Click;
            // 
            // Add_Category
            // 
            Add_Category.BackColor = Color.Teal;
            Add_Category.FlatStyle = FlatStyle.Flat;
            Add_Category.ForeColor = Color.White;
            Add_Category.Location = new Point(38, 160);
            Add_Category.Name = "Add_Category";
            Add_Category.Size = new Size(116, 41);
            Add_Category.TabIndex = 8;
            Add_Category.Text = "Add";
            Add_Category.UseVisualStyleBackColor = false;
            Add_Category.Click += Add_Category_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 63);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(387, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 700);
            panel2.TabIndex = 5;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(27, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(601, 615);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 19);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 0;
            label5.Text = "All Categories";
            // 
            // AdminAddCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminAddCategories";
            Size = new Size(1072, 748);
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
