using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            bool found = false;

            for (int current = 0; current < numbers.Length; current++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int right = current + 1; right < numbers.Length; right++)
                {
                    sumRight += numbers[right];
                }
                for (int left = 0; left < current; left++)
                {
                    sumLeft += numbers[left];
                }

                if (sumRight == sumLeft)
                {
                    Console.WriteLine(current);
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("no");
        }
    }
}