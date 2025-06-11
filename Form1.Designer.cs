namespace POS_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            username_login = new TextBox();
            passwordlogin = new TextBox();
            Login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            showpassword = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 785);
            panel1.TabIndex = 0;
            // 
            // username_login
            // 
            username_login.Location = new Point(602, 281);
            username_login.Name = "username_login";
            username_login.Size = new Size(385, 27);
            username_login.TabIndex = 1;
            // 
            // passwordlogin
            // 
            passwordlogin.Location = new Point(602, 349);
            passwordlogin.Name = "passwordlogin";
            passwordlogin.PasswordChar = '*';
            passwordlogin.Size = new Size(385, 27);
            passwordlogin.TabIndex = 2;
            // 
            // Login
            // 
            Login.BackColor = Color.Teal;
            Login.ForeColor = Color.White;
            Login.Location = new Point(710, 440);
            Login.Name = "Login";
            Login.Size = new Size(175, 47);
            Login.TabIndex = 3;
            Login.Text = "Log In";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(602, 196);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 4;
            label1.Text = "Log In Account";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(927, 503);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Sign Up";
            label2.Click += Label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1162, 9);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(667, 423);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Location = new Point(855, 391);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(132, 24);
            showpassword.TabIndex = 8;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 258);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 9;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(602, 326);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 10;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(761, 503);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 11;
            label7.Text = "Don't have an account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 785);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(showpassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(passwordlogin);
            Controls.Add(username_login);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox username_login;
        private TextBox passwordlogin;
        private Button Login;
        private Label label1;
        private Label label2;
        private Label label3;

        // Add this method to handle the Click event for label2
        private void Label2_Click(object sender, EventArgs e)
        {
            // Add your logic here for handling the "Create Account" click event
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide(); // Optionally hide the current form
        }
        private Label label4;
        private CheckBox showpassword;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
