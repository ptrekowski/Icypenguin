using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ImageCryptoSandbox
{
    public class Decrypt
    {
        public static byte[] DecryptSymmetric(byte[] byteArray)
        {
            using (RijndaelManaged Crypto = new RijndaelManaged())
            {
                Crypto.Padding = PaddingMode.Zeros;

                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };



                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    using (CryptoStream CryptoStream = new CryptoStream(ms, Crypto.CreateDecryptor(Key, IV), CryptoStreamMode.Write))
                    {
                        CryptoStream.Write(byteArray, 0, byteArray.Length);
                        CryptoStream.FlushFinalBlock();
                        Crypto.Dispose();

                        return ms.ToArray();
                    }
                }
            }
        }
    }
}
