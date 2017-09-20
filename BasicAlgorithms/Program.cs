using System;
using BasicAlgorithms.Algorithms;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password");
            string input = string.Empty;
            input = Console.ReadLine();
            string result = Encrypt.EncryptString(input);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
