using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            long a = long.Parse(Console.ReadLine());

            Console.WriteLine(NameOfLastDigit(a));
        }

        public static string NameOfLastDigit(long a)
        {
            a = Math.Abs(a);
            string[] digitNames = {"zero", "one", "two", "three",
                "four", "five", "six", "seven", "eight", "nine"};

            while (a > 10)
                a = a % 10;

            bool[] compare = { (a == 0), (a == 1), (a == 2), (a == 3),
                (a == 4), (a == 5), (a == 6), (a == 7), (a == 8), (a == 9)};

            for (int i = 0; i < compare.Length; i++)
            {
                if (compare[i] == true)
                    return digitNames[i];
            }

            return "problem";
        }
    }
}