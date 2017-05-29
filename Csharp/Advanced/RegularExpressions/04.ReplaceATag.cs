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
        public static class _04ReplaceATag
        {
            public static void Solution()
            {
                var pattern = @"<a(.*href(\s+)?=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";

                while (true)
                {
                    var input = Console.ReadLine();

                    if (input.ToLower() == "end")
                        break;

                    Console.WriteLine(Regex.Replace(input, pattern, @"[URL$1]$3[/URL]"));
                }
            }
        }
    }
}
