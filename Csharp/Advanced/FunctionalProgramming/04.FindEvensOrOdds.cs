using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _04FindEvensOrOdds
        {
            public static void Solution()
            {
                var fromTo = Console.ReadLine().Trim().Split()
                    .Select(int.Parse)
                    .ToArray();

                var filter = Console.ReadLine().Trim();

                var numbers = Enumerable.Range(fromTo[0], fromTo[1] - fromTo[0] + 1);

                Predicate<int> IsEven = n => n % 2 == 0;

                PrintFilteredNumbers(numbers, filter, IsEven);
            }

            static void PrintFilteredNumbers(IEnumerable<int> numbers, string filter, Predicate<int> isEven)
            {
                var result = numbers.ToList();

                Console.WriteLine(filter == "even"
                    ? string.Join(" ", result.FindAll(isEven))
                    : string.Join(" ", result.FindAll(x => !isEven(x))));
            }
        }
    }
}
