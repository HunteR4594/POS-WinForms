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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            status_user.Location = new Point(35, 360);
            status_user.Name = "status_user";
            status_user.Size = new Size(256, 33);
            status_user.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            panel1.Location = new Point(30, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 700);
            panel1.TabIndex = 2;
            // 
            // Clear_user
            // 
            Clear_user.BackColor = Color.Teal;
            Clear_user.FlatStyle = FlatStyle.Flat;
            Clear_user.ForeColor = Color.White;
            Clear_user.Location = new Point(173, 510);
            Clear_user.Name = "Clear_user";
            Clear_user.Size = new Size(116, 41);
            Clear_user.TabIndex = 11;
            Clear_user.Text = "Clear";
            Clear_user.UseVisualStyleBackColor = false;
            Clear_user.Click += Clear_user_Click;
            // 
            // Remove_user
            // 
            Remove_user.BackColor = Color.Teal;
            Remove_user.FlatStyle = FlatStyle.Flat;
            Remove_user.ForeColor = Color.White;
            Remove_user.Location = new Point(38, 510);
            Remove_user.Name = "Remove_user";
            Remove_user.Size = new Size(116, 41);
            Remove_user.TabIndex = 10;
            Remove_user.Text = "Remove";
            Remove_user.UseVisualStyleBackColor = false;
            Remove_user.Click += Remove_user_Click;
            // 
            // Update_user
            // 
            Update_user.BackColor = Color.Teal;
            Update_user.FlatStyle = FlatStyle.Flat;
            Update_user.ForeColor = Color.White;
            Update_user.Location = new Point(173, 438);
            Update_user.Name = "Update_user";
            Update_user.Size = new Size(116, 41);
            Update_user.TabIndex = 9;
            Update_user.Text = "Update";
            Update_user.UseVisualStyleBackColor = false;
            Update_user.Click += Update_user_Click;
            // 
            // Add_user
            // 
            Add_user.BackColor = Color.Teal;
            Add_user.FlatStyle = FlatStyle.Flat;
            Add_user.ForeColor = Color.White;
            Add_user.Location = new Point(38, 438);
            Add_user.Name = "Add_user";
            Add_user.Size = new Size(116, 41);
            Add_user.TabIndex = 8;
            Add_user.Text = "Add";
            Add_user.UseVisualStyleBackColor = false;
            Add_user.Click += Add_user_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 332);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 239);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // Role_user
            // 
            Role_user.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role_user.FormattingEnabled = true;
            Role_user.Items.AddRange(new object[] { "Admin", "Cashier" });
            Role_user.Location = new Point(33, 267);
            Role_user.Name = "Role_user";
            Role_user.Size = new Size(256, 33);
            Role_user.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 150);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // add_password
            // 
            add_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_password.Location = new Point(35, 177);
            add_password.Name = "add_password";
            add_password.Size = new Size(254, 31);
            add_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // add_username
            // 
            add_username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_username.Location = new Point(35, 90);
            add_username.Name = "add_username";
            add_username.Size = new Size(254, 31);
            add_username.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(387, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 700);
            panel2.TabIndex = 3;
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
            dataGridView.CellClick += users_data_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 19);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 0;
            label5.Text = "All User's Data";
            // 
            // AddminAddEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AddminAddEmp";
            Size = new Size(1072, 748);
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
