using System;

namespace Csharp.OOP.Advanced.Generics._01GenericBoxOfString
{
    class _01GenericBoxOfString
    {
        public static void Solution()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                Console.WriteLine(new Box<string>(Console.ReadLine()));
        }
    }
}
