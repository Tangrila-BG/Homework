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
        public static class _06SentenceExtractor
        {
            public static void Solution()
            {
                var keyword = Console.ReadLine();
                var sentence = Console.ReadLine();

                var pattern = $@"[^.?!]*(?<=[.?\s!]){keyword}(?=[\s.?!])[^.?!]*[.?!]";

                Console.WriteLine(string.Join("\n",
                    Regex.Matches(sentence, pattern).OfType<Match>().Select(m => m.Value)));
            }
        }
    }
}
