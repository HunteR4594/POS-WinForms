using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing.Windows.Compatibility;

namespace POS_project
{
    public static class BarcodeUtility
    {
        /// <summary>
        /// Generates a Code128 barcode image from the given text
        /// </summary>
        /// <param name="text">The text to encode in the barcode</param>
        /// <param name="width">Width of the barcode image</param>
        /// <param name="height">Height of the barcode image</param>
        /// <returns>Bitmap containing the barcode</returns>
        public static Bitmap GenerateCode128Barcode(string text, int width = 300, int height = 100)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = width,
                    Height = height,
                    Margin = 0,
                    PureBarcode = false
                }
            };

            return writer.Write(text);
        }

        /// <summary>
        /// Generates a Code39 barcode image from the given text
        /// </summary>
        /// <param name="text">The text to encode in the barcode</param>
        /// <param name="width">Width of the barcode image</param>
        /// <param name="height">Height of the barcode image</param>
        /// <returns>Bitmap containing the barcode</returns>
        public static Bitmap GenerateCode39Barcode(string text, int width = 300, int height = 100)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_39,
                Options = new EncodingOptions
                {
                    Width = width,
                    Height = height,
                    Margin = 0,
                    PureBarcode = false
                }
            };

            return writer.Write(text);
        }

        /// <summary>
        /// Generates a QR code image from the given text
        /// </summary>
        /// <param name="text">The text to encode in the QR code</param>
        /// <param name="width">Width of the QR code image</param>
        /// <param name="height">Height of the QR code image</param>
        /// <returns>Bitmap containing the QR code</returns>
        public static Bitmap GenerateQRCode(string text, int width = 200, int height = 200)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = width,
                    Height = height,
                    Margin = 0
                }
            };

            return writer.Write(text);
        }

        /// <summary>
        /// Saves a barcode image to a file
        /// </summary>
        /// <param name="barcode">The barcode bitmap to save</param>
        /// <param name="filePath">The file path where to save the image</param>
        /// <param name="format">The image format (default: PNG)</param>
        public static void SaveBarcodeToFile(Bitmap barcode, string filePath, ImageFormat format = null)
        {
            format ??= ImageFormat.Png;
            
            // Ensure directory exists
            string directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            barcode.Save(filePath, format);
        }

        /// <summary>
        /// Generates a unique product barcode based on product ID and timestamp
        /// </summary>
        /// <param name="productId">The product ID</param>
        /// <returns>A unique barcode string</returns>
        public static string GenerateUniqueProductBarcode(string productId)
        {
            // Create a unique barcode by combining product ID with timestamp
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            return $"{productId}{timestamp}";
        }

        /// <summary>
        /// Generates and saves a barcode for a product
        /// </summary>
        /// <param name="productId">The product ID</param>
        /// <param name="barcodeText">The text to encode (if null, uses productId)</param>
        /// <param name="barcodeType">Type of barcode to generate</param>
        /// <returns>The file path where the barcode was saved</returns>
        public static string GenerateAndSaveProductBarcode(string productId, string barcodeText = null, BarcodeFormat barcodeType = BarcodeFormat.CODE_128)
        {
            barcodeText ??= productId;

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string barcodeDirectory = Path.Combine(baseDirectory, "Barcodes");
            
            if (!Directory.Exists(barcodeDirectory))
            {
                Directory.CreateDirectory(barcodeDirectory);
            }

            string fileName = $"barcode_{productId}.png";
            string filePath = Path.Combine(barcodeDirectory, fileName);

            Bitmap barcode;
            switch (barcodeType)
            {
                case BarcodeFormat.CODE_39:
                    barcode = GenerateCode39Barcode(barcodeText);
                    break;
                case BarcodeFormat.QR_CODE:
                    barcode = GenerateQRCode(barcodeText);
                    break;
                case BarcodeFormat.CODE_128:
                default:
                    barcode = GenerateCode128Barcode(barcodeText);
                    break;
            }

            SaveBarcodeToFile(barcode, filePath);
            barcode.Dispose();

            return filePath;
        }
    }
} 