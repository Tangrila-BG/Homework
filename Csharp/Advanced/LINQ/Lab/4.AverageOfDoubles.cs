using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _4AverageOfDoubles
        {
            public static void Solution()
            {
                Console.WriteLine("{0:F2}", Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(double.Parse)
                    .Average());
            }
        }
    }
}
