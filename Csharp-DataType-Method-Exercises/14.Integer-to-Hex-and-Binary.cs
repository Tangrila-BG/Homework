using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string hexadecimal = Convert.ToString(number, 16).ToUpper();
            string binaryNumber = Convert.ToString(number, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binaryNumber);
        }
    }
}