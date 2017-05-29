using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries.Lab
{
    public partial class SetsAndDictionariesLab
    {
        public static class _03CountSameValuesInArray
        {
            public static void Solution()
            {
                var numbers = new SortedDictionary<decimal, int>();

                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse);

                foreach (var num in input)
                {
                    if (!numbers.ContainsKey(num))
                        numbers.Add(num, 1);
                    else
                        numbers[num]++;
                }

                foreach (var kvp in numbers)
                    Console.WriteLine($"{kvp.Key} - {kvp.Value} times");

            }
        }
    }
}
