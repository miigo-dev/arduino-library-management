using QRCoder;
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Arduino_Integrated_LMS
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string sessionID;
        private string websiteUrl = "http://localhost:12345";

        public Form1()
        {
            InitializeComponent();

            try
            {
                string serverIp = "127.0.0.1";
                int serverPort = 12345;

                client = new TcpClient(serverIp, serverPort);
                stream = client.GetStream();

                sessionID = Guid.NewGuid().ToString();
            }
            catch (Exception ex)
            {
                
            }
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

            SendDataToServer(data, sessionID);
        }

        private void SendDataToServer(string data, string sessionID)
        {
            try
            {
                if (stream != null)
                {
                    string combinedData = $"{data},{sessionID}";
                    byte[] dataBytes = System.Text.Encoding.ASCII.GetBytes(combinedData);
                    stream.Write(dataBytes, 0, dataBytes.Length);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = txtStuNo.Text;
            GenerateQRCode(data);
        }
    }
}

