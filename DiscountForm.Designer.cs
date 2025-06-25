namespace POS_project
{
    partial class DiscountForm
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
            rbCashDiscount = new RadioButton();
            rbPercentDiscount = new RadioButton();
            txtDiscountValue = new TextBox();
            lblDiscountValuePrompt = new Label();
            btnApplyDiscount = new Button();
            btnCancelDiscount = new Button();
            SuspendLayout();
            // 
            // rbCashDiscount
            // 
            rbCashDiscount.AutoSize = true;
            rbCashDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCashDiscount.Location = new Point(30, 30);
            rbCashDiscount.Name = "rbCashDiscount";
            rbCashDiscount.Size = new Size(102, 19);
            rbCashDiscount.TabIndex = 0;
            rbCashDiscount.TabStop = true;
            rbCashDiscount.Text = "Cash Discount";
            rbCashDiscount.UseVisualStyleBackColor = true;
            rbCashDiscount.CheckedChanged += rbCashDiscount_CheckedChanged;
            // 
            // rbPercentDiscount
            // 
            rbPercentDiscount.AutoSize = true;
            rbPercentDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPercentDiscount.Location = new Point(160, 30);
            rbPercentDiscount.Name = "rbPercentDiscount";
            rbPercentDiscount.Size = new Size(121, 19);
            rbPercentDiscount.TabIndex = 1;
            rbPercentDiscount.TabStop = true;
            rbPercentDiscount.Text = "Percent Discount";
            rbPercentDiscount.UseVisualStyleBackColor = true;
            rbPercentDiscount.CheckedChanged += rbPercentDiscount_CheckedChanged;
            // 
            // txtDiscountValue
            // 
            txtDiscountValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscountValue.Location = new Point(160, 70);
            txtDiscountValue.Name = "txtDiscountValue";
            txtDiscountValue.Size = new Size(100, 23);
            txtDiscountValue.TabIndex = 2;
            // 
            // lblDiscountValuePrompt
            // 
            lblDiscountValuePrompt.AutoSize = true;
            lblDiscountValuePrompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscountValuePrompt.Location = new Point(30, 73);
            lblDiscountValuePrompt.Name = "lblDiscountValuePrompt";
            lblDiscountValuePrompt.Size = new Size(92, 15);
            lblDiscountValuePrompt.TabIndex = 3;
            lblDiscountValuePrompt.Text = "Discount Value:";
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BackColor = Color.Teal;
            btnApplyDiscount.FlatStyle = FlatStyle.Flat;
            btnApplyDiscount.ForeColor = Color.White;
            btnApplyDiscount.Location = new Point(50, 120);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(90, 30);
            btnApplyDiscount.TabIndex = 4;
            btnApplyDiscount.Text = "Apply";
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // btnCancelDiscount
            // 
            btnCancelDiscount.BackColor = Color.Gray;
            btnCancelDiscount.FlatStyle = FlatStyle.Flat;
            btnCancelDiscount.ForeColor = Color.White;
            btnCancelDiscount.Location = new Point(170, 120);
            btnCancelDiscount.Name = "btnCancelDiscount";
            btnCancelDiscount.Size = new Size(90, 30);
            btnCancelDiscount.TabIndex = 5;
            btnCancelDiscount.Text = "Cancel";
            btnCancelDiscount.UseVisualStyleBackColor = false;
            btnCancelDiscount.Click += btnCancelDiscount_Click;
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(300, 170);
            Controls.Add(btnCancelDiscount);
            Controls.Add(btnApplyDiscount);
            Controls.Add(lblDiscountValuePrompt);
            Controls.Add(txtDiscountValue);
            Controls.Add(rbPercentDiscount);
            Controls.Add(rbCashDiscount);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiscountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Discount";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCashDiscount;
        private System.Windows.Forms.RadioButton rbPercentDiscount;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.Label lblDiscountValuePrompt;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Button btnCancelDiscount;
    }
}
