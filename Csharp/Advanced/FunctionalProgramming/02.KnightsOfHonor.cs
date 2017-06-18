using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _02KnightsOfHonor
        {
            public static void Solution()
            {
                Console.ReadLine()
                    .Split(new char[] { '\t', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList()
                    .ForEach(Print().Invoke);
            }

            private static Action<string> Print()
            {
                return (s) =>
                {
                    Console.WriteLine("Sir " + s);
                };
            }
        }
    }
}
