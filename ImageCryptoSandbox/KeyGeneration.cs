using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCryptoSandbox
{
    public class KeyGeneration
    {
        public static byte[] GenerateUniqueKey()
        {
            byte[] key = GenerateGuid().ToByteArray();

            return key;
        }

        public static byte[] GenerateUniqueInitializationVector()
        {
            byte[] iv = GenerateGuid().ToByteArray();

            return iv;
        }

        private static Guid GenerateGuid()
        {
            Guid guid = new Guid();

            return guid;
        }
    }
}
