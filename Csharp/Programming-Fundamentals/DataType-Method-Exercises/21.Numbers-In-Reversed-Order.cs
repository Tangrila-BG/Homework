using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(NumberReversed(number));
        }

        public static string NumberReversed(double number)
        {
            var result = number.ToString().ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }
    }
}