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
        public static class _02MatchPhoneNumber
        {
            public static void Solution()
            {
                var pattern = @"(\+359)-\d-\d{3}-\d{4}\b|(\+359) \d \d{3} \d{4}\b";
                var rgx = new Regex(pattern);

                while (true)
                {
                    var input = Console.ReadLine();

                    if (input.ToLower() == "end")
                        break;

                    foreach (Match match in rgx.Matches(input))
                    {
                        Console.WriteLine(match.Value);
                    }
                }
            }
        }
    }
}
