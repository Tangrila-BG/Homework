using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _6FindAndSumIntegers
        {
            public static void Solution()
            {
                var numbers = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(n =>
                    {
                        long value;
                        bool success = long.TryParse(n, out value);
                        return new { value, success };
                    })
                    .Where(b => b.success)
                    .Select(x => x.value)
                    .ToList();

                if (numbers.Count == 0)
                {
                    Console.WriteLine("No match");
                    return;
                }
                Console.WriteLine(numbers.Sum());

            }
        }
    }
}
