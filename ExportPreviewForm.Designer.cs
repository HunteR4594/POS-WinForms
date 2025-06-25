namespace POS_project
{
    partial class ExportPreviewForm
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
            previewDataGridView = new DataGridView();
            export_button = new Button();
            cancel_button = new Button();
            ((System.ComponentModel.ISupportInitialize)previewDataGridView).BeginInit();
            SuspendLayout();
            // 
            // previewDataGridView
            // 
            previewDataGridView.AllowUserToAddRows = false;
            previewDataGridView.AllowUserToDeleteRows = false;
            previewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previewDataGridView.Location = new Point(50, 12);
            previewDataGridView.Margin = new Padding(4, 3, 4, 3);
            previewDataGridView.Name = "previewDataGridView";
            previewDataGridView.ReadOnly = true;
            previewDataGridView.RowHeadersWidth = 51;
            previewDataGridView.Size = new Size(905, 427);
            previewDataGridView.TabIndex = 0;
            previewDataGridView.CellContentClick += previewDataGridView_CellContentClick;
            // 
            // export_button
            // 
            export_button.FlatStyle = FlatStyle.Popup;
            export_button.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold);
            export_button.Location = new Point(737, 460);
            export_button.Margin = new Padding(4, 3, 4, 3);
            export_button.Name = "export_button";
            export_button.Size = new Size(88, 27);
            export_button.TabIndex = 1;
            export_button.Text = "Export";
            export_button.UseVisualStyleBackColor = true;
            export_button.Click += export_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.FlatStyle = FlatStyle.Popup;
            cancel_button.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold);
            cancel_button.Location = new Point(832, 460);
            cancel_button.Margin = new Padding(4, 3, 4, 3);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(88, 27);
            cancel_button.TabIndex = 2;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // ExportPreviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 178, 178);
            ClientSize = new Size(933, 501);
            Controls.Add(cancel_button);
            Controls.Add(export_button);
            Controls.Add(previewDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ExportPreviewForm";
            Text = "Export Preview";
            Load += ExportPreviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)previewDataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView previewDataGridView;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Button cancel_button;
    }
} 