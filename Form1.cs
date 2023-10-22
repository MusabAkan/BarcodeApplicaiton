using ZXing;
using ZXing.Common;

namespace BarcodeApplicaiton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void btnGenerateBarcode_Click_1(object sender, EventArgs e)
        {
            string barcodeData = txtBarcodeData.Text;

            if (!string.IsNullOrEmpty(barcodeData))
            {
                var barcodeWriter = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new EncodingOptions { Height = 325, Width = 325 }
                };
                Bitmap barcodeBitmap = barcodeWriter.Write(barcodeData);
                pictureBox1.Image = barcodeBitmap;
            }
            else
            {
                MessageBox.Show("Barkod verisi giriniz.");
            }
        }

        private void btnReadBarcode_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);

                if (result != null)
                {
                    MessageBox.Show($"Barkod verisi: {result.Text}");
                }
                else
                {
                    MessageBox.Show("Barkod okunamadý veya geçersiz.");
                }
            }
            else
            {
                MessageBox.Show("Önce bir barkod üretmelisiniz.");
            }
        }
    }
}

