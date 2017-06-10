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
        public static class _07ValidUsernames
        {
            public static void Solution()
            {
                var pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";

                var words = Console.ReadLine();

                var usernames = Regex.Replace(words, @"\W+", " ")
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var regex = new Regex(pattern);

                var candidates = usernames
                    .Where(username => regex.IsMatch(username))
                    .ToArray();

                int maxSum = 0;
                string first = String.Empty;
                string second = String.Empty;

                for (int i = 1; i < candidates.Length; i++)
                {
                    int sum = candidates[i - 1].Length + candidates[i].Length;

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        first = candidates[i - 1];
                        second = candidates[i];
                    }

                }

                Console.WriteLine(first);
                Console.WriteLine(second);
            }
        }
    }
}
