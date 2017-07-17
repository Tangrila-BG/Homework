using System;
using System.Linq;

namespace Csharp.Algorithms.Recursion.Lab
{
    class _5GeneratingCombinations
    {
        public static void Solution()
        {
            var array = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine().Trim());

            RecursiveCombinations(array, new int[n], 0, 0);
        }

        public static void RecursiveCombinations(int[] set, int[] arr, int index, int border)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = border; i < set.Length; i++)
            {
                arr[index] = set[i];
                RecursiveCombinations(set, arr, index + 1, i + 1);
            }
        }
    }
}