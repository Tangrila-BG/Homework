using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.Generics._06GenericCountMethodDouble
{
    class _06GenericCountMethodDouble
    {
        public static void Solution()
        {
            var n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
                boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));

            var comparison = double.Parse(Console.ReadLine());

            Console.WriteLine(boxes.Count(x => x.CompareTo(comparison) > 0));
        }
    }
}
