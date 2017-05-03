using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            var a = 5;
            var b = 10;

            Console.WriteLine("Before: " + "\n" + "a" + " = " + a +
                "\n" + "b" + " = " + b);
            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After: " + "\n" + "a" + " = " + a +
                "\n" + "b" + " = " + b);
        }
    }
}