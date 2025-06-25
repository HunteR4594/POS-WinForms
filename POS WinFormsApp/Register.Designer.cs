namespace POS_project
{
    partial class Register
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
            label1 = new Label();
            Sign_up = new Button();
            password_register = new TextBox();
            username_register = new TextBox();
            panel1 = new Panel();
            cpassword_register = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            showpassword = new CheckBox();
            email_register = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(601, 116);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 9;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
            // 
            // Sign_up
            // 
            Sign_up.Location = new Point(685, 519);
            Sign_up.Name = "Sign_up";
            Sign_up.Size = new Size(231, 42);
            Sign_up.TabIndex = 8;
            Sign_up.Text = "Sign Up";
            Sign_up.UseVisualStyleBackColor = true;
            Sign_up.Click += Sign_up_Click;
            // 
            // password_register
            // 
            password_register.Location = new Point(601, 348);
            password_register.Name = "password_register";
            password_register.PasswordChar = '*';
            password_register.Size = new Size(385, 27);
            password_register.TabIndex = 7;
            // 
            // username_register
            // 
            username_register.Location = new Point(602, 283);
            username_register.Name = "username_register";
            username_register.Size = new Size(385, 27);
            username_register.TabIndex = 6;
            username_register.TextChanged += username_register_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 785);
            panel1.TabIndex = 5;
            // 
            // cpassword_register
            // 
            cpassword_register.Location = new Point(602, 437);
            cpassword_register.Name = "cpassword_register";
            cpassword_register.PasswordChar = '*';
            cpassword_register.Size = new Size(385, 27);
            cpassword_register.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1162, 9);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 11;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(926, 592);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 12;
            label2.Text = "Sign In";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 168);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 13;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 251);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(602, 414);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(738, 592);
            label7.Name = "label7";
            label7.Size = new Size(178, 20);
            label7.TabIndex = 16;
            label7.Text = "Already have an account?";
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Location = new Point(852, 470);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(134, 24);
            showpassword.TabIndex = 17;
            showpassword.Text = "Show password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // email_register
            // 
            email_register.Location = new Point(601, 204);
            email_register.Name = "email_register";
            email_register.Size = new Size(385, 27);
            email_register.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(602, 325);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 19;
            label8.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(853, 381);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 785);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(email_register);
            Controls.Add(showpassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cpassword_register);
            Controls.Add(label1);
            Controls.Add(Sign_up);
            Controls.Add(password_register);
            Controls.Add(username_register);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Sign_up;
        private TextBox password_register;
        private TextBox username_register;
        private Panel panel1;
        private TextBox cpassword_register;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox showpassword;
        private TextBox email_register;
        private Label label8;
        private CheckBox checkBox1;
    }
}