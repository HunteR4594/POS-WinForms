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

        public PrintConfirmationForm(DataGridView dataGridViewToPrint)
        {
            InitializeComponent();
            _dataGridViewToPrint = dataGridViewToPrint;
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
            this.Close();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // This is a basic printing implementation. 
            // For more advanced printing (e.g., proper pagination, headers, footers, scaling),
            // you would need a more sophisticated rendering logic.

            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 50;
            int offset = 40;

            // Print Header
            graphics.DrawString("Sales Report", new Font("Arial", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);
            offset += 30;

            // Print Column Headers
            string headers = "";
            foreach (DataGridViewColumn column in _dataGridViewToPrint.Columns)
            {
                headers += column.HeaderText + "\t"; // Use tab for basic separation
            }
            graphics.DrawString(headers, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 5;

            // Print Data Rows
            foreach (DataGridViewRow row in _dataGridViewToPrint.Rows)
            {
                if (row.IsNewRow) continue;

                string rowData = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData += cell.Value?.ToString() + "\t";
                }
                graphics.DrawString(rowData, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight;

                // Basic pagination (if content exceeds one page)
                if (startY + offset > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    offset = 0; // Reset offset for next page
                    return; // Stop rendering current page
                }
            }
            e.HasMorePages = false;
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 