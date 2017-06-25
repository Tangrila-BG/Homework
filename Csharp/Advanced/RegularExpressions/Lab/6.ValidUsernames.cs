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
        public static class _6ValidUsernames
        {
            public static void Solution()
            {
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END") break;

                    Console.WriteLine(Regex.Match(input, @"^[\-\w]{3,16}$").Success ? "valid" : "invalid");
                }
            }
        }
    }
}
