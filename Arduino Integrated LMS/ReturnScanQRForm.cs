using AForge.Imaging.Filters;
using AForge.Video.DirectShow;
using AForge.Video;
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
using System.Data.SqlClient;

namespace Arduino_Integrated_LMS
{
    public partial class ReturnScanQRForm : Form
    {
        private SqlConnection conn;

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        private bool isConnectionOpen = false;

        public ReturnScanQRForm()
        {
            InitializeComponent();
            InitializeEvents();
            conn = DatabaseConnection.Instance.Connection;
        }

        private void InitializeEvents()
        {
            txtStudentNumberR.KeyPress += TxtStudentNumber_KeyPress;
        }

        private void TxtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void ReturnScanQRForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbDevice.Items.Add(filterInfo.Name);
            }
            cbDevice.SelectedIndex = 0;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap originalFrame = (Bitmap)eventArgs.Frame.Clone();
            Bitmap grayscaleFrame = GrayscaleConversion(originalFrame);
            Bitmap contrastEnhancedFrame = EnhanceContrast(grayscaleFrame);
            Bitmap binarizedFrame = Binarize(contrastEnhancedFrame);

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            pictureBox1.Image = (Bitmap)binarizedFrame.Clone();

            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(binarizedFrame);

            if (result != null)
            {
                string scannedData = result.Text;
                int shelfId = GetShelfIdFromScannedData(scannedData);
                string bookId = GetBookIdFromScannedData(scannedData);

                if (shelfId != -1 && !string.IsNullOrEmpty(bookId))
                {
                    DateTime currentDate = DateTime.Now;
                    DateTime returnDate = GetReturnDate(bookId);

                    if (returnDate == DateTime.MinValue)
                    {
                        MessageBox.Show($"Error: Return date not found for Book ID: {bookId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int daysLate = (int)(currentDate - returnDate).TotalDays;
                    int state = CalculateState(daysLate);

                    string message = $"Return to Shelf: {shelfId}\n[{GetStateDescription(state, daysLate)}]";
                    MessageBox.Show(message, "Book Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateBookState(bookId, state);
                }
                else
                {
                    MessageBox.Show("Invalid QR code or Shelf ID not found in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DateTime GetReturnDate(string bookId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT return_date FROM checkout WHERE book_id = @bookId";
                cmd.Parameters.AddWithValue("@bookId", bookId);

                object result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? (DateTime)result : DateTime.MinValue;
            }
        }

        private int CalculateState(int daysLate)
        {
            if (daysLate < 0)
            {
                return 1;
            }
            else if (daysLate <= 2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private string GetStateDescription(int state, int daysLate)
        {
            switch (state)
            {
                case 1:
                    return "Returned on time";
                case 2:
                    return $"Returned Late ({daysLate} Days)";
                case 3:
                    return $"Overdue ({daysLate} Days)";
                default:
                    return "Unknown State";
            }
        }

        private void UpdateBookState(string bookId, int state)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE checkout SET state = @state WHERE book_id = @bookId";
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.ExecuteNonQuery();
            }
        }

        private int GetShelfIdFromScannedData(string scannedData)
        {
            string[] parts = scannedData.Split(' ');

            foreach (string part in parts)
            {
                string[] keyValue = part.Split(':');

                if (keyValue.Length == 2)
                {
                    if (keyValue[0].Trim().Equals("shelfID", StringComparison.OrdinalIgnoreCase))
                    {
                        int shelfId;
                        if (int.TryParse(keyValue[1].Trim(), out shelfId))
                        {
                            return shelfId;
                        }
                    }
                }
            }
            return -1;
        }

        private string GetBookIdFromScannedData(string scannedData)
        {
            string[] parts = scannedData.Split(' ');

            foreach (string part in parts)
            {
                string[] keyValue = part.Split(':');

                if (keyValue.Length == 2)
                {
                    if (keyValue[0].Trim().Equals("bookID", StringComparison.OrdinalIgnoreCase))
                    {
                        return keyValue[1].Trim();
                    }
                }
            }
            return null;
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

        private void CheckoutForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (!isConnectionOpen)
            {
                conn.Open();
                isConnectionOpen = true;
            }

            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }
    }
}
