using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;
using System.Threading; // Added for ManualResetEvent

namespace POS_project
{
    public partial class Barcode_Scanner : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;
        private DateTime lastScanTime = DateTime.MinValue;
        private string lastBarcode = "";
        private bool isClosing = false; // Flag to prevent race conditions on close

        public event EventHandler<string> BarcodeScanned;

        public Barcode_Scanner()
        {
            InitializeComponent();
            this.Load += Barcode_Scanner_Load;
            this.FormClosing += Barcode_Scanner_FormClosing;
        }

        private void Barcode_Scanner_Load(object sender, EventArgs e)
        {
            InitializeScannerComponents();
        }

        private void InitializeScannerComponents()
        {
            // --- Initialize the barcode reader ---
            barcodeReader = new BarcodeReader();

            try
            {
                // --- Enumerate video input devices ---
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video devices found.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetControlStates(false, false);
                    return;
                }

                // Populate the Camera_type ComboBox with available cameras
                foreach (FilterInfo device in videoDevices)
                {
                    Camera_type.Items.Add(device.Name);
                }
                Camera_type.SelectedIndex = 0; // Select the first camera by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not initialize camera: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetControlStates(false, false);
                return;
            }

            // Attach event handlers for buttons
            startButton.Click += startButton_Click;
            stopButton.Click += stopButton_Click;

            // Set initial control states
            SetControlStates(true, true);
        }

        private void SetControlStates(bool isReadyToStart, bool isCameraSelectionEnabled)
        {
            if (this.IsDisposed || this.Disposing) return;

            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { SetControlStates(isReadyToStart, isCameraSelectionEnabled); });
            }
            else
            {
                startButton.Enabled = isReadyToStart;
                stopButton.Enabled = !isReadyToStart;
                Camera_type.Enabled = isCameraSelectionEnabled;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Camera_type.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a camera.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[Camera_type.SelectedIndex].MonikerString);
            videoSource.NewFrame += video_NewFrame;
            videoSource.Start();

            SetControlStates(false, false);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopScanner();
        }

        private void StopScanner()
        {
            if (this.IsDisposed || isClosing) return;

            // Signal that we are closing to prevent race conditions
            isClosing = true;

            if (videoSource != null && videoSource.IsRunning)
            {
                // Detach event handler first
                videoSource.NewFrame -= video_NewFrame;
                // Signal to stop and wait for it to finish
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }

            // Safely clear the PictureBox on the UI thread
            if (videoPictureBox.InvokeRequired)
            {
                videoPictureBox.Invoke((MethodInvoker)delegate {
                    videoPictureBox.Image?.Dispose();
                    videoPictureBox.Image = null;
                });
            }
            else
            {
                videoPictureBox.Image?.Dispose();
                videoPictureBox.Image = null;
            }

            SetControlStates(true, true);
            isClosing = false; // Reset flag
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (this.IsDisposed || isClosing) return;

            try
            {
                using (var bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    // Update PictureBox on UI thread
                    this.Invoke((MethodInvoker)delegate {
                        if (!this.IsDisposed && !isClosing)
                        {
                            videoPictureBox.Image?.Dispose();
                            videoPictureBox.Image = (Bitmap)bitmap.Clone();
                        }
                    });

                    // Decode on a background thread to avoid blocking the camera feed
                    Task.Run(() =>
                    {
                        if (this.IsDisposed || isClosing) return;

                        var result = barcodeReader.Decode((Bitmap)bitmap.Clone());
                        if (result != null)
                        {
                            ProcessScannedBarcode(result.Text);
                        }
                    });
                }
            }
            catch (Exception)
            {
                // Ignore exceptions that can occur during closing
            }
        }

        private void ProcessScannedBarcode(string barcode)
        {
            if ((DateTime.Now - lastScanTime).TotalSeconds > 3 || barcode != lastBarcode)
            {
                lastScanTime = DateTime.Now;
                lastBarcode = barcode;

                this.Invoke((MethodInvoker)delegate {
                    if (!this.IsDisposed)
                    {
                        barcodeResultLabel.Text = barcode;
                        BarcodeScanned?.Invoke(this, barcode);
                        StopScanner(); // Stop after successful scan
                        this.DialogResult = DialogResult.OK; // Set result
                        this.Close(); // Close the form
                    }
                });
            }
        }

        private void Barcode_Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopScanner();
        }

        // Add the missing event handler for barcodeResultLabel.TextChanged
        private void barcodeResultLabel_TextChanged(object sender, EventArgs e)
        {
            // No action needed, but required for designer event hookup
        }
    }
}
