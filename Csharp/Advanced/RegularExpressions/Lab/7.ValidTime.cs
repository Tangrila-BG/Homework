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
        public static class _7ValidTime
        {
            public static void Solution()
            {
                var pattern = @"^(0[0-9]|1[012])\:[0-5][0-9]\:[0-5][0-9] [AP]M$";
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END") break;

                    Console.WriteLine(Regex.Match(input, pattern).Success ? "valid" : "invalid");
                }
            }
        }
    }
}
