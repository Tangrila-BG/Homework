using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _08CustomComparator
        {

            public static void Solution()
            {

                var numbers = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Array.Sort(numbers, Comparison);
                Console.WriteLine(string.Join(" ", numbers));
            }

            private static int Comparison(int a, int b)
            {
                Func<int, bool> isEven = x => x % 2 == 0;

                if (isEven(a) && !isEven(b))
                    return -1;
                if (!isEven(a) && isEven(b))
                    return 1;
                if (a > b)
                    return 1;
                if (a < b)
                    return -1;

                return 0;
            }
        }
    }
}
