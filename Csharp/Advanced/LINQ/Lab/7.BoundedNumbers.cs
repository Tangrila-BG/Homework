using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _7BoundedNumbers
        {
            public static void Solution()
            {
                var bounds = Console.ReadLine().Trim().Split().Select(int.Parse);

                var result = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .Where(x => x >= bounds.Min() && x <= bounds.Max())
                    .ToArray();

                if (!result.Any())
                    return;
                else
                    Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
