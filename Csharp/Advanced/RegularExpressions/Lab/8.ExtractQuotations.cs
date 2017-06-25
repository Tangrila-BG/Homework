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
        public static class _8ExtractQuotations
        {
            public static void Solution()
            {
                foreach (Match match in Regex.Matches(Console.ReadLine(), @"""([^""]*)""|'([^']*)'"))
                    Console.WriteLine(match.Groups[2].Value != "" ? match.Groups[2] : match.Groups[1]);
            }
        }
    }
}
