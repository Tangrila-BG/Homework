using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing.Lab
{
    public partial class ManualStringProcessingLab
    {
        public static class _3ParseTags
        {
            public static void Solution()
            {
                var sentence = Console.ReadLine().Trim();
                var pattern = @"<upcase>(?<part>[\s\w]+)</upcase>";

                foreach (Match match in Regex.Matches(sentence, pattern))
                {
                    sentence = sentence.Replace(match.Groups[0].Value,
                        string.Join("", match.Groups["part"].Value.Select(char.ToUpper)));
                }

                Console.WriteLine(sentence);
            }
        }
    }
}
