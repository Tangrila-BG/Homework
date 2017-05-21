using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _04CountSymbols
        {
            static void Solution()
            {
                SortedList<char, int> symbols = new SortedList<char, int>();

                var input = Console.ReadLine();

                foreach (char c in input)
                {
                    if (!symbols.ContainsKey(c))
                        symbols.Add(c, 0);

                    symbols[c]++;
                }

                foreach (var kvp in symbols)
                    Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
