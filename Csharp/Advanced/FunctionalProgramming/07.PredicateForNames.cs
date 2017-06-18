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
        public static class _07PredicateForNames
        {
            public static void Solution()
            {
                var length = int.Parse(Console.ReadLine().Trim());

                var words = Console.ReadLine().Trim().Split();

                Func<string, bool> equalOrLess = x => x.Length <= length;

                Console.WriteLine(string.Join("\n", words.Where(equalOrLess)));
            }
        }
    }
}
