namespace POS_project
{
    partial class Barcode
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
            stopButton = new Button();
            label2 = new Label();
            barcodeResultLabel = new TextBox();
            startButton = new Button();
            Camera_type = new ComboBox();
            label1 = new Label();
            videoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // stopButton
            // 
            stopButton.Location = new Point(698, 168);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(94, 29);
            stopButton.TabIndex = 13;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 12;
            label2.Text = "Barcode:";
            // 
            // barcodeResultLabel
            // 
            barcodeResultLabel.Location = new Point(541, 68);
            barcodeResultLabel.Name = "barcodeResultLabel";
            barcodeResultLabel.Size = new Size(210, 27);
            barcodeResultLabel.TabIndex = 11;
            // 
            // startButton
            // 
            startButton.Location = new Point(698, 123);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 10;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // Camera_type
            // 
            Camera_type.FormattingEnabled = true;
            Camera_type.Location = new Point(145, 68);
            Camera_type.Name = "Camera_type";
            Camera_type.Size = new Size(251, 28);
            Camera_type.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 71);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 8;
            label1.Text = "Camera:";
            // 
            // videoPictureBox
            // 
            videoPictureBox.Location = new Point(56, 111);
            videoPictureBox.Name = "videoPictureBox";
            videoPictureBox.Size = new Size(597, 399);
            videoPictureBox.TabIndex = 14;
            videoPictureBox.TabStop = false;
            // 
            // Barcode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(videoPictureBox);
            Controls.Add(stopButton);
            Controls.Add(label2);
            Controls.Add(barcodeResultLabel);
            Controls.Add(startButton);
            Controls.Add(Camera_type);
            Controls.Add(label1);
            Name = "Barcode";
            Size = new Size(855, 538);
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stopButton;
        private Label label2;
        private TextBox barcodeResultLabel;
        private Button startButton;
        private ComboBox Camera_type;
        private Label label1;
        private PictureBox videoPictureBox;
    }
}
