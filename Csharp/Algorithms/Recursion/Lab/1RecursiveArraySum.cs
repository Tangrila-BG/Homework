using System;
using System.Linq;

namespace Csharp.Algorithms.Recursion.Lab
{
    class _1RecursiveArraySum
    {
        public static void Solution()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(RecursiveSum(numbers, 0));
        }

        public static int RecursiveSum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + RecursiveSum(array, index + 1);
        }

    }
}
