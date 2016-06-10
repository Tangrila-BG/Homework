using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'\\/!? ".ToCharArray();

            string[] str = Console.ReadLine().ToLower().
                Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var result = str.Where(w => w.Length < 5).
                OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}