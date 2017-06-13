using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.RegularExpressions
{
    public partial class RegularExpressions
    {
        public static class _08ExtractHyperlinks
        {
            public static void Solution()
            {
                var pattern = @"<a([^>]*?)href\s*=\s*(""|')(.+?)\2";

                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END") break;

                    foreach (Match match in Regex.Matches(input, pattern))
                        Console.WriteLine(match.Groups[3]);

                }
            }
        }
    }
}
