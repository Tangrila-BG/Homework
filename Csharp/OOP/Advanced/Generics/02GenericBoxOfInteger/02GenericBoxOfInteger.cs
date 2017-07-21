using System;

namespace Csharp.OOP.Advanced.Generics._02GenericBoxOfInteger
{
    class _02GenericBoxOfInteger
    {
        public static void Solution()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                Console.WriteLine(new Box<int>(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
