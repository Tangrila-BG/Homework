using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = numbers.Length / 4;
            var left = numbers.Take(k).Reverse();
            var right = numbers.Reverse().Take(k);
            var middle = numbers.Skip(k).Take(k * 2);
            var sum = left.Concat(right).Zip(middle, (x, y) => x + y);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}