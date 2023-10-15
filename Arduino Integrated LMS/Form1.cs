using QRCoder;
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Arduino_Integrated_LMS
{
    public partial class Form1 : Form
    {
        private string websiteUrl = "http://192.168.1.12:80";

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateQRCode(string data)
        {
            Uri uri = new Uri(websiteUrl);

            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData qrData = qrGen.CreateQrCode(uri.AbsoluteUri, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);

            Bitmap qrCodeImage = qrCode.GetGraphic(10, Color.Black, Color.White, true);
            picBoxQR.Image = qrCodeImage;
            picBoxQR.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = txtStuNo.Text;
            GenerateQRCode(data);
        }

        static async Task Main(string[] args)
        {
            string pythonApiUrl = "http://localhost:80/"; // Replace with the actual URL

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string responseJson = await httpClient.GetStringAsync(pythonApiUrl);

                    // Parse the JSON response
                    var ipAddresses = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(responseJson);

                    // Display the IP addresses in your Windows Forms application
                    foreach (var ipAddress in ipAddresses)
                    {
                        MessageBox.Show(ipAddress);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}