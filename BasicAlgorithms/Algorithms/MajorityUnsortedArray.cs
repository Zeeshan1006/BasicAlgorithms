using System;
using System.Collections.Generic;

namespace BasicAlgorithms.Algorithms
{
    public static class MajorityUnsortedArray
    {
        public static int GetMajorityElement(params int[] inputArray)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int majority = inputArray.Length / 2;

            foreach (int i in inputArray)
                if (dictionary.ContainsKey(i))
                {
                    dictionary[i]++;
                    if (dictionary[i] > majority)
                        return i;
                }
                else
                    dictionary.Add(i, 1);

            throw new Exception("No majority element in this array");
        }
    }
}
