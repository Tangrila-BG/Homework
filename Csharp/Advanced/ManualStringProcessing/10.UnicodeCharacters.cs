using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _10UnicodeCharacters
        {
            public static void Solution()
            {
                Console.WriteLine(
                    string.Join("",
                        Console.ReadLine()
                        .Select(a => "\\u" + ((int)a).ToString("X4").ToLower())));
            }
        }
    }
}
