using System;

namespace BasicAlgorithms.Algorithms
{
    public static class Anagram
    {
        public static string IsAnagram(string input1, string input2)
        {
            char[] char1 = input1.ToLower().ToCharArray();
            char[] char2 = input2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string newWord1 = new string(char1);
            string newWord2 = new string(char2);

            if (newWord1 == newWord2)
            {
                return "Inputs are ANAGRAM";
            }
            else
            {
                return "NOT ANAGRAM";
            }
        }
    }
}
