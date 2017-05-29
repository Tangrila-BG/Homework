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
        public static class _01MatchFullName
        {
            public static void Solution()
            {
                var pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
                var rgx = new Regex(pattern);

                while (true)
                {
                    var input = Console.ReadLine();

                    if (input.ToLower() == "end")
                        break;

                    foreach (var match in rgx.Matches(input))
                    {
                        Console.WriteLine(match);
                    }
                }
            }
        }
    }
}
