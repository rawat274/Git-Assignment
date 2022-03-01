namespace CSharp11
{
    public static class ExtensionMethods
    {
        public static bool CheckisOddNumber(this int num)
        {
            return (num % 2 == 0) ? false : true;
        }
        public static bool CheckisEvenNumber(this int num)
        {
            return (num % 2 != 0) ? false : true;
        }
        public static bool CheckisPrimeNumber(this int num)
        {
            int i = 0, m = 0, flag = 0;
            m = num / 2;
            for (i = 2; i < m; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            return (flag != 0) ? false : true;
        }
        public static bool CheckisDivisibleBy(this int num, int d)
        {
            return (num % d != 0) ? false : true;
        }
    }
}
