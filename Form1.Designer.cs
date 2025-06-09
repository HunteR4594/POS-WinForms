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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 655);
            panel1.TabIndex = 0;
            // 
            // username_login
            // 
            username_login.Location = new Point(570, 236);
            username_login.Name = "username_login";
            username_login.Size = new Size(248, 27);
            username_login.TabIndex = 1;
            // 
            // passwordlogin
            // 
            passwordlogin.Location = new Point(570, 284);
            passwordlogin.Name = "passwordlogin";
            passwordlogin.Size = new Size(248, 27);
            passwordlogin.TabIndex = 2;
            // 
            // Login
            // 
            Login.Location = new Point(657, 371);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 3;
            Login.Text = "Log In";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(554, 194);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 4;
            label1.Text = "Log In Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(708, 332);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 5;
            label2.Text = "Create Account";
            label2.Click += Label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(956, 9);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 332);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 655);
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
    }
}
