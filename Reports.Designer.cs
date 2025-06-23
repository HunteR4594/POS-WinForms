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
            panel1 = new Panel();
            cashier_Username = new ComboBox();
            FilterFortheTable = new ComboBox();
            presetDateTime_comboBox = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            label3 = new Label();
            endTime_picker = new DateTimePicker();
            startTime_picker = new DateTimePicker();
            panel6 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            productName_or_id_search = new TextBox();
            button5 = new Button();
            label2 = new Label();
            label4 = new Label();
            button6 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(productName_or_id_search);
            panel1.Controls.Add(cashier_Username);
            panel1.Controls.Add(FilterFortheTable);
            panel1.Controls.Add(presetDateTime_comboBox);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(endTime_picker);
            panel1.Controls.Add(startTime_picker);
            panel1.Location = new Point(14, 30);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 148);
            panel1.TabIndex = 0;
            // 
            // cashier_Username
            // 
            cashier_Username.FormattingEnabled = true;
            cashier_Username.Items.AddRange(new object[] { "Today", "Yesterday", "Last 7 Days", "This Month", "Last Month", "Custom Range" });
            cashier_Username.Location = new Point(234, 61);
            cashier_Username.Name = "cashier_Username";
            cashier_Username.Size = new Size(240, 23);
            cashier_Username.TabIndex = 14;
            // 
            // FilterFortheTable
            // 
            FilterFortheTable.FormattingEnabled = true;
            FilterFortheTable.Items.AddRange(new object[] { "Today", "Yesterday", "Last 7 Days", "This Month", "Last Month", "Custom Range" });
            FilterFortheTable.Location = new Point(234, 108);
            FilterFortheTable.Name = "FilterFortheTable";
            FilterFortheTable.Size = new Size(240, 23);
            FilterFortheTable.TabIndex = 13;
            // 
            // presetDateTime_comboBox
            // 
            presetDateTime_comboBox.FormattingEnabled = true;
            presetDateTime_comboBox.Items.AddRange(new object[] { "Today", "Yesterday", "Last 7 Days", "This Month", "Last Month", "Custom Range" });
            presetDateTime_comboBox.Location = new Point(16, 108);
            presetDateTime_comboBox.Name = "presetDateTime_comboBox";
            presetDateTime_comboBox.Size = new Size(99, 23);
            presetDateTime_comboBox.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(642, 14);
            button4.Name = "button4";
            button4.Size = new Size(118, 39);
            button4.TabIndex = 12;
            button4.Text = "CLEAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(642, 92);
            button3.Name = "button3";
            button3.Size = new Size(118, 39);
            button3.TabIndex = 11;
            button3.Text = "GENERATE REPORT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(766, 92);
            button2.Name = "button2";
            button2.Size = new Size(113, 39);
            button2.TabIndex = 10;
            button2.Text = "PRINT REPORT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(766, 14);
            button1.Name = "button1";
            button1.Size = new Size(113, 39);
            button1.TabIndex = 9;
            button1.Text = "EXPORT CSV";
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 61);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 8;
            label10.Text = "End time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 12);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "start time:";
            // 
            // endTime_picker
            // 
            endTime_picker.Location = new Point(16, 79);
            endTime_picker.Name = "endTime_picker";
            endTime_picker.Size = new Size(200, 23);
            endTime_picker.TabIndex = 5;
            // 
            // startTime_picker
            // 
            startTime_picker.Location = new Point(16, 30);
            startTime_picker.Name = "startTime_picker";
            startTime_picker.Size = new Size(200, 23);
            startTime_picker.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(14, 194);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(910, 351);
            panel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 1;
            label1.Text = "All Today's Customer";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 33);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(878, 299);
            dataGridView1.TabIndex = 0;
            // 
            // productName_or_id_search
            // 
            productName_or_id_search.Location = new Point(234, 12);
            productName_or_id_search.Name = "productName_or_id_search";
            productName_or_id_search.Size = new Size(240, 23);
            productName_or_id_search.TabIndex = 15;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(480, 12);
            button5.Name = "button5";
            button5.Size = new Size(103, 23);
            button5.TabIndex = 16;
            button5.Text = "SEARCH";
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 43);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 17;
            label2.Text = "Cashier:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 90);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 18;
            label4.Text = "Filter:";
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(642, 52);
            button6.Name = "button6";
            button6.Size = new Size(118, 39);
            button6.TabIndex = 19;
            button6.Text = "REFRESH";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(766, 52);
            button7.Name = "button7";
            button7.Size = new Size(113, 39);
            button7.TabIndex = 20;
            button7.Text = "EXPORT EXCEL";
            button7.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel6);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reports";
            Size = new Size(938, 561);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label10;
        private Label label3;
        private DateTimePicker endTime_picker;
        private DateTimePicker startTime_picker;
        private Button button3;
        private Button button2;
        private Button button1;
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
    }
}
