using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.RegularExpressions.Lab
{
    public partial class RegularExpressionsLab
    {
        public static class _2VowelCount
        {
            public static void Solution()
            {
                Console.WriteLine("Vowels: " + Regex.Matches(Console.ReadLine(), @"[aeiouyAEIOUY]").Count);
            }
        }
    }
}
