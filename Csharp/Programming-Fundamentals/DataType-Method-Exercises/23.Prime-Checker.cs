using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(number));
        }

        public static bool isPrime(long number)
        {
            long boundary = (long)Math.Floor(Math.Sqrt(number));

            if (number == 1 || number % 2 == 0)
                return false;
            if (number == 2)
                return true;

            for (long i = 2; i <= boundary; ++i)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}