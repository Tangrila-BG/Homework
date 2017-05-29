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
        public static class _05ExtractEmail
        {
            public static void Solution()
            {
                var pattern =
                    @"(?<user>(?<=[\s""])[a-zA-Z0-9]+([-_\.])?[a-zA-Z0-9]+\b)@(?<host>([-a-zA-Z]+\.)+[a-zA-z]+)";

                var input = Console.ReadLine();

                Console.WriteLine(string.Join("\n",
                    Regex.Matches(input, pattern).OfType<Match>().Select(x => x.Value)));
            }
        }
    }
}
