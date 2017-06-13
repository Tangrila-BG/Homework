using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming.Lab
{
    public partial class FunctionalProgrammingLab
    {
        public static class _2SumNumbers
        {
            public static void Solution()
            {
                Console.WriteLine(Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Select((number, index) => new KeyValuePair<int, int>(index + 1, number))
                    .Aggregate((a, b) => new KeyValuePair<int, int>(b.Key, a.Value + b.Value)).ToString()
                    .Trim(new char[] { '[', ']' })
                    .Replace(", ", "\n"));
            }
        }
    }
}
