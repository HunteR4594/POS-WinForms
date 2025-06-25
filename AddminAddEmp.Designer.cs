namespace POS_project
{
    partial class AddminAddEmp
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            status_user = new ComboBox();
            panel1 = new Panel();
            Clear_user = new Button();
            Remove_user = new Button();
            Update_user = new Button();
            Add_user = new Button();
            label4 = new Label();
            label3 = new Label();
            Role_user = new ComboBox();
            label2 = new Label();
            add_password = new TextBox();
            label1 = new Label();
            add_username = new TextBox();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // status_user
            // 
            status_user.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status_user.FormattingEnabled = true;
            status_user.Items.AddRange(new object[] { "Active ", "Inactive", "Pending" });
            status_user.Location = new Point(31, 271);
            status_user.Margin = new Padding(3, 2, 3, 2);
            status_user.Name = "status_user";
            status_user.Size = new Size(224, 27);
            status_user.TabIndex = 6;
            status_user.SelectedIndexChanged += status_user_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 216, 216);
            panel1.Controls.Add(Clear_user);
            panel1.Controls.Add(Remove_user);
            panel1.Controls.Add(Update_user);
            panel1.Controls.Add(Add_user);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(status_user);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Role_user);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(add_password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(add_username);
            panel1.Location = new Point(26, 18);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 525);
            panel1.TabIndex = 2;
            // 
            // Clear_user
            // 
            Clear_user.BackColor = Color.Goldenrod;
            Clear_user.FlatStyle = FlatStyle.Popup;
            Clear_user.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear_user.ForeColor = SystemColors.ButtonFace;
            Clear_user.Location = new Point(151, 382);
            Clear_user.Margin = new Padding(3, 2, 3, 2);
            Clear_user.Name = "Clear_user";
            Clear_user.Size = new Size(102, 31);
            Clear_user.TabIndex = 11;
            Clear_user.Text = "Clear";
            Clear_user.UseVisualStyleBackColor = false;
            Clear_user.Click += Clear_user_Click;
            // 
            // Remove_user
            // 
            Remove_user.BackColor = Color.Maroon;
            Remove_user.BackgroundImageLayout = ImageLayout.None;
            Remove_user.FlatStyle = FlatStyle.Popup;
            Remove_user.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove_user.ForeColor = SystemColors.ButtonFace;
            Remove_user.Location = new Point(33, 382);
            Remove_user.Margin = new Padding(3, 2, 3, 2);
            Remove_user.Name = "Remove_user";
            Remove_user.Size = new Size(102, 31);
            Remove_user.TabIndex = 10;
            Remove_user.Text = "Remove";
            Remove_user.UseVisualStyleBackColor = false;
            Remove_user.Click += Remove_user_Click;
            // 
            // Update_user
            // 
            Update_user.BackColor = Color.ForestGreen;
            Update_user.FlatStyle = FlatStyle.Popup;
            Update_user.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_user.ForeColor = SystemColors.ButtonFace;
            Update_user.Location = new Point(151, 328);
            Update_user.Margin = new Padding(3, 2, 3, 2);
            Update_user.Name = "Update_user";
            Update_user.Size = new Size(102, 31);
            Update_user.TabIndex = 9;
            Update_user.Text = "Update";
            Update_user.UseVisualStyleBackColor = false;
            Update_user.Click += Update_user_Click;
            // 
            // Add_user
            // 
            Add_user.BackColor = Color.FromArgb(0, 76, 76);
            Add_user.FlatStyle = FlatStyle.Popup;
            Add_user.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_user.ForeColor = SystemColors.ButtonFace;
            Add_user.Location = new Point(33, 328);
            Add_user.Margin = new Padding(3, 2, 3, 2);
            Add_user.Name = "Add_user";
            Add_user.Size = new Size(102, 31);
            Add_user.TabIndex = 8;
            Add_user.Text = "Add";
            Add_user.UseVisualStyleBackColor = false;
            Add_user.Click += Add_user_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 249);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 179);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // Role_user
            // 
            Role_user.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role_user.FormattingEnabled = true;
            Role_user.Items.AddRange(new object[] { "Admin", "Cashier" });
            Role_user.Location = new Point(30, 201);
            Role_user.Margin = new Padding(3, 2, 3, 2);
            Role_user.Name = "Role_user";
            Role_user.Size = new Size(224, 27);
            Role_user.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // add_password
            // 
            add_password.BorderStyle = BorderStyle.FixedSingle;
            add_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_password.Location = new Point(31, 134);
            add_password.Margin = new Padding(3, 2, 3, 2);
            add_password.Name = "add_password";
            add_password.Size = new Size(223, 27);
            add_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // add_username
            // 
            add_username.BorderStyle = BorderStyle.FixedSingle;
            add_username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_username.Location = new Point(31, 69);
            add_username.Margin = new Padding(3, 2, 3, 2);
            add_username.Name = "add_username";
            add_username.Size = new Size(223, 27);
            add_username.TabIndex = 0;
            add_username.TextChanged += add_username_TextChanged;
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
            panel2.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.Teal;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(24, 45);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(526, 461);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += users_data_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 15);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 0;
            label5.Text = "All User's Data";
            // 
            // AddminAddEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 178, 178);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddminAddEmp";
            Size = new Size(938, 561);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox status_user;
        private Panel panel1;
        private Button Clear_user;
        private Button Remove_user;
        private Button Update_user;
        private Button Add_user;
        private Label label4;
        private Label label3;
        private ComboBox Role_user;
        private Label label2;
        private TextBox add_password;
        private Label label1;
        private TextBox add_username;
        private Panel panel2;
        private DataGridView dataGridView;
        private Label label5;
    }
}
