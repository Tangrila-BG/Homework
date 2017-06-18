using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _06ReverseAndExclude
        {
            public static void Solution()
            {
                var numbers = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var divisor = int.Parse(Console.ReadLine());

                Predicate<int> isDivisibleBy = x => x % divisor == 0;

                Func<IEnumerable<int>, IEnumerable<int>> reverse = x => x.Reverse();
                Func<IEnumerable<int>, IEnumerable<int>> filter = x => x.Where(y => !isDivisibleBy(y));

                numbers = filter(reverse(numbers)).ToArray();

                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
