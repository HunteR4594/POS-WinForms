using Grpc.Core;

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
            label1 = new Label();
            ProductGridView = new DataGridView();
            invMainPanel = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            invMainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 238);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // ProductGridView
            // 
            ProductGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Location = new Point(22, 14);
            ProductGridView.Margin = new Padding(3, 2, 3, 2);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(848, 425);
            ProductGridView.TabIndex = 3;
            // 
            // invMainPanel
            // 
            invMainPanel.BackColor = Color.White;
            invMainPanel.Controls.Add(ProductGridView);
            invMainPanel.Controls.Add(label1);
            invMainPanel.Location = new Point(25, 78);
            invMainPanel.Margin = new Padding(3, 2, 3, 2);
            invMainPanel.Name = "invMainPanel";
            invMainPanel.Size = new Size(889, 457);
            invMainPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 24);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 4;
            label2.Text = "Inventory Products";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(628, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.White;
            button1.Location = new Point(835, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // CA_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(invMainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CA_Inventory";
            Size = new Size(938, 555);
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            invMainPanel.ResumeLayout(false);
            invMainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ProductGridView;
        private Panel invMainPanel;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}
