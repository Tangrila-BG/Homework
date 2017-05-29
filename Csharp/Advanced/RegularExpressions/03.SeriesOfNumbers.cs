using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.RegularExpressions
{
    public partial class RegularExpressions
    {
        public static class _03SeriesOfNumbers
        {
            public static void Solution()
            {
                var pattern = @"(.)\1+";
                var rgx = new Regex(pattern);

                var input = Console.ReadLine();

                Console.WriteLine(rgx.Replace(input, "$1"));
            }
        }
    }
}
