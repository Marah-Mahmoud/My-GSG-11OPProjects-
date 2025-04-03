namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                sum += num;
            return sum;
        }

        public static string RepeatString(this string str, int repets)
        {
            string result = "";
            for (int i = 0; i < repets; i++)
                result += str;
            return result;
        }
    }
}
