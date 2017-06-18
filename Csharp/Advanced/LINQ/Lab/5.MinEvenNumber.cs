using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _5MinEvenNumber
        {
            public static void Solution()
            {
                try
                {
                    Console.WriteLine("{0:F2}",
                        Console.ReadLine()
                            .Trim()
                            .Split()
                            .Select(double.Parse)
                            .Where(x => Math.Abs(x % 2) < 1)
                            .Min());
                }
                catch (Exception)
                {
                    Console.Write("No match");
                }
            }
        }
    }
}
