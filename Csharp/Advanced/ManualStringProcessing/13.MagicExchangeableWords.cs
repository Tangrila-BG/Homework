using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _13MagicExchangeableWords
        {
            public static void Solution()
            {
                string[] inputArray = Console.ReadLine().Trim().Split();
                HashSet<char> firstWord = new HashSet<char>(inputArray[0]);
                HashSet<char> secondWord = new HashSet<char>(inputArray[1]);
                Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
            }
        }
    }
}
