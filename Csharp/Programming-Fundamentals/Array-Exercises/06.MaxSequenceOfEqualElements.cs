using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceofEqualElements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().
                Select(int.Parse).ToArray();

            int start = 0;
            int count = 0;
            int max = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > max)
                    {
                        start = i - count;
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            var stop = start + max + 1;

            for (int i = start + 1; i <= stop; i++)
            {
                Console.Write(numbers[i]);
                if (i < stop)
                    Console.Write(" ");
            }
        }
    }
}