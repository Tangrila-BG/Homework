using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _09ListOfPredicates
        {
            public static void Solution()
            {
                var n = int.Parse(Console.ReadLine().Trim());

                var divisors = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Func<int, int, bool> filter = (dividend, divisor) => dividend % divisor == 0;

                Console.WriteLine(string.Join(" ", CustomSelector(n, divisors, filter)));
            }

            private static IEnumerable<int> CustomSelector(int border, IEnumerable<int> divisors, Func<int, int, bool> predicate)
            {
                var result = new List<int>();
                for (int i = 1; i <= border; i++)
                {
                    var flag = true;

                    foreach (var divisor in divisors)
                    {
                        if (!predicate(i, divisor))
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                        result.Add(i);
                }

                return result;
            }
        }
    }
}
