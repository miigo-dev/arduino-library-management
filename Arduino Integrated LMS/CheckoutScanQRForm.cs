using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Imaging.Filters;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing.QrCode;

namespace Arduino_Integrated_LMS
{
    public partial class CheckoutScanQRForm : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;

        public CheckoutScanQRForm()
        {
            InitializeComponent();
        }

        private void CheckoutScanQRForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap originalFrame = (Bitmap)eventArgs.Frame.Clone();

            // Convert the image to grayscale
            Bitmap grayscaleFrame = GrayscaleConversion(originalFrame);

            // Enhance contrast
            Bitmap contrastEnhancedFrame = EnhanceContrast(grayscaleFrame);

            // Binarize the image
            Bitmap binarizedFrame = Binarize(contrastEnhancedFrame);

            // Set the processed frame to the PictureBox
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose(); // Dispose the previous image to release resources
            }
            pictureBox1.Image = (Bitmap)binarizedFrame.Clone();

            // Decode QR code
            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(binarizedFrame);

            if (result != null)
            {
                SetQRCodeText(result.Text);
                // You can add additional logic here if needed
            }
        }

        private Bitmap GrayscaleConversion(Bitmap image)
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            return filter.Apply(image);
        }

        private Bitmap EnhanceContrast(Bitmap image)
        {
            ContrastCorrection contrastFilter = new ContrastCorrection(50);
            return contrastFilter.Apply(image);
        }

        private Bitmap Binarize(Bitmap image)
        {
            ContrastCorrection contrastFilter = new ContrastCorrection(100);
            contrastFilter.ApplyInPlace(image);

            Invert invertFilter = new Invert();
            invertFilter.ApplyInPlace(image);

            BradleyLocalThresholding thresholdFilter = new BradleyLocalThresholding();
            thresholdFilter.PixelBrightnessDifferenceLimit = 0.1f;
            thresholdFilter.ApplyInPlace(image);

            return image;
        }

        private void SetQRCodeText(string text)
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(() => SetQRCodeText(text)));
            }
            else
            {
                // Assuming listView1 is the name of your ListView control
                ListViewItem newItem = new ListViewItem(text);
                listView1.Items.Add(newItem);
            }
        }

        private void CheckoutScanQRForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }

        private void StopCapture()
        {
            if (captureDevice?.IsRunning == true)
            {
                captureDevice.Stop();
            }
        }
    }
}
