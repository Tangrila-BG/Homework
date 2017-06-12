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
        public static class _5ExtractTags
        {
            public static void Solution()
            {
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END") break;

                    foreach (Match match in Regex.Matches(input, @"<[\/\-\""\'\=\!\s\w\d]+>"))
                        Console.WriteLine(match.Value);
                }
            }
        }
    }
}
