using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _03CustomMinFunction
        {
            public static void Solution()
            {
                Func<int[], int> minFunc = ints => ints.Min();

                Console.WriteLine(minFunc(
                    Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray()));
            }
        }
    }
}
