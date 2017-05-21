using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _07FixEmails
        {
            static void Solution()
            {
                var emailBook = new Dictionary<string, string>();

                int t = 0;
                var name = "-1";

                while (true)
                {

                    var input = Console.ReadLine();

                    if (input.ToLower() == "stop")
                        break;

                    if (t % 2 == 0)
                    {
                        name = input;
                        emailBook.Add(input, "");
                    }
                    else if (t % 2 == 1)
                        emailBook[name] = input;

                    t++;
                    t %= 2;
                }

                var filter = emailBook.Where(x => !x.Value.Contains(".us") || x.Value.Contains(".uk"));

                foreach (var kvp in filter)
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
