using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace POS_project
{
    public partial class Barcode_Scanner : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;
        private DateTime lastScanTime = DateTime.MinValue;
        private string lastBarcode = "";
        private bool isClosing = false;

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
            barcodeReader = new BarcodeReader();

            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video devices found.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetControlStates(isReadyToStart: false, isCameraSelectionEnabled: false);
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
                MessageBox.Show($"Could not initialize camera: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetControlStates(isReadyToStart: false, isCameraSelectionEnabled: false);
                return;
            }
            
            SetControlStates(isReadyToStart: true, isCameraSelectionEnabled: true);
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

            SetControlStates(isReadyToStart: false, isCameraSelectionEnabled: false);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopScanner();
            this.Close();
        }

        private void StopScanner()
        {
            if (isClosing) return;

            if (videoSource != null && videoSource.IsRunning)
            {
                isClosing = true;
                videoSource.SignalToStop();
                videoSource.NewFrame -= video_NewFrame; 
                videoSource = null;
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isClosing || this.IsDisposed) return;

            try
            {
                using (var bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        if (!isClosing && !this.IsDisposed)
                        {
                            videoPictureBox.Image?.Dispose();
                            videoPictureBox.Image = (Bitmap)bitmap.Clone();
                        }
                    });

                    Task.Run(() =>
                    {
                        if (isClosing) return;
                        var result = barcodeReader.Decode(bitmap);
                        if (result != null)
                        {
                            ProcessScannedBarcode(result.Text);
                        }
                    });
                }
            }
            catch (Exception)
            {
                // Ignore exceptions during closing
            }
        }

        private void ProcessScannedBarcode(string barcode)
        {
            if ((DateTime.Now - lastScanTime).TotalSeconds > 3 || barcode != lastBarcode)
            {
                lastScanTime = DateTime.Now;
                lastBarcode = barcode;

                this.Invoke((MethodInvoker)delegate
                {
                    if (!isClosing && !this.IsDisposed)
                    {
                        barcodeResultLabel.Text = barcode;
                        BarcodeScanned?.Invoke(this, barcode);
                        StopScanner();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                });
            }
        }

        private void Barcode_Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopScanner();
        }

        private void barcodeResultLabel_TextChanged(object sender, EventArgs e)
        {
            // This method is required by the designer.
        }
    }
}

