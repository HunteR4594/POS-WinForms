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
            label3 = new Label();
            label4 = new Label();
            showpassword = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 589);
            panel1.TabIndex = 0;
            // 
            // username_login
            // 
            username_login.Location = new Point(529, 255);
            username_login.Margin = new Padding(3, 2, 3, 2);
            username_login.Name = "username_login";
            username_login.Size = new Size(348, 23);
            username_login.TabIndex = 1;
            // 
            // passwordlogin
            // 
            passwordlogin.Location = new Point(527, 334);
            passwordlogin.Margin = new Padding(3, 2, 3, 2);
            passwordlogin.Name = "passwordlogin";
            passwordlogin.PasswordChar = '*';
            passwordlogin.Size = new Size(350, 23);
            passwordlogin.TabIndex = 2;
            // 
            // Login
            // 
            Login.BackColor = Color.Teal;
            Login.BackgroundImageLayout = ImageLayout.None;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(615, 432);
            Login.Margin = new Padding(3, 2, 3, 2);
            Login.Name = "Login";
            Login.Size = new Size(177, 49);
            Login.TabIndex = 3;
            Login.Text = "Log In";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(652, 175);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 4;
            label1.Text = "Log In Account";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1017, 7);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 317);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showpassword.Location = new Point(763, 372);
            showpassword.Margin = new Padding(3, 2, 3, 2);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(130, 24);
            showpassword.TabIndex = 8;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(527, 215);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 9;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(527, 296);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 10;
            label6.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(125, 349);
            label8.Name = "label8";
            label8.Size = new Size(161, 25);
            label8.TabIndex = 0;
            label8.Text = "Developed By:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(107, 388);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 1;
            label9.Text = "Re-as | Villacarlos | Serafin ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(134, 418);
            label10.Name = "label10";
            label10.Size = new Size(137, 21);
            label10.TabIndex = 2;
            label10.Text = "Gabayno | Estrera";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(85, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 164);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(552, 79);
            label2.Name = "label2";
            label2.Size = new Size(325, 18);
            label2.TabIndex = 11;
            label2.Text = "\"Welcome to FitPOS, your ultimate partner ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(567, 111);
            label7.Name = "label7";
            label7.Size = new Size(310, 18);
            label7.TabIndex = 12;
            label7.Text = "in streamlining your business operations!\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 589);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(showpassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(passwordlogin);
            Controls.Add(username_login);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox username_login;
        private TextBox passwordlogin;
        private Button Login;
        private Label label1;
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
        private Label label8;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label7;
    }
}
