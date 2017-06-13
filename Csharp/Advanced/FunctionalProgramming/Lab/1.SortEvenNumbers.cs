using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming.Lab
{
    public partial class FunctionalProgrammingLab
    {
        public static class _1SortEvenNumbers
        {
            public static void Solution()
            {
                Console.WriteLine(string.Join(", ", Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Where(x => x % 2 == 0)
                    .OrderBy(x => x)));
            }
        }
    }
}
