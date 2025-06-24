using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Required for file operations

namespace POS_project
{
    public partial class ExportPreviewForm : Form
    {
        private DataTable _dataToExport;

        public ExportPreviewForm(DataTable dataToExport)
        {
            InitializeComponent();
            _dataToExport = dataToExport;
            previewDataGridView.DataSource = _dataToExport;
        }

        private void ExportPreviewForm_Load(object sender, EventArgs e)
        {
            // Optional: Adjust DataGridView properties for better viewing
            previewDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void export_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Export to CSV";
            saveFileDialog.FileName = "Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToCsv(saveFileDialog.FileName);
                    MessageBox.Show("Data exported successfully to CSV!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting data to CSV: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToCsv(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Add header row
            IEnumerable<string> columnNames = _dataToExport.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            // Add data rows
            foreach (DataRow row in _dataToExport.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field =>
                     string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 