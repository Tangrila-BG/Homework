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
        public static class _1MatchCount
        {
            public static void Solution()
            {
                var needle = Console.ReadLine();

                var hay = Console.ReadLine();

                Console.WriteLine(Regex.Matches(hay, needle).Count);
            }
        }
    }
}
