using System;

namespace Csharp.Algorithms.Recursion.Lab
{
    class _2RecursiveFactorial
    {
        public static void Solution()
        {
            var n = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine(Factorial(n));
        }

        public static int Factorial(int n)
        {
            if (n < 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
