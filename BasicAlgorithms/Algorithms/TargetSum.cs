namespace BasicAlgorithms.Algorithms
{
    public static class TargetSum
    {
        public static bool TwoIntegerSumToTarget(int[] array, int target)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int k = 0; k < array.Length; k++)
                {
                    if (i != k)
                    {
                        int sum = array[i] + array[k];
                        if (sum == target)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
