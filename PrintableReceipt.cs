using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_project
{
    public class PrintableReceipt
    {
        private readonly DataTable _orderItems;
        private readonly double _subtotal, _discount, _vat, _total;
        private readonly string _cashierName;
        private readonly int _receiptWidth;
        private readonly Font _font;

        public PrintableReceipt(DataTable orderItems, double subtotal, double discount, double vat, double total, string cashierName, int receiptWidth = 280)
        {
            _orderItems = orderItems;
            _subtotal = subtotal;
            _discount = discount;
            _vat = vat;
            _total = total;
            _cashierName = cashierName;
            _receiptWidth = receiptWidth;
            _font = new Font("Courier New", 8);
        }

        public string GetFormattedReceipt()
        {
            StringBuilder receipt = new StringBuilder();

            // Header
            receipt.AppendLine(Center("Your Store Name"));
            receipt.AppendLine(Center("123 Main Street, City, State"));
            receipt.AppendLine(Center($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}"));
            receipt.AppendLine(Center($"Cashier: {_cashierName}"));
            receipt.AppendLine(new string('-', 35));

            // Column Headers
            receipt.AppendLine(string.Format("{0,-15} {1,5} {2,12}", "Item", "Qty", "Price"));
            receipt.AppendLine(new string('-', 35));

            // Items
            foreach (DataRow row in _orderItems.Rows)
            {
                string name = row["Product Name"].ToString();
                int qty = Convert.ToInt32(row["Quantity"]);
                double price = Convert.ToDouble(row["Final Subtotal"]);

                // Truncate long names
                if (name.Length > 15) name = name.Substring(0, 15);

                receipt.AppendLine(string.Format("{0,-15} {1,5} {2,12:C2}", name, qty, price));
            }
            receipt.AppendLine(new string('-', 35));

            // Totals
            receipt.AppendLine(AlignRight($"Subtotal: {_subtotal:C2}"));
            if (_discount > 0)
            {
                receipt.AppendLine(AlignRight($"Discount: {_discount:C2}"));
            }
            receipt.AppendLine(AlignRight($"VAT (12%): {_vat:C2}"));
            receipt.AppendLine(new string('-', 35));
            receipt.AppendLine(AlignRight($"Total: {_total:C2}"));
            receipt.AppendLine();

            // Footer
            receipt.AppendLine(Center("Thank you for your purchase!"));

            return receipt.ToString();
        }
        
        private string Center(string text)
        {
            int spaces = (_receiptWidth / (int)_font.Size - text.Length) / 2;
            return new string(' ', Math.Max(0, spaces)) + text;
        }

        private string AlignRight(string text)
        {
            int spaces = _receiptWidth / (int)_font.Size - text.Length;
            return new string(' ', Math.Max(0, spaces)) + text;
        }
        
        public void Print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) =>
            {
                string receiptText = GetFormattedReceipt();
                // Measure the string
                SizeF stringSize = e.Graphics.MeasureString(receiptText, _font);
                
                // Set paper size dynamically, adding some padding
                pd.DefaultPageSettings.PaperSize = new PaperSize("Custom Receipt", _receiptWidth, (int)stringSize.Height + 40);

                // Draw the receipt text
                e.Graphics.DrawString(receiptText, _font, Brushes.Black, new PointF(10, 10));
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
    }
} 