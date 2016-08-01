using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageCryptoSandbox
{
    public partial class Form1 : Form
    {
        public byte[] original;
        public byte[] encrypted;
        public byte[] decrypted;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPicture_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"c:\users\pablo\documents\visual studio 2013\Projects\ImageCryptoSandbox\ImageCryptoSandbox\Images\yoga-final-3.jpg");
            original = ImageHelpers.GetByteArrayFromImage(image);

            picBox.Image = image;

            for (var i = 0; i < 100; i++)
            {
                txtBoxOriginal.Text += original[i].ToString() + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(decrypted))
            {
                picBoxEncrypted.Image = Image.FromStream(ms);
            }
            
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
            //encrypted = Encrypt.EncryptSymmetric(original);
            byte[] passwordBytes = Encoding.UTF8.GetBytes("password");

            encrypted = AES_Algorithm.AES_Encrypt(original, passwordBytes);

            for (var i = 0; i < 100; i++)
            {
                txtBoxEncrypted.Text += encrypted[i].ToString() + " ";
            }

            var image = ImageHelpers.byteArrayToImage(encrypted);
            picBoxShowEncrypted.Image = image;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //decrypted = Decrypt.DecryptSymmetric(encrypted);
            byte[] passwordBytes = Encoding.UTF8.GetBytes("password");
            decrypted = AES_Algorithm.AES_Decrypt(encrypted, passwordBytes);

            for (var i = 0; i < 100; i++)
            {
                txtBoxDecrypted.Text += decrypted[i].ToString() + " ";
            }
            
        }

        private void btnSaveEncrypted_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK && encrypted != null)
            {
                string filename = saveFileDialog.FileName;
                //string path = saveFileDialog.
                FileHelper.SaveCipherTextToFile(encrypted, filename);
            }
        }

        private void btnShowEncryptedImage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            original = null;
            encrypted = null;
            decrypted = null;

            DialogResult result = openImageFile.ShowDialog();

            string filename = openImageFile.FileName;
            string path = Path.GetExtension(filename);


            // hack to find if the file has a default value of "file" which is null or empty string
            if (path == "")
            {
                encrypted = FileHelper.ReadCipherTextFromFile(openImageFile.FileName);
                original = Decrypt.DecryptSymmetric(encrypted);
                for (var i = 0; i < 100; i++)
                {
                    txtBoxOriginal.Text += original[i] + " ";
                }


                using (MemoryStream ms = new MemoryStream(original))
                {
                    Image img = ImageHelpers.GetImageFromByteArray(ms.ToArray());
                    picBox.Height = img.Height;
                    picBox.Width = img.Width;
                    picBox.Image = img;
                }
            }
            else
            {
                var imageArray = FileHelper.ReadAllBytesFromFile(openImageFile.FileName);

                original = imageArray;

                ImageConverter imgConverter = new ImageConverter();

                picBox.Image = (Image)imgConverter.ConvertFrom(imageArray);
            }
         
        }

        private void btnClearnEncryption_Click(object sender, EventArgs e)
        {
            txtBoxOriginal.Clear();
            txtBoxEncrypted.Clear();
            txtBoxDecrypted.Clear();
        }

    }
}
