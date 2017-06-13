using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming.Lab
{
    public partial class FunctionalProgrammingLab
    {
        public static class _4AddVAT
        {
            public static void Solution()
            {
                Console.WriteLine(string.Join("\n",
                    Console.ReadLine().Trim()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => (double.Parse(x) + double.Parse(x) * 0.2).ToString("F2"))));
            }
        }
    }
}
