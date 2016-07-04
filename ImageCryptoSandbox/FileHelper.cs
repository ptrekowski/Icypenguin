using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImageCryptoSandbox
{
    public class FileHelper
    {
        public static void SaveCipherTextToFile(byte[] cipherTextArray, string path)
        {
            File.WriteAllBytes(path, cipherTextArray);
        }

        public static byte[] ReadCipherTextFromFile(string path)
        {
            var encrypted = File.ReadAllBytes(path);
            return encrypted;
        }

        public static byte[] ReadAllBytesFromFile(string path)
        {
            var original = File.ReadAllBytes(path);

            return original;
        }
    }
}
