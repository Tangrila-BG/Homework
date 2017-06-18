using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _3FirstName
        {
            public static void Solution()
            {
                var names = new SortedSet<string>(
                    Console.ReadLine()
                    .Trim()
                    .Split());

                var letters = new SortedSet<string>(Console.ReadLine().Trim().Split());

                var name = String.Empty;

                foreach (var n in names)
                {
                    if (letters.Any(letter => n.StartsWith(letter, StringComparison.OrdinalIgnoreCase)))
                    {
                        name = n;
                    }
                    if (name != String.Empty)
                        break;
                }

                Console.WriteLine(string.Join(" ", string.IsNullOrEmpty(name) ? "No match" : name));
            }
        }
    }
}
