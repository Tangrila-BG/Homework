using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _11Palindromes
        {
            public static void Solution()
            {
                char[] separators = " ,.?!".ToCharArray();

                var input = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string[] result = input.Where(IsPalindrome)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToArray();

                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
            private static bool IsPalindrome(string str)
            {
                int i = 0;
                int j = str.Length - 1;

                while (i < j)
                {
                    if (str[i] != str[j])
                        return false;

                    i++;
                    j--;
                }

                return true;
            }
        }
    }
}
