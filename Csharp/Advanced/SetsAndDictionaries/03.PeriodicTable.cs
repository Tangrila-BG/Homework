using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _03PeriodicTable
        {
            static void Solution()
            {
                int t = int.Parse(Console.ReadLine());

                SortedSet<string> chemicalElements = new SortedSet<string>();

                for (int i = 0; i < t; i++)
                {
                    var elements = Console.ReadLine().Split();

                    foreach (string t1 in elements)
                        chemicalElements.Add(t1);
                }

                Console.WriteLine(string.Join(" ", chemicalElements.Distinct()));
            }
        }
    }
}
