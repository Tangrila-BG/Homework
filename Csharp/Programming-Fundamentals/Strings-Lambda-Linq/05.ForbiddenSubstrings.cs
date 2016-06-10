using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenSubstrings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Console.WriteLine();
            var target = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < target.Length; i++)
            {
                text = text.Replace(target[i], new string('*', target[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}