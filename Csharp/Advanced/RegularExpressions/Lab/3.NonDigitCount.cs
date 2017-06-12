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
        public static class _3NonDigitCount
        {
            public static void Solution()
            {
                Console.WriteLine("Non-digits: " + Regex.Matches(Console.ReadLine(), @"\D").Count);
            }
        }
    }
}
