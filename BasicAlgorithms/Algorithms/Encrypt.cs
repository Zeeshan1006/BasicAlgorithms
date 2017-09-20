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
    }
}
