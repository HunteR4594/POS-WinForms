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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(561, 134);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 9;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
            // 
            // Sign_up
            // 
            Sign_up.Location = new Point(644, 378);
            Sign_up.Name = "Sign_up";
            Sign_up.Size = new Size(94, 29);
            Sign_up.TabIndex = 8;
            Sign_up.Text = "Sign Up";
            Sign_up.UseVisualStyleBackColor = true;
            Sign_up.Click += Sign_up_Click;
            // 
            // password_register
            // 
            password_register.Location = new Point(561, 231);
            password_register.Name = "password_register";
            password_register.Size = new Size(248, 27);
            password_register.TabIndex = 7;
            // 
            // username_register
            // 
            username_register.Location = new Point(561, 181);
            username_register.Name = "username_register";
            username_register.Size = new Size(248, 27);
            username_register.TabIndex = 6;
            username_register.TextChanged += username_register_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 655);
            panel1.TabIndex = 5;
            // 
            // cpassword_register
            // 
            cpassword_register.Location = new Point(561, 281);
            cpassword_register.Name = "cpassword_register";
            cpassword_register.Size = new Size(248, 27);
            cpassword_register.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(956, 9);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 11;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 325);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 12;
            label2.Text = "Sign Up";
            label2.Click += label2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 655);
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
    }
}