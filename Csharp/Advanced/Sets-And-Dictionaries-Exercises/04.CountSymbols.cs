using System;
using System.Collections.Generic;

namespace _04.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<char, int> symbols = new SortedList<char , int>();

            var input = Console.ReadLine();

            foreach (char c in input)
            {
                if (!symbols.ContainsKey(c))
                    symbols.Add(c, 0);

                symbols[c]++;
            }

            foreach (var kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }

        }
    }
}
