using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (isPalindrome(i) && oneEvenDigit(i) &&
                    isSumDivBy7(i))
                    Console.WriteLine(i);
            }
        }

        private static bool isPalindrome(int number)
        {
            var str = number.ToString();
            int min = 0;
            int max = str.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = str[min];
                char b = str[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        private static bool oneEvenDigit(int number)
        {
            while (number > 0)
            {
                var digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool isSumDivBy7(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                var digit = number % 10;
                sum += digit;
                number /= 10;
            }

            if (sum % 7 == 0)
                return true;

            return false;
        }
    }
}