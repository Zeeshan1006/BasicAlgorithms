using System;

namespace BasicAlgorithms.Algorithms
{
    public static class Palindrome
    {
        public static string GetLongestPalindrome(string input)
        {
            int rightIndex = 0, leftIndex = 0;
            var x = "";
            string currentPalindrome = string.Empty;
            string longestPalindrome = string.Empty;

            for(int currentIndex = 1; currentIndex < input.Length - 1; currentIndex++)
            {
                leftIndex = currentIndex - 1;
                rightIndex = currentIndex + 1;
                while (leftIndex >= 0 && rightIndex < input.Length)
                {
                    if (input[leftIndex] != input[rightIndex])
                    {
                        break;
                    }

                    currentPalindrome = input.Substring(leftIndex, rightIndex - leftIndex + 1);
                    if (currentPalindrome.Length > x.Length)
                        x = currentPalindrome;
                    leftIndex--;
                    rightIndex++;
                }
            }
            return x;
        }

        public static string PalindromeNumber(int input)
        {
            int rem, sum = 0, temp;
            Convert.ToInt32(input);
            temp = input;
            while (input > 0)
            {
                rem = input % 10;
                input = input / 10;
                sum = sum * 10 + rem;
            }

            if (temp == sum)
            {
                return "Number is Palindrome";
            }
            else
            {
                return "Number is not palindrome";
            }
        }
    }
}
