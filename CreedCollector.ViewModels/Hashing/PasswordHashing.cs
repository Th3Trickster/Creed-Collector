using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.ViewModels.Hashing
{
    public class PasswordHashing
    {
        public static byte[] CalculateHash(byte[] inputBytes)
        {
            SHA256Managed algorithm = new SHA256Managed();
            algorithm.ComputeHash(inputBytes);
            return algorithm.Hash;
        }

        public static bool SequenceEquals(byte[] originalByteArray, byte[] newByteArray)
        {
            if (originalByteArray == null || newByteArray == null)
            {
                throw new ArgumentNullException(originalByteArray == null ? "originalByteArray" : "newByteArray",
                    "The byte arrays supplied may not be null.");
            }

            if (originalByteArray.Length != newByteArray.Length)
            {
                return false;
            }

            for (int i = 0; i < originalByteArray.Length; i++)
            {
                if (originalByteArray[i] != newByteArray[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
