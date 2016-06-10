using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersInString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            int[] count = new int[char.MaxValue + 1];

            foreach (var letter in str)
            {
                count[letter]++;
            }

            for (int i = 0; i < count.Length; i++)
                if (count[i] > 0)
                {
                    {
                        var letter = (char)i;
                        var occurencies = count[i];
                        Console.WriteLine("{0} -> {1}", letter, occurencies);
                    }
                }
        }
    }
}