using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.Generics._05GenericCountMethodStrings
{
    class _05GenericCountMethodStrings
    {
        public static void Solution()
        {
            var n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
                boxes.Add(new Box<string>(Console.ReadLine()));

            var comparison = Console.ReadLine();

            Console.WriteLine(boxes.Count(x => x.CompareTo(comparison) > 0));
        }
    }
}
