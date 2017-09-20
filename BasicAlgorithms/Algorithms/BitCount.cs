namespace BasicAlgorithms.Algorithms
{
    public static class BitCount
    {
        public static int SparseBitCount(int input)
        {
            int count = 0;
            while (input != 0)
            {
                count++;
                input &= (input - 1);
            }
            return count;
        }

        public static int IteratedBitCount(int input)
        {
            int test = input;
            int count = 0;
            while (test != 0)
            {
                if ((test & 1) == 1)
                {
                    count++;
                }
                test >>= 1;
            }
            return count;
        }

        /// <summary>
        /// Precomputed bit counts
        /// </summary>

        static int[] _bitCounts;

        public static void InitializeBitCount()
        {
            _bitCounts = new int[65536];
            int position1 = -1;
            int position2 = -1;

            for(int i = 1; i < 65536; i++, position1++)
            {
                if (position1 == position2)
                {
                    position1 = 0;
                    position2 = i;
                }
                _bitCounts[i] = _bitCounts[position1] + 1;
            }
        }

        public static int PrecomputedBitCount(int input)
        {
            return _bitCounts[input & 65535] + _bitCounts[(input >> 16) & 65535];
        }
    }
}
