using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0 ; i < t ; i++)
            {
                var elements = Console.ReadLine().Split();
                foreach (string t1 in elements)
                {
                    chemicalElements.Add(t1);
                }
            }

            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}
