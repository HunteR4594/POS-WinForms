using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace POS_project
{
    public partial class BarcodeScannerForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;
        private DateTime lastScanTime = DateTime.MinValue;
        private string lastBarcode = "";
        private volatile bool isProcessingFrame = false;

        public event EventHandler<string> BarcodeScanned;

        public BarcodeScannerForm()
        {
            InitializeComponent();
            InitializeScannerComponents();
            this.FormClosing += (s, e) => StopScanner();
        }

        private void InitializeScannerComponents()
        {
            barcodeReader = new BarcodeReader
            {
                Options = new DecodingOptions { TryHarder = true }
            };

            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video devices found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (FilterInfo device in videoDevices)
                {
                    Camera_type.Items.Add(device.Name);
                }
                Camera_type.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enumerating video devices: {ex.Message}", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Camera_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a camera.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[Camera_type.SelectedIndex].MonikerString);
            videoSource.NewFrame += video_NewFrame;
            videoSource.Start();

            stopButton.Enabled = true;
            startButton.Enabled = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopScanner();
        }

        private void StopScanner()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.NewFrame -= video_NewFrame;
                videoSource = null;
            }
            if (videoPictureBox.Image != null)
            {
                videoPictureBox.Image.Dispose();
                videoPictureBox.Image = null;
            }
            stopButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isProcessingFrame) return;
            isProcessingFrame = true;

            Bitmap originalFrame = (Bitmap)eventArgs.Frame.Clone();

            Task.Run(() =>
            {
                Bitmap bitmapForProcessing = null;
                try
                {
                    bitmapForProcessing = new Bitmap(originalFrame.Width, originalFrame.Height, PixelFormat.Format24bppRgb);
                    using (var g = Graphics.FromImage(bitmapForProcessing))
                    {
                        g.DrawImage(originalFrame, new Rectangle(0, 0, originalFrame.Width, originalFrame.Height));
                    }

                    // Create a clone for the UI thread to own, preventing a race condition.
                    var bitmapForDisplay = (Bitmap)bitmapForProcessing.Clone();

                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        if (this.IsDisposed)
                        {
                            bitmapForDisplay.Dispose(); // Clean up if the form is closed.
                            return;
                        }
                        videoPictureBox.Image?.Dispose();
                        videoPictureBox.Image = bitmapForDisplay; // UI thread now owns this bitmap.
                    });

                    var result = barcodeReader.Decode(bitmapForProcessing);

                    if (result != null)
                    {
                        if ((DateTime.Now - lastScanTime).TotalSeconds > 2 || result.Text != lastBarcode)
                        {
                            lastScanTime = DateTime.Now;
                            lastBarcode = result.Text;

                            this.BeginInvoke((MethodInvoker)delegate
                            {
                                if (this.IsDisposed) return;
                                BarcodeScanned?.Invoke(this, result.Text);
                                this.Close();
                            });
                        }
                    }
                }
                finally
                {
                    originalFrame.Dispose();
                    bitmapForProcessing?.Dispose(); // Dispose the bitmap used only for processing.
                    isProcessingFrame = false;
                }
            });
        }
    }
} 