using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Imaging.Filters;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing.QrCode;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace Arduino_Integrated_LMS
{
    public partial class CheckoutScanQRForm : Form
    {
        private SqlConnection conn;

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        private List<string> accumulatedDataList = new List<string>();
        private bool isConnectionOpen = false;
        private string lastScannedData = null;

        public CheckoutScanQRForm()
        {
            InitializeComponent();
            conn = DatabaseConnection.Instance.Connection;
        }

        private void CheckoutScanQRForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbDevice.Items.Add(filterInfo.Name);
            }
            cbDevice.SelectedIndex = 0;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentNumber.Text))
            {
                MessageBox.Show("Please input your student number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

                if (!IsDataAlreadyInList(scannedData) && lastScannedData != scannedData)
                {
                    SetQRCodeText(scannedData);
                    accumulatedDataList.Add(scannedData);
                    lastScannedData = scannedData;
                }
            }
        }


        private bool CheckIfBookExists(string bookId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(*) FROM checkout WHERE book_id = @bookId";
                cmd.Parameters.AddWithValue("@bookId", bookId);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
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


        private bool IsDataAlreadyInList(string data)
        {
            if (listView1.InvokeRequired)
            {
                return (bool)listView1.Invoke(new Func<string, bool>(IsDataAlreadyInList), data);
            }
            else
            {
                return listView1.Items.Cast<ListViewItem>().Any(item => item.Text == data);
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

        private void StopThatShi()
        {
            StopCapture();
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(() => listView1.Items.Clear()));
            }
            else
            {
                listView1.Items.Clear();
            }
            txtStudentNumber.ResetText();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (accumulatedDataList.Count > 0)
            {
                try
                {
                    if (!isConnectionOpen)
                    {
                        conn.Open();
                        isConnectionOpen = true;
                    }

                    string studentNumber = txtStudentNumber.Text;
                    foreach (string scannedData in accumulatedDataList)
                    {
                        string bookId = GetBookIdFromScannedData(scannedData);
                        if (!string.IsNullOrEmpty(bookId) && CheckIfBookExists(bookId))
                        {
                            MessageBox.Show("Book already exists in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            StopThatShi();
                            return;
                        }

                        // Insert book-related information
                        if (!string.IsNullOrEmpty(bookId))
                        {
                            DateTime currentDate = DateTime.Now.Date;
                            DateTime returnDate = currentDate.AddDays(4).Date;

                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Connection = conn;
                                cmd.Parameters.Clear();
                                cmd.CommandText = "INSERT INTO checkout (student_number, book_id, shelf_id, borrow_date, return_date) VALUES (@studentNumber, @bookId, @shelfId, @borrowDate, @returnDate)";
                                cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                                cmd.Parameters.AddWithValue("@bookId", bookId);
                                cmd.Parameters.AddWithValue("@shelfID", GetShelfIdFromScannedData(scannedData));
                                cmd.Parameters.AddWithValue("@borrowDate", currentDate);
                                cmd.Parameters.AddWithValue("@returnDate", returnDate);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Added to database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (isConnectionOpen)
                    {
                        conn.Close();
                        isConnectionOpen = false;
                    }
                }
            }

            StopThatShi();
        }
    }
}