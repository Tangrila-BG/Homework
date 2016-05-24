using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i < number; i++)
            {
                factorial += (i * factorial);
            }
            return factorial;
        }
    }
}