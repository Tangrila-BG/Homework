using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(NthFibonnaci(number));
        }

        public static int NthFibonnaci(int number)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i <= number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}