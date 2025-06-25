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
            videoPictureBox.Location = new Point(78, 92);
            videoPictureBox.Margin = new Padding(3, 2, 3, 2);
            videoPictureBox.Name = "videoPictureBox";
            videoPictureBox.Size = new Size(522, 299);
            videoPictureBox.TabIndex = 21;
            videoPictureBox.TabStop = false;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(640, 135);
            stopButton.Margin = new Padding(3, 2, 3, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(82, 22);
            stopButton.TabIndex = 20;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 66);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 19;
            label2.Text = "Barcode:";
            // 
            // barcodeResultLabel
            // 
            barcodeResultLabel.Location = new Point(502, 60);
            barcodeResultLabel.Margin = new Padding(3, 2, 3, 2);
            barcodeResultLabel.Name = "barcodeResultLabel";
            barcodeResultLabel.Size = new Size(184, 23);
            barcodeResultLabel.TabIndex = 18;
            //barcodeResultLabel.TextChanged += barcodeResultLabel_TextChanged;
            // 
            // startButton
            // 
            startButton.Location = new Point(640, 101);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(82, 22);
            startButton.TabIndex = 17;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // Camera_type
            // 
            Camera_type.FormattingEnabled = true;
            Camera_type.Location = new Point(156, 60);
            Camera_type.Margin = new Padding(3, 2, 3, 2);
            Camera_type.Name = "Camera_type";
            Camera_type.Size = new Size(220, 23);
            Camera_type.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 62);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 15;
            label1.Text = "Camera:";
            // 
            // Barcode_Scanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(videoPictureBox);
            Controls.Add(stopButton);
            Controls.Add(label2);
            Controls.Add(barcodeResultLabel);
            Controls.Add(startButton);
            Controls.Add(Camera_type);
            Controls.Add(label1);
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