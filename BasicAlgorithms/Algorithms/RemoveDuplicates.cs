namespace BasicAlgorithms.Algorithms
{
    public static class RemoveDuplicates
    {
        public static string RemoveDupesChars(string input)
        {
            string table = string.Empty;
            string result = string.Empty;

            foreach(char value in input)
            {
                if (table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}
