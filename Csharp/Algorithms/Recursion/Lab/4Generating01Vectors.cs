using System;

namespace Csharp.Algorithms.Recursion.Lab
{
    class _4Generating01Vectors
    {
        public static void Solution()
        {
            var n = int.Parse(Console.ReadLine().Trim());

            RecursiveBits(new int[n], 0);
        }

        public static void RecursiveBits(int[] bits, int index)
        {
            if (index > bits.Length - 1)
            {
                Console.WriteLine(string.Join("", bits));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                bits[index] = i;
                RecursiveBits(bits, index + 1);
            }
        }
    }
}
