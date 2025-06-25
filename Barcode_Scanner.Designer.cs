namespace POS_project
{
    partial class Barcode_Scanner
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
            videoPictureBox = new PictureBox();
            stopButton = new Button();
            label2 = new Label();
            barcodeResultLabel = new TextBox();
            startButton = new Button();
            Camera_type = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // videoPictureBox
            // 
            videoPictureBox.BackColor = Color.FromArgb(178, 216, 216);
            videoPictureBox.Location = new Point(78, 92);
            videoPictureBox.Margin = new Padding(3, 2, 3, 2);
            videoPictureBox.Name = "videoPictureBox";
            videoPictureBox.Size = new Size(522, 299);
            videoPictureBox.TabIndex = 21;
            videoPictureBox.TabStop = false;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.Maroon;
            stopButton.BackgroundImageLayout = ImageLayout.None;
            stopButton.FlatStyle = FlatStyle.Popup;
            stopButton.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold);
            stopButton.ForeColor = SystemColors.ButtonFace;
            stopButton.Location = new Point(640, 144);
            stopButton.Margin = new Padding(3, 2, 3, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(82, 27);
            stopButton.TabIndex = 20;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 62);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 19;
            label2.Text = "Barcode:";
            // 
            // barcodeResultLabel
            // 
            barcodeResultLabel.BorderStyle = BorderStyle.FixedSingle;
            barcodeResultLabel.Location = new Point(500, 59);
            barcodeResultLabel.Margin = new Padding(3, 2, 3, 2);
            barcodeResultLabel.Name = "barcodeResultLabel";
            barcodeResultLabel.Size = new Size(184, 23);
            barcodeResultLabel.TabIndex = 18;
            barcodeResultLabel.TextChanged += barcodeResultLabel_TextChanged;
            // 
            // startButton
            // 
            startButton.BackColor = Color.ForestGreen;
            startButton.BackgroundImageLayout = ImageLayout.None;
            startButton.FlatStyle = FlatStyle.Popup;
            startButton.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold);
            startButton.ForeColor = SystemColors.ButtonFace;
            startButton.Location = new Point(640, 101);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(82, 30);
            startButton.TabIndex = 17;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            // 
            // Camera_type
            // 
            Camera_type.FormattingEnabled = true;
            Camera_type.Location = new Point(169, 60);
            Camera_type.Margin = new Padding(3, 2, 3, 2);
            Camera_type.Name = "Camera_type";
            Camera_type.Size = new Size(219, 23);
            Camera_type.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 62);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 15;
            label1.Text = "Camera:";
            label1.Click += label1_Click;
            // 
            // Barcode_Scanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 178, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(videoPictureBox);
            Controls.Add(stopButton);
            Controls.Add(label2);
            Controls.Add(barcodeResultLabel);
            Controls.Add(startButton);
            Controls.Add(Camera_type);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Barcode_Scanner";
            Text = "Barcode_Scanner";
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox videoPictureBox;
        private Button stopButton;
        private Label label2;
        private TextBox barcodeResultLabel;
        private Button startButton;
        private ComboBox Camera_type;
        private Label label1;
    }
}