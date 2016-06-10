using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().
                Select(decimal.Parse).ToArray();

            SortedDictionary<decimal, int> counts = new SortedDictionary<decimal, int>();

            foreach (var num in numbers)
            {
                counts[num] = 0;
            }
            foreach (var num in numbers)
            {
                counts[num]++;
            }

            foreach (var i in counts.Keys)
            {
                if (counts[i] > 0)
                    Console.WriteLine("{0} -> {1}", i, counts[i]);
            }
        }
    }
}