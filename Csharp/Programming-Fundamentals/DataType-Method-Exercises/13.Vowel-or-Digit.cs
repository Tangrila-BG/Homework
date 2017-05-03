using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelORdigit
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            var input = Convert.ToChar(Console.ReadLine());

            if ((input == 'a') || (input == 'i') || (input == 'e') ||
                (input == 'u') || (input == 'o'))

                Console.WriteLine("vowel");
            else if ((input >= '0') && (input <= '9'))
                Console.WriteLine("digit");
            else
                Console.WriteLine("other");
        }
    }
}