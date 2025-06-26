namespace POS_project
{
    partial class Reports
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
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new Panel();
            presetDateTime_comboBox = new ComboBox();
            panel7 = new Panel();
            productName_or_id_search = new TextBox();
            button5 = new Button();
            panel5 = new Panel();
            label4 = new Label();
            FilterFortheTable = new ComboBox();
            panel4 = new Panel();
            label2 = new Label();
            cashier_Username = new ComboBox();
            panel3 = new Panel();
            label10 = new Label();
            endTime_picker = new DateTimePicker();
            panel2 = new Panel();
            label3 = new Label();
            startTime_picker = new DateTimePicker();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 218);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(panel8, 0, 2);
            tableLayoutPanel3.Controls.Add(panel7, 1, 0);
            tableLayoutPanel3.Controls.Add(panel5, 1, 2);
            tableLayoutPanel3.Controls.Add(panel4, 1, 1);
            tableLayoutPanel3.Controls.Add(panel3, 0, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Controls.Add(button4, 3, 0);
            tableLayoutPanel3.Controls.Add(button7, 4, 1);
            tableLayoutPanel3.Controls.Add(button6, 3, 1);
            tableLayoutPanel3.Controls.Add(button3, 3, 2);
            tableLayoutPanel3.Controls.Add(button2, 4, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(20);
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(1066, 218);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // panel8
            // 
            panel8.Controls.Add(presetDateTime_comboBox);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(23, 141);
            panel8.Name = "panel8";
            panel8.Size = new Size(353, 54);
            panel8.TabIndex = 18;
            // 
            // presetDateTime_comboBox
            // 
            presetDateTime_comboBox.Font = new Font("Tahoma", 10.8F);
            presetDateTime_comboBox.FormattingEnabled = true;
            presetDateTime_comboBox.Items.AddRange(new object[] { "Today", "Yesterday", "Last 7 Days", "This Month", "Last Month", "Custom Range" });
            presetDateTime_comboBox.Location = new Point(105, 14);
            presetDateTime_comboBox.Margin = new Padding(3, 4, 3, 4);
            presetDateTime_comboBox.Name = "presetDateTime_comboBox";
            presetDateTime_comboBox.Size = new Size(233, 30);
            presetDateTime_comboBox.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(productName_or_id_search);
            panel7.Controls.Add(button5);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(382, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(353, 53);
            panel7.TabIndex = 22;
            // 
            // productName_or_id_search
            // 
            productName_or_id_search.Font = new Font("Tahoma", 10.8F);
            productName_or_id_search.Location = new Point(17, 18);
            productName_or_id_search.Margin = new Padding(3, 4, 3, 4);
            productName_or_id_search.Name = "productName_or_id_search";
            productName_or_id_search.Size = new Size(213, 29);
            productName_or_id_search.TabIndex = 15;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 9F);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(232, 18);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(118, 31);
            button5.TabIndex = 16;
            button5.Text = "SEARCH";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(FilterFortheTable);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(382, 141);
            panel5.Name = "panel5";
            panel5.Size = new Size(353, 54);
            panel5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label4.Location = new Point(17, 14);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 18;
            label4.Text = "Filter:";
            // 
            // FilterFortheTable
            // 
            FilterFortheTable.Font = new Font("Tahoma", 10.8F);
            FilterFortheTable.FormattingEnabled = true;
            FilterFortheTable.Items.AddRange(new object[] { "Today", "Yesterday", "Last 7 Days", "This Month", "Last Month", "Custom Range" });
            FilterFortheTable.Location = new Point(83, 14);
            FilterFortheTable.Margin = new Padding(3, 4, 3, 4);
            FilterFortheTable.Name = "FilterFortheTable";
            FilterFortheTable.Size = new Size(251, 30);
            FilterFortheTable.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cashier_Username);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(382, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 53);
            panel4.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label2.Location = new Point(1, 17);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 17;
            label2.Text = "Cashier:";
            // 
            // cashier_Username
            // 
            cashier_Username.Font = new Font("Tahoma", 10.8F);
            cashier_Username.FormattingEnabled = true;
            cashier_Username.Items.AddRange(new object[] { "Today", "Yesterday", "Last 7 Days", "This Month", "Last Month", "Custom Range" });
            cashier_Username.Location = new Point(92, 11);
            cashier_Username.Margin = new Padding(3, 4, 3, 4);
            cashier_Username.Name = "cashier_Username";
            cashier_Username.Size = new Size(251, 30);
            cashier_Username.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(endTime_picker);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(23, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 53);
            panel3.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label10.Location = new Point(3, 17);
            label10.Name = "label10";
            label10.Size = new Size(96, 22);
            label10.TabIndex = 8;
            label10.Text = "End time:";
            // 
            // endTime_picker
            // 
            endTime_picker.Font = new Font("Tahoma", 10.8F);
            endTime_picker.Location = new Point(105, 17);
            endTime_picker.Margin = new Padding(3, 4, 3, 4);
            endTime_picker.Name = "endTime_picker";
            endTime_picker.Size = new Size(228, 29);
            endTime_picker.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(startTime_picker);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(23, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 53);
            panel2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 7;
            label3.Text = "Start time:";
            label3.Click += label3_Click;
            // 
            // startTime_picker
            // 
            startTime_picker.Font = new Font("Tahoma", 10.8F);
            startTime_picker.Location = new Point(106, 20);
            startTime_picker.Margin = new Padding(3, 4, 3, 4);
            startTime_picker.Name = "startTime_picker";
            startTime_picker.Size = new Size(228, 29);
            startTime_picker.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(843, 24);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(96, 51);
            button4.TabIndex = 12;
            button4.Text = "CLEAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Green;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Tahoma", 9F);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(945, 83);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(98, 51);
            button7.TabIndex = 20;
            button7.Text = "EXPORT EXCEL";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 0, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 9F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(843, 83);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(96, 51);
            button6.TabIndex = 19;
            button6.Text = "REFRESH";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(843, 142);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(96, 52);
            button3.TabIndex = 11;
            button3.Text = "GENERATE REPORT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(945, 142);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(98, 52);
            button2.TabIndex = 10;
            button2.Text = "PRINT REPORT";
            button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(1072, 748);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(tableLayoutPanel2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 227);
            panel6.Name = "panel6";
            panel6.Size = new Size(1066, 518);
            panel6.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 94.73684F));
            tableLayoutPanel2.Size = new Size(1066, 518);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(1020, 25);
            label1.TabIndex = 1;
            label1.Text = "All Today's Customer";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(23, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1020, 447);
            dataGridView1.TabIndex = 0;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tableLayoutPanel1);
            Name = "Reports";
            Size = new Size(1072, 748);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private Label label3;
        private DateTimePicker endTime_picker;
        private DateTimePicker startTime_picker;
        private Button button3;
        private Button button2;
        private ComboBox presetDateTime_comboBox;
        private Button button4;
        private ComboBox cashier_Username;
        private ComboBox FilterFortheTable;
        private Button button7;
        private Button button6;
        private Label label4;
        private Label label2;
        private Button button5;
        private TextBox productName_or_id_search;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private Label label1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel8;
    }
}
