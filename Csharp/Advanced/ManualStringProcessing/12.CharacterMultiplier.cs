using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _12CharacterMultiplier
        {
            public static void Solution()
            {
                string[] input = Console.ReadLine().Split();

                string str1 = input[0];
                string str2 = input[1];

                int minLen = Math.Min(str1.Length, str2.Length);
                int maxLen = Math.Max(str1.Length, str2.Length);
                int sum = 0;

                for (int i = 0; i < minLen; i++)
                    sum += str1[i] * str2[i];

                if (str1.Length != str2.Length)
                {
                    string longerInput = str1.Length > str2.Length
                        ? str1
                        : str2;

                    for (int i = minLen; i < maxLen; i++)
                        sum += longerInput[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
