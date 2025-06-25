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
using ZXing.Common;
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
        private readonly object _lockObject = new object(); // For thread safety during barcode processing
        private ManualResetEvent _stopScanningEvent = new ManualResetEvent(false); // Signals the video thread to stop

        // --- Timer for automatic timeout ---
        private System.Windows.Forms.Timer scanTimeoutTimer;

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
            // --- Initialize the timeout timer ---
            scanTimeoutTimer = new System.Windows.Forms.Timer();
            scanTimeoutTimer.Interval = 30000; // 30 seconds timeout
            scanTimeoutTimer.Tick += ScanTimeoutTimer_Tick;

            // --- Initialize the barcode reader ---
            barcodeReader = new BarcodeReader
            {
                Options = new DecodingOptions
                {
                    PossibleFormats = new List<BarcodeFormat>
                    {
                        BarcodeFormat.EAN_13, BarcodeFormat.CODE_128, BarcodeFormat.QR_CODE,
                        BarcodeFormat.CODE_39, BarcodeFormat.EAN_8, BarcodeFormat.UPC_A,
                        BarcodeFormat.UPC_E, BarcodeFormat.ITF, BarcodeFormat.PDF_417,
                        BarcodeFormat.CODABAR, BarcodeFormat.DATA_MATRIX, BarcodeFormat.AZTEC,
                    },
                    TryHarder = true, // Try harder to find a barcode in the image
                    PureBarcode = false // Allow non-pure barcodes (e.g., with text around them)
                }
            };

            try
            {
                // --- Enumerate video input devices ---
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video devices found. Please ensure a camera is connected.", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetControlStates(false, false, false); // Disable all camera-related controls
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
                MessageBox.Show($"Could not initialize camera: {ex.Message}", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetControlStates(false, false, false); // Disable controls on initialization failure
                return;
            }

            // Attach event handlers for buttons
            startButton.Click += startButton_Click;
            stopButton.Click += stopButton_Click;

            // Set initial control states
            SetControlStates(true, false, true); // Enable Start, disable Stop, enable Camera selection
        }

        // Helper method to enable/disable UI controls (thread-safe)
        private void SetControlStates(bool startEnabled, bool stopEnabled, bool cameraEnabled)
        {
            // Use Invoke to ensure UI updates happen on the UI thread
            if (this.InvokeRequired && !this.IsDisposed) // Add IsDisposed check for safety
            {
                this.Invoke((MethodInvoker)delegate { SetControlStates(startEnabled, stopEnabled, cameraEnabled); });
            }
            else if (!this.IsDisposed) // Only update if not disposed
            {
                startButton.Enabled = startEnabled;
                stopButton.Enabled = stopEnabled;
                Camera_type.Enabled = cameraEnabled;
            }
        }

        // Event handler for the Start button click
        private void startButton_Click(object sender, EventArgs e)
        {
            if (Camera_type.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a camera.", "No Camera Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StopScanner(); // Ensure any previously running scanner is stopped and cleaned up

            try
            {
                // --- Initialize and start video source ---
                videoSource = new VideoCaptureDevice(videoDevices[Camera_type.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame); // Subscribe to new frame events
                videoSource.Start(); // Start the video capture device

                SetControlStates(false, true, false); // Disable Start, enable Stop, disable Camera selection
                _stopScanningEvent.Reset(); // Reset the stop signal for the video thread
                scanTimeoutTimer.Start(); // Start the timeout timer
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting camera: {ex.Message}", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopScanner(); // Attempt to clean up if starting fails
            }
        }

        // Event handler for the Stop button click
        private void stopButton_Click(object sender, EventArgs e)
        {
            StopScanner(); // Stop the scanner and clean up resources
            this.Close(); // Close the barcode scanner form
        }

        // Method to stop the scanner and release resources
        private void StopScanner()
        {
            if (scanTimeoutTimer != null)
            {
                scanTimeoutTimer.Stop(); // Stop the timeout timer
            }

            // Add null check for _stopScanningEvent before calling Set()
            if (_stopScanningEvent != null)
            {
                _stopScanningEvent.Set(); // Signal all video processing tasks to exit
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                // Unsubscribe the event handler immediately to prevent new frame events
                videoSource.NewFrame -= video_NewFrame;
                videoSource.SignalToStop(); // Tell the video source to stop capturing frames
                // Wait for the video capture thread to terminate
                videoSource.WaitForStop(); // Removed the 3000 argument causing CS1501
                videoSource = null; // Clear the video source object
            }

            // Safely dispose of the image on the PictureBox (thread-safe with dispose check)
            if (videoPictureBox.InvokeRequired && !videoPictureBox.IsDisposed)
            {
                videoPictureBox.Invoke((MethodInvoker)delegate {
                    if (!videoPictureBox.IsDisposed)
                    {
                        videoPictureBox.Image?.Dispose(); // Dispose existing image if any
                        videoPictureBox.Image = null;     // Clear the PictureBox
                    }
                });
            }
            else if (!videoPictureBox.IsDisposed) // If already on UI thread or no invoke needed
            {
                videoPictureBox.Image?.Dispose();
                videoPictureBox.Image = null;
            }

            SetControlStates(true, false, true); // Reset control states to allow starting again
        }

        // Event handler for new frames from the video source
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // If the form is disposing, or a stop has been signaled, dispose the frame and return immediately
            if (this.IsDisposed || (_stopScanningEvent != null && _stopScanningEvent.WaitOne(0)))
            {
                ((Bitmap)eventArgs.Frame)?.Dispose(); // Dispose incoming frame
                return;
            }

            // Clone the frame for processing and display. The original eventArgs.Frame
            // might be reused or disposed by the AForge library after this event.
            Bitmap currentFrame = null;
            Bitmap displayClone = null;
            try
            {
                if (eventArgs.Frame == null) return; // Defensive check for null frame

                currentFrame = (Bitmap)eventArgs.Frame.Clone(); // Clone for decoding
                displayClone = (Bitmap)currentFrame.Clone();    // Clone for display

                // Display the frame on the PictureBox (thread-safe and dispose-safe)
                if (videoPictureBox.InvokeRequired && !videoPictureBox.IsDisposed)
                {
                    videoPictureBox.Invoke((MethodInvoker)delegate {
                        if (!videoPictureBox.IsDisposed)
                        {
                            videoPictureBox.Image?.Dispose(); // Dispose old image before setting new one
                            videoPictureBox.Image = displayClone;
                            displayClone = null; // PictureBox now owns this bitmap
                        }
                    });
                }
                else if (!videoPictureBox.IsDisposed)
                {
                    videoPictureBox.Image?.Dispose();
                    videoPictureBox.Image = displayClone;
                    displayClone = null; // PictureBox now owns this bitmap
                }

                // --- CRITICAL FIX: Offload barcode decoding to a background task ---
                // This prevents the video stream thread from being blocked by the potentially long-running Decode operation.
                Task.Run(() =>
                {
                    Bitmap frameToDecode = currentFrame; // Use local variable for task scope
                    try
                    {
                        if (this.IsDisposed || (_stopScanningEvent != null && _stopScanningEvent.WaitOne(0)))
                        {
                            frameToDecode?.Dispose(); // Dispose frame if stopping
                            return; // Exit task if stop signaled
                        }

                        // Defensive check: Ensure frameToDecode is not null or already disposed
                        if (frameToDecode == null || frameToDecode.PixelFormat == System.Drawing.Imaging.PixelFormat.Undefined)
                        {
                            return; // Frame is invalid, nothing to decode
                        }

                        lock (_lockObject) // Protect shared resources (barcodeReader, lastScanTime, lastBarcode)
                        {
                            if (barcodeReader != null)
                            {
                                var result = barcodeReader.Decode(frameToDecode);
                                if (result != null)
                                {
                                    // Debounce mechanism: only process if 3 seconds have passed
                                    // or if a different barcode is scanned. This prevents
                                    // rapid, repetitive scans of the same barcode, which is desirable.
                                    if ((DateTime.Now - lastScanTime).TotalSeconds > 3 || result.Text != lastBarcode)
                                    {
                                        lastScanTime = DateTime.Now; // Update last scan time
                                        lastBarcode = result.Text;    // Store the last scanned barcode

                                        // Process the scanned barcode (this will Invoke back to UI thread)
                                        // It no longer closes the form automatically here.
                                        this.Invoke(new Action(() => ProcessScannedBarcode(result.Text)));
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log decoding errors. Avoid MessageBox here as it's a background thread.
                        System.Diagnostics.Debug.WriteLine($"Error decoding frame in background task: {ex.Message}");
                        // Optionally, you could signal an error to the UI thread for display
                        if (!this.IsDisposed)
                        {
                            this.Invoke((MethodInvoker)(() =>
                            {
                                if (!this.IsDisposed)
                                {
                                    // Consider a less intrusive way to show this error, maybe a status label.
                                    // MessageBox.Show($"An error occurred during barcode decoding: {ex.Message}", "Decoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }));
                        }
                    }
                    finally
                    {
                        // Ensure the bitmap cloned for decoding is disposed after it's no longer needed
                        frameToDecode?.Dispose();
                    }
                });
            }
            catch (Exception ex)
            {
                // Handle exceptions during frame processing or cloning
                System.Diagnostics.Debug.WriteLine($"Error in video_NewFrame processing: {ex.Message}");
                displayClone?.Dispose(); // Ensure displayClone is disposed on error if not set to PictureBox
                currentFrame?.Dispose(); // Ensure currentFrame is disposed on error
                // Attempt a graceful stop if an unhandled error occurs during frame setup
                StopScanner();
                if (!this.IsDisposed)
                {
                    this.Invoke((MethodInvoker)this.Close); // Ensure Close is called on UI thread
                }
            }
        }

        private void ProcessScannedBarcode(string barcode)
        {
            scanTimeoutTimer.Stop(); // Stop the timeout timer immediately upon successful scan

            // If this method is called from a non-UI thread, marshal the call to the UI thread.
            if (this.InvokeRequired && !this.IsDisposed)
            {
                this.Invoke(new Action(() => ProcessScannedBarcode(barcode)));
                return;
            }

            if (this.IsDisposed) return; // Final check before UI operations if already disposing

            // FIXED: Removed automatic StopScanner() and this.Close() calls from here.
            // The form will now remain open after a scan.
            // The calling form (CashierOrder) must handle closing the scanner.
            try
            {
                // Raise the BarcodeScanned event. The CashierOrder form is subscribed to this.
                BarcodeScanned?.Invoke(this, barcode);
            }
            finally
            {
                // Optionally, if you still want the scanner to close *after* CashierOrder has processed it,
                // you would set DialogResult.OK here, and CashierOrder.Cashier_ScanOr_Click would then
                // proceed to close the scanner form if DialogResult.OK was returned.
                // For now, I'm just raising the event and keeping the scanner open.
                // If you wish it to close after the *first successful scan*, you would uncomment the following two lines:
                // this.DialogResult = DialogResult.OK;
                // this.Close();
            }
        }

        // Event handler for the timeout timer tick
        private void ScanTimeoutTimer_Tick(object sender, EventArgs e)
        {
            scanTimeoutTimer.Stop();
            MessageBox.Show("Scanning timed out. No barcode was detected.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            StopScanner();
            this.Close(); // Closes the form on timeout
        }

        // Event handler for when the form is closing
        private void Barcode_Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure all critical disposable resources are disposed during form closing.
            // StopScanner() is called by closeButton_Click and ProcessScannedBarcode,
            // but this is a final safeguard for unexpected closes (e.g., user clicking 'X').
            // Also ensure to dispose the ManualResetEvent and Timer here.
            StopScanner(); // Ensure scanner is stopped gracefully
            if (_stopScanningEvent != null)
            {
                _stopScanningEvent.Dispose();
                _stopScanningEvent = null; // Nullify to prevent double disposal
            }
            if (scanTimeoutTimer != null)
            {
                scanTimeoutTimer.Dispose();
                scanTimeoutTimer = null; // Nullify to prevent double disposal
            }
            if (barcodeReader is IDisposable disposableReader) // Check if BarcodeReader is disposable
            {
                disposableReader.Dispose();
                barcodeReader = null; // Nullify to prevent double disposal
            }
            // Note: videoSource is set to null in StopScanner()
        }

        // Empty event handler (from designer, no custom logic needed)
        private void barcodeResultLabel_TextChanged(object sender, EventArgs e) { }
    }
}

