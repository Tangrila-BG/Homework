using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming.Lab
{
    public partial class FunctionalProgrammingLab
    {
        public static class _3CountUppercaseWords
        {
            public static void Solution()
            {
                Console.WriteLine(string.Join("\n",
                    Console.ReadLine().Trim().Split()
                    .Where(x => x.StartsWith(char.ToUpper(x[0]).ToString()))));
            }
        }
    }
}
