using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            var number = Console.ReadLine();

            try
            {
                long num = long.Parse(number);
                Console.WriteLine($"{num} can fit in:");
                if (num >= -128 && num <= 127)
                    Console.WriteLine($"* sbyte");
                if (num >= 0 && num <= 255)
                    Console.WriteLine($"* byte");
                if (num >= -32768 && num <= 32767)
                    Console.WriteLine($"* short");
                if (num >= 0 && num <= 65535)
                    Console.WriteLine($"* ushort");
                if (num >= -2147483648 && num <= 2147483647)
                    Console.WriteLine($"* int");
                if (num >= 0 && num <= 4294967295)
                    Console.WriteLine($"* uint");
                if (num >= -9223372036854775808 &&
                    num <= 9223372036854775807)
                    Console.WriteLine($"* long");
            }
            catch (Exception)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}