// Program to find the prime factors of a number
namespace Practice
{
    class Program
    {
        private static Dictionary<int, int> factors = new Dictionary<int, int>();

        public static void FindPrimeFactors(int a)
        {
            if (a <= 1) Console.WriteLine(a);

            while (a % 2 == 0)
            {
                a = a / 2;
            }

            for (int i = 3; i < Math.Sqrt(a); i += 2)
            {
                while (a % i == 0)
                {
                    Console.WriteLine(i);
                    a = a/i;
                }
            }

            if (a > 2) Console.WriteLine(a);
        }

    }
}
