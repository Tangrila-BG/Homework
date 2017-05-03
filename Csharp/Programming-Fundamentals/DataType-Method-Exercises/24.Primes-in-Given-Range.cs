using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintPrimeRange(start, stop));
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

        public static string PrintPrimeRange(int start, int stop)
        {
            if (start > stop)
                return "(empty list)";

            List<int> listOfPrimes = new List<int>();

            for (int i = start; i <= stop; i++)
            {
                if (isPrime(i) == true || i == 2)
                    listOfPrimes.Add(i);
            }

            return string.Join(", ", listOfPrimes);
        }
    }
}