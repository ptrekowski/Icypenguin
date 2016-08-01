using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ImageCryptoSandbox
{
    public class Encrypt
    {
        public static byte[] EncryptAsymmetric(object obj)
        {
            var imageByteArray = new Byte[1];

            return imageByteArray;
        }

        public static byte[] EncryptSymmetric(byte[] byteArray)
        {
            //Image image = Image.FromFile(@"c:\users\pablo\documents\visual studio 2013\Projects\ImageCryptoSandbox\ImageCryptoSandbox\Images\yoga-final-3.jpg");
            //Image image = Image.FromFile(@"c:\users\pablo\documents\visual studio 2013\Projects\ImageCryptoSandbox\ImageCryptoSandbox\Images\penguin.jpg");
            

            //var byteArray = ImageHelpers.GetByteArrayFromImage(image);

            using (RijndaelManaged Crypto = new RijndaelManaged())
            {
                Crypto.Padding = PaddingMode.Zeros;
                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream CryptoStream = new CryptoStream(ms, Crypto.CreateEncryptor(Key, IV), CryptoStreamMode.Write))
                    {
                        CryptoStream.Write(byteArray, 0, byteArray.Length);
                        CryptoStream.FlushFinalBlock();
                        Crypto.Dispose();

                        return ms.ToArray();
                    }
                }
            }
            
        }

        public static void EncryptFile()
        {
            string file = "C:\\SampleFile.DLL";
            string password = "abcd1234";

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Algorithm.AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string fileEncrypted = "C:\\SampleFileEncrypted.DLL";

            File.WriteAllBytes(fileEncrypted, bytesEncrypted);
        }

        public static string EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Algorithm.AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }

    }
}
