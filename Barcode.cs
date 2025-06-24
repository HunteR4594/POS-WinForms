using AForge.Video; // For VideoCaptureDevice, VideoDevices
using AForge.Video.DirectShow; // For FilterInfoCollection, VideoCaptureDevice
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing; // For BarcodeReader, Result
using ZXing.Common;
using ZXing.Windows.Compatibility; // For Bitmap-specific BarcodeReader

namespace POS_project
{
    public partial class Barcode : UserControl
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;
        private DateTime lastScanTime = DateTime.MinValue;
        private string lastBarcode = "";

        public event EventHandler<string> BarcodeScanned;

        public Barcode()
        {
            InitializeComponent();
            // Initialize scanner components when the UserControl is loaded
            this.Load += Barcode_Load;
            // Handle cleanup when the UserControl is disposed (crucial for webcam release)
            this.Disposed += Barcode_Disposed;
        }

        private void Barcode_Load(object sender, EventArgs e)
        {
            InitializeScannerComponents();
        }

        private void InitializeScannerComponents()
        {
            barcodeReader = new BarcodeReader();
            barcodeReader.Options = new DecodingOptions
            {
                PossibleFormats = new List<BarcodeFormat>
                {
                    BarcodeFormat.EAN_13,
                    BarcodeFormat.CODE_128,
                    BarcodeFormat.QR_CODE,
                    BarcodeFormat.CODE_39,
                    BarcodeFormat.EAN_8,
                    BarcodeFormat.UPC_A,
                    BarcodeFormat.UPC_E,
                    BarcodeFormat.ITF,
                    BarcodeFormat.PDF_417,
                    BarcodeFormat.CODABAR,
                    BarcodeFormat.DATA_MATRIX,
                    BarcodeFormat.AZTEC,
                    // Add more formats as needed
                },
                TryHarder = true,
                PureBarcode = false
            };

            // Enumerate video input devices
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enumerating video devices: {ex.Message}\nEnsure necessary drivers are installed.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startButton.Enabled = false;
                stopButton.Enabled = false;
                Camera_type.Enabled = false;
                return;
            }


            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video input devices found. Please ensure a webcam is connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startButton.Enabled = false;
                stopButton.Enabled = false;
                Camera_type.Enabled = false;
                return;
            }

            // Populate the Camera_type ComboBox
            foreach (FilterInfo device in videoDevices)
            {
                Camera_type.Items.Add(device.Name);
            }
            Camera_type.SelectedIndex = 0; // Select the first camera by default

            // Set up event handlers for buttons
            startButton.Click += startButton_Click;
            stopButton.Click += stopButton_Click;

            // Ensure stop button is initially disabled
            stopButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Camera_type.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a camera.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                StopScanner(); // Stop if already running to prevent conflicts
            }

            try
            {
                videoSource = new VideoCaptureDevice(videoDevices[Camera_type.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();

                startButton.Enabled = false;
                stopButton.Enabled = true;
                Camera_type.Enabled = false;
                barcodeResultLabel.Text = "Scanned Barcode:";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting camera: {ex.Message}\nMake sure no other application is using the camera.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopScanner(); // Ensure cleanup if start fails
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopScanner();
        }

        private void StopScanner()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop(); // Signal the thread to stop
                videoSource.WaitForStop();  // Wait for the thread to actually stop
                videoSource.NewFrame -= video_NewFrame; // Unsubscribe to prevent memory leaks and ensure proper shutdown
                videoSource = null; // Dereference
            }
            // Dispose the image in the PictureBox to release its resources
            if (videoPictureBox.Image != null)
            {
                videoPictureBox.Image.Dispose();
                videoPictureBox.Image = null; // Clear the picture box
            }
            startButton.Enabled = true;
            stopButton.Enabled = false;
            Camera_type.Enabled = true;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = null;
            Bitmap displayBitmap = null;
            try
            {
                // Always clone the frame to avoid threading issues
                bitmap = (Bitmap)eventArgs.Frame.Clone();
                // Create a new Bitmap to assign to the PictureBox
                displayBitmap = (Bitmap)bitmap.Clone();

                // Display the frame in the PictureBox on the UI thread
                if (videoPictureBox.InvokeRequired)
                {
                    videoPictureBox.Invoke((MethodInvoker)delegate
                    {
                        if (videoPictureBox.Image != null)
                        {
                            videoPictureBox.Image.Dispose();
                        }
                        videoPictureBox.Image = displayBitmap;
                    });
                }
                else
                {
                    if (videoPictureBox.Image != null)
                    {
                        videoPictureBox.Image.Dispose();
                    }
                    videoPictureBox.Image = displayBitmap;
                }

                // Decode barcode from the frame (use the original bitmap)
                Result result = barcodeReader.Decode(bitmap);

                if (result != null)
                {
                    // Debounce: Only accept a new scan if 2 seconds have passed or barcode is different
                    if ((DateTime.Now - lastScanTime).TotalSeconds > 2 || result.Text != lastBarcode)
                    {
                        lastScanTime = DateTime.Now;
                        lastBarcode = result.Text;

                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            barcodeResultLabel.Text = result.Text;
                            StopScanner();
                            Task.Run(() => ProcessScannedBarcode(result.Text));
                        });
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No barcode detected in this frame.");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in video_NewFrame: {ex.Message}");
            }
            finally
            {
                // Dispose the original bitmap (not the one in the PictureBox)
                if (bitmap != null)
                {
                    bitmap.Dispose();
                }
                // Do not dispose displayBitmap here, it's now owned by the PictureBox
            }
        }

        private void ProcessScannedBarcode(string barcode)
        {
            BarcodeScanned?.Invoke(this, barcode);
            MessageBox.Show($"Barcode Processed: {barcode}", "Barcode Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // IMPORTANT: Clean up resources when the UserControl is disposed or removed from its parent
        private void Barcode_Disposed(object sender, EventArgs e)
        {
            StopScanner(); // Ensure scanner is stopped and all resources are released
        }
    }
}