namespace POS_project
{
    partial class BarcodeScannerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox videoPictureBox;
        private System.Windows.Forms.ComboBox Camera_type;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeResultLabel;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.videoPictureBox = new System.Windows.Forms.PictureBox();
            this.Camera_type = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeResultLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPictureBox
            // 
            this.videoPictureBox.Location = new System.Drawing.Point(12, 54);
            this.videoPictureBox.Name = "videoPictureBox";
            this.videoPictureBox.Size = new System.Drawing.Size(468, 283);
            this.videoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoPictureBox.TabIndex = 0;
            this.videoPictureBox.TabStop = false;
            // 
            // Camera_type
            // 
            this.Camera_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camera_type.FormattingEnabled = true;
            this.Camera_type.Location = new System.Drawing.Point(67, 12);
            this.Camera_type.Name = "Camera_type";
            this.Camera_type.Size = new System.Drawing.Size(220, 21);
            this.Camera_type.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(324, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(405, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Camera:";
            //
            // barcodeResultLabel
            //
            this.barcodeResultLabel.Location = new System.Drawing.Point(12, 343);
            this.barcodeResultLabel.Name = "barcodeResultLabel";
            this.barcodeResultLabel.ReadOnly = true;
            this.barcodeResultLabel.Size = new System.Drawing.Size(468, 20);
            this.barcodeResultLabel.TabIndex = 5;
            this.barcodeResultLabel.Text = "Scanned Barcode:";
            // 
            // BarcodeScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.barcodeResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Camera_type);
            this.Controls.Add(this.videoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Barcode Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
} 