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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            status_user = new ComboBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            add_username = new TextBox();
            label1 = new Label();
            label3 = new Label();
            add_password = new TextBox();
            Role_user = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            Add_user = new Button();
            Clear_user = new Button();
            Update_user = new Button();
            Remove_user = new Button();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            dataGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // status_user
            // 
            status_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            status_user.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status_user.FormattingEnabled = true;
            status_user.Items.AddRange(new object[] { "Active ", "Inactive", "Pending" });
            status_user.Location = new Point(37, 319);
            status_user.Name = "status_user";
            status_user.Size = new Size(232, 33);
            status_user.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 742);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(315, 742);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(add_username);
            panel3.Controls.Add(status_user);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(add_password);
            panel3.Controls.Add(Role_user);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 365);
            panel3.TabIndex = 12;
            // 
            // add_username
            // 
            add_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            add_username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_username.Location = new Point(37, 49);
            add_username.Name = "add_username";
            add_username.Size = new Size(230, 31);
            add_username.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(35, 198);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // add_password
            // 
            add_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            add_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_password.Location = new Point(37, 136);
            add_password.Name = "add_password";
            add_password.Size = new Size(230, 31);
            add_password.TabIndex = 2;
            // 
            // Role_user
            // 
            Role_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Role_user.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role_user.FormattingEnabled = true;
            Role_user.Items.AddRange(new object[] { "Admin", "Cashier" });
            Role_user.Location = new Point(35, 226);
            Role_user.Name = "Role_user";
            Role_user.Size = new Size(232, 33);
            Role_user.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(37, 291);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Status";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(35, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 10);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(Add_user, 0, 0);
            tableLayoutPanel3.Controls.Add(Clear_user, 1, 1);
            tableLayoutPanel3.Controls.Add(Update_user, 1, 0);
            tableLayoutPanel3.Controls.Add(Remove_user, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 374);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(10);
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2465754F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2465754F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71.50685F));
            tableLayoutPanel3.Size = new Size(309, 365);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // Add_user
            // 
            Add_user.BackColor = Color.FromArgb(0, 192, 0);
            Add_user.Dock = DockStyle.Top;
            Add_user.FlatStyle = FlatStyle.Flat;
            Add_user.ForeColor = Color.White;
            Add_user.Location = new Point(13, 13);
            Add_user.Name = "Add_user";
            Add_user.Size = new Size(138, 41);
            Add_user.TabIndex = 8;
            Add_user.Text = "Add";
            Add_user.UseVisualStyleBackColor = false;
            Add_user.Click += Add_user_Click;
            // 
            // Clear_user
            // 
            Clear_user.BackColor = Color.Teal;
            Clear_user.Dock = DockStyle.Top;
            Clear_user.FlatStyle = FlatStyle.Flat;
            Clear_user.ForeColor = Color.White;
            Clear_user.Location = new Point(157, 62);
            Clear_user.Name = "Clear_user";
            Clear_user.Size = new Size(139, 41);
            Clear_user.TabIndex = 11;
            Clear_user.Text = "Clear";
            Clear_user.UseVisualStyleBackColor = false;
            Clear_user.Click += Clear_user_Click;
            // 
            // Update_user
            // 
            Update_user.BackColor = Color.Navy;
            Update_user.Dock = DockStyle.Top;
            Update_user.FlatStyle = FlatStyle.Flat;
            Update_user.ForeColor = Color.White;
            Update_user.Location = new Point(157, 13);
            Update_user.Name = "Update_user";
            Update_user.Size = new Size(139, 41);
            Update_user.TabIndex = 9;
            Update_user.Text = "Update";
            Update_user.UseVisualStyleBackColor = false;
            Update_user.Click += Update_user_Click;
            // 
            // Remove_user
            // 
            Remove_user.BackColor = Color.Red;
            Remove_user.Dock = DockStyle.Top;
            Remove_user.FlatStyle = FlatStyle.Flat;
            Remove_user.ForeColor = Color.White;
            Remove_user.Location = new Point(13, 62);
            Remove_user.Name = "Remove_user";
            Remove_user.Size = new Size(138, 41);
            Remove_user.TabIndex = 10;
            Remove_user.Text = "Remove";
            Remove_user.UseVisualStyleBackColor = false;
            Remove_user.Click += Remove_user_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(324, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 742);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(dataGridView, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(20);
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.Size = new Size(745, 742);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 20);
            label5.Name = "label5";
            label5.Size = new Size(699, 70);
            label5.TabIndex = 0;
            label5.Text = "All User's Data";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(23, 93);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(699, 626);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += users_data_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1072, 748);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // AddminAddEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tableLayoutPanel1);
            Name = "AddminAddEmp";
            Size = new Size(1072, 748);
            Load += AddminAddEmp_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
