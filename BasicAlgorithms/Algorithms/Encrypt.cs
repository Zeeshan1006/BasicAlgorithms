using System;
using GenericClasses.CryptographyHandler;

namespace BasicAlgorithms.Algorithms
{
    public static class Encrypt
    {
        public static string EncryptString(string inputString)
        {
            string outputString = string.Empty;

            using (CryptographyHandler Ch = new CryptographyHandler())
            {
                outputString = Ch.EncryptValue(inputString);
            }

            return outputString;
        }

        public static string DecryptString(string inputString)
        {
            string outputString = string.Empty;

            using (CryptographyHandler ch = new CryptographyHandler())
            {
                outputString = ch.DecryptValue(inputString);
            }

            return outputString;
        }

        public static string EncryptPassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
    }
}
