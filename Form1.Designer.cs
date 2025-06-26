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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            username_login = new TextBox();
            passwordlogin = new TextBox();
            Login = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            showpassword = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Honeydew;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 785);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.8F);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(136, 659);
            label10.Name = "label10";
            label10.Size = new Size(152, 22);
            label10.TabIndex = 2;
            label10.Text = "Gabayno | Estrera";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 22);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(431, 458);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1185, -71);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 175);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(100, 629);
            label9.Name = "label9";
            label9.Size = new Size(229, 22);
            label9.TabIndex = 1;
            label9.Text = "Re-as | Villacarlos | Serafin ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(144, 599);
            label8.Name = "label8";
            label8.Size = new Size(134, 21);
            label8.TabIndex = 0;
            label8.Text = "Developed By:";
            // 
            // username_login
            // 
            username_login.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_login.Location = new Point(81, 258);
            username_login.Margin = new Padding(3, 2, 3, 2);
            username_login.Name = "username_login";
            username_login.Size = new Size(367, 32);
            username_login.TabIndex = 1;
            username_login.TextChanged += username_login_TextChanged;
            // 
            // passwordlogin
            // 
            passwordlogin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlogin.Location = new Point(81, 342);
            passwordlogin.Margin = new Padding(6, 4, 6, 4);
            passwordlogin.Name = "passwordlogin";
            passwordlogin.PasswordChar = '*';
            passwordlogin.Size = new Size(367, 32);
            passwordlogin.TabIndex = 2;
            // 
            // Login
            // 
            Login.BackColor = Color.Teal;
            Login.BackgroundImageLayout = ImageLayout.None;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(155, 460);
            Login.Margin = new Padding(3, 2, 3, 2);
            Login.Name = "Login";
            Login.Size = new Size(211, 44);
            Login.TabIndex = 3;
            Login.Text = "Log In";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(60, 177);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 4;
            label1.Text = "Log In Account";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(1155, 9);
            label3.Name = "label3";
            label3.Size = new Size(24, 24);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(720, 464);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 7;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Font = new Font("Tahoma", 10.2F);
            showpassword.ForeColor = Color.Teal;
            showpassword.Location = new Point(293, 380);
            showpassword.Margin = new Padding(3, 2, 3, 2);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(148, 25);
            showpassword.TabIndex = 8;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(75, 229);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 9;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(75, 307);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 10;
            label6.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(425, 18);
            label2.TabIndex = 11;
            label2.Text = "\"Your ultimate partner in streamlining your business operations!\"";
            label2.Click += label2_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(109, 41);
            label11.Name = "label11";
            label11.Size = new Size(304, 36);
            label11.TabIndex = 13;
            label11.Text = "Welcome to FitPOS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(showpassword);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(username_login);
            panel2.Controls.Add(passwordlogin);
            panel2.ForeColor = Color.PowderBlue;
            panel2.Location = new Point(573, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 567);
            panel2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1192, 785);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            ForeColor = Color.Teal;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private PictureBox pictureBox2;
        private Label label11;
        private Panel panel2;
    }
}
