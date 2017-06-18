using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _2UpperStrings
        {
            public static void Solution()
            {
                Console.WriteLine(string.Join(" ", Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(x => x.ToUpper())));
            }
        }
    }
}
