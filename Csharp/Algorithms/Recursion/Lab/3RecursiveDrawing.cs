using System;

namespace Csharp.Algorithms.Recursion.Lab
{
    class _3RecursiveDrawing
    {
        public static void Solution()
        {
            RecursiveDraw(int.Parse(Console.ReadLine()));
        }

        public static void RecursiveDraw(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(new string('*', n));
            RecursiveDraw(n - 1);
            Console.WriteLine(new string('#', n));
        }
    }
}
