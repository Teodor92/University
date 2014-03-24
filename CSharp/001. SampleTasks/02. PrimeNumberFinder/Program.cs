namespace _02.PrimeNumberFinder
{
    using System;

    public class Program
    {
        internal static void Main(string[] args)
        {
            decimal endInterval = decimal.Parse(Console.ReadLine());

            while (!IsInt(endInterval))
            {
                endInterval = decimal.Parse(Console.ReadLine());
            }

            bool isPrime = true;

            for (int i = 2; i < endInterval; i++)
            {
                for (int j = 2; j < endInterval / 2; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write("{0} ", i);
                }

                isPrime = true;
            }

            Console.WriteLine();
        }

        private static bool IsInt(decimal number)
        {
            return number % 1 == 0;
        }
    }
}
