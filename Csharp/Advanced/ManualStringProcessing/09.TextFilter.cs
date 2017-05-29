using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _09TextFilter
        {
            public static void Solution()
            {
                string[] bannedWords = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string sentence = Console.ReadLine();

                foreach (var bannedWord in bannedWords)
                {
                    var replacement = new string('*', bannedWord.Length);
                    sentence = sentence.Replace(bannedWord, replacement);
                }

                Console.WriteLine(sentence);
            }
        }
    }
}
