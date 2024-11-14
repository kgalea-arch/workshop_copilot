namespace Exercise_Performance
{
    public class StringConcatenator
    {
        public static string MultiplyString(string seed, int times)
        {
            string result = seed;

            for (int i = 0; i < times; i++)
            {
                result += seed;
            }

            return result;
        }
    }
}
