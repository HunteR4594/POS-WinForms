using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing; // Required for printing functionality

namespace POS_project
{
    public partial class PrintConfirmationForm : Form
    {
        private DataGridView _dataGridViewToPrint;
        private int _currentRowIndex;
        private int _pageNumber;
        private float[] _columnWidths;

        public PrintConfirmationForm(DataGridView dataGridViewToPrint)
        {
            InitializeComponent();
            _dataGridViewToPrint = dataGridViewToPrint;
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            _currentRowIndex = 0;
            _pageNumber = 1;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printDoc.DefaultPageSettings.Landscape = true; // Use landscape for wider reports

            CalculateColumnWidths(printDoc); 

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
            this.Close();
        }

        private void CalculateColumnWidths(PrintDocument printDoc)
        {
            _columnWidths = new float[_dataGridViewToPrint.Columns.Count];
            // Use a temporary Graphics object to measure strings
            using (Graphics g = printDoc.PrinterSettings.CreateMeasurementGraphics())
            {
                Font headerFont = new Font("Arial", 10, FontStyle.Bold);
                Font bodyFont = new Font("Arial", 10);
                float padding = 8; // Padding for cell content

                for (int i = 0; i < _dataGridViewToPrint.Columns.Count; i++)
                {
                    // Start with header width
                    float maxWidth = g.MeasureString(_dataGridViewToPrint.Columns[i].HeaderText, headerFont).Width + padding;

                    // Check content width (sample first 100 rows for performance)
                    for (int j = 0; j < Math.Min(100, _dataGridViewToPrint.Rows.Count); j++)
                    {
                        if (_dataGridViewToPrint.Rows[j].IsNewRow) continue;
                        var cellValue = _dataGridViewToPrint.Rows[j].Cells[i].Value?.ToString() ?? "";
                        float cellWidth = g.MeasureString(cellValue, bodyFont).Width + padding;
                        if (cellWidth > maxWidth)
                        {
                            maxWidth = cellWidth;
                        }
                    }
                    _columnWidths[i] = maxWidth;
                }

                // Now, scale widths to fit the page if necessary
                float totalWidth = _columnWidths.Sum();
                float availableWidth = printDoc.DefaultPageSettings.Bounds.Width - printDoc.DefaultPageSettings.Margins.Left - printDoc.DefaultPageSettings.Margins.Right;

                if (totalWidth > availableWidth)
                {
                    float scalingFactor = availableWidth / totalWidth;
                    for (int i = 0; i < _columnWidths.Length; i++)
                    {
                        _columnWidths[i] *= scalingFactor;
                    }
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            RectangleF marginBounds = e.MarginBounds;
            float y = marginBounds.Top;

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            Font footerFont = new Font("Arial", 8, FontStyle.Italic);

            float headerHeight = headerFont.GetHeight(g);
            float bodyHeight = bodyFont.GetHeight(g);

            // Print Report Title and Date
            string title = "Sales Report";
            g.DrawString(title, titleFont, Brushes.Black, marginBounds.Left, y);
            y += titleFont.GetHeight(g);
            string dateStr = $"Date Printed: {DateTime.Now:MM/dd/yyyy hh:mm tt}";
            g.DrawString(dateStr, bodyFont, Brushes.Black, marginBounds.Left, y);
            y += bodyFont.GetHeight(g) * 2;

            // Use pre-calculated column widths
            // float[] columnWidths = new float[_dataGridViewToPrint.Columns.Count];
            // for (int i = 0; i < _dataGridViewToPrint.Columns.Count; i++)
            // {
            //     columnWidths[i] = marginBounds.Width / _dataGridViewToPrint.Columns.Count;
            // }

            // Print Column Headers
            float x = marginBounds.Left;
            for (int i = 0; i < _dataGridViewToPrint.Columns.Count; i++)
            {
                g.FillRectangle(Brushes.LightGray, new RectangleF(x, y, _columnWidths[i], headerHeight));
                g.DrawRectangle(Pens.Black, x, y, _columnWidths[i], headerHeight);
                g.DrawString(_dataGridViewToPrint.Columns[i].HeaderText, headerFont, Brushes.Black, new RectangleF(x + 2, y + 2, _columnWidths[i] - 4, headerHeight - 4));
                x += _columnWidths[i];
            }
            y += headerHeight;

            // Print Rows
            while (_currentRowIndex < _dataGridViewToPrint.Rows.Count)
            {
                DataGridViewRow row = _dataGridViewToPrint.Rows[_currentRowIndex];
                if (row.IsNewRow)
                {
                    _currentRowIndex++;
                    continue;
                }

                if (y + bodyHeight > marginBounds.Bottom)
                {
                    // Footer for current page
                    string footer = $"Page {_pageNumber}";
                    g.DrawString(footer, footerFont, Brushes.Gray, marginBounds.Left, marginBounds.Bottom + 5);

                    e.HasMorePages = true;
                    _pageNumber++;
                    return;
                }

                x = marginBounds.Left;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    g.DrawRectangle(Pens.Black, x, y, _columnWidths[i], bodyHeight);
                    g.DrawString(row.Cells[i].Value?.ToString(), bodyFont, Brushes.Black, new RectangleF(x + 2, y + 2, _columnWidths[i] - 4, bodyHeight - 4));
                    x += _columnWidths[i];
                }

                y += bodyHeight;
                _currentRowIndex++;
            }

            // Final Footer
            string finalFooter = $"Page {_pageNumber}";
            g.DrawString(finalFooter, footerFont, Brushes.Gray, marginBounds.Left, marginBounds.Bottom + 5);

            e.HasMorePages = false;
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 