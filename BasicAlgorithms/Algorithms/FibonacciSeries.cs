namespace BasicAlgorithms.Algorithms
{
    public static class FibonacciSeries
    {
        public static int IterativeApproach(int input)
        {
            int firstNumber = 0, secondNumber = 1, result = 0;

            if (input == 0)
                return 0;
            if (input == 1)
                return 1;

            for(int i = 2; i <= input; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            return result;
        }

        public static int RecursiveApproach(int input)
        {
            if (input == 0)
                return 0;
            if (input == 1)
                return 1;

            return RecursiveApproach(input - 1) + RecursiveApproach(input - 2);
        }

        public static int NthFibonacciNumber(int input)
        {
            if ((input == 0) || (input == 1))
            {
                return input;
            }
            else
            {
                return (NthFibonacciNumber(input - 1) + NthFibonacciNumber(input - 2));
            }
        }
    }
}
