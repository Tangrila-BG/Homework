using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var input = Console.ReadLine().Split().ToArray();
            List<int> used = new List<int>();
            for (int i = 0; used.Count <= input.Length-1; i++)
            {
                var index = random.Next(i % input.Length, input.Length - 1);
                if (used.Contains(index)) continue;
                used.Add(index);
                Console.WriteLine(input[index]);
            }
        }
    }
}
