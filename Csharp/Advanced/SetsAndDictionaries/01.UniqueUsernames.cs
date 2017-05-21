using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _01UniqueUsernames
        {
            public static void Solution()
            {
                int t = Int32.Parse(Console.ReadLine());

                HashSet<string> names = new HashSet<string>();

                for (int e = 0; e < t; e++)
                {
                    string name = Console.ReadLine();
                    names.Add(name);
                }

                foreach (var name in names)
                    Console.WriteLine(name);
            }
        }
    }
}
