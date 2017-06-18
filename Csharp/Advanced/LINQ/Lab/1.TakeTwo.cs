using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _1TakeTwo
        {
            public static void Solution()
            {
                Console.WriteLine(string.Join(" ", Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .Where(x => x >= 10 && x <= 20)
                    .Distinct()
                    .Take(2)));
            }
        }
    }
}
