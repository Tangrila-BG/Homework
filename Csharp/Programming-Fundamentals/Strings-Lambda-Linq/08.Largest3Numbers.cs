using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sortedNums = arr.OrderBy(x => -x);
            var largest3Nums = sortedNums.Take(3);

            Console.WriteLine(string.Join(" ", largest3Nums));
        }
    }
}