using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing.Lab
{
    public partial class ManualStringProcessingLab
    {
        public static class _4SpecialWords
        {
            public static void Solution()
            {
                var separators = "()[]<>,-!? ".ToCharArray();

                var specialWords = Console.ReadLine().Trim().Split()
                    .ToDictionary(word => word, word => 0);

                var sentence = Console.ReadLine().Trim()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in sentence)
                {
                    if (specialWords.ContainsKey(word))
                        specialWords[word]++;
                }

                foreach (var specialWord in specialWords)
                    Console.WriteLine(specialWord.Key + " - " + specialWord.Value);
            }
        }
    }
}
