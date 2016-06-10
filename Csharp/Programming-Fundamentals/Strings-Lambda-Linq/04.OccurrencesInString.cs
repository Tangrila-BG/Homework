using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesInString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            var count = 0;
            var pos = 0;

            while (true)
            {
                pos = str.IndexOf(pattern, pos);
                if (pos == -1) break;
                count++;
                pos = pos + 1;
            }

            Console.WriteLine(count);
        }
    }
}