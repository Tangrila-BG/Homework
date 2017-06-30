using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._09.RectangleIntersection
{
    public static partial class _09RectangleIntersection
    {
        public static void Solution()
        {
            var rectangles = new Dictionary<string, Rectangle>();

            var boundaries = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var n = boundaries[0];
            var m = boundaries[1];

            for (int i = 0; i < n; i++)
            {
                var rectInput = Console.ReadLine().Trim().Split();

                var id = rectInput[0];
                var width = double.Parse(rectInput[1]);
                var height = double.Parse(rectInput[2]);
                var x = double.Parse(rectInput[3]);
                var y = double.Parse(rectInput[4]);

                var point = new Point(x, y);

                var rectangle = new Rectangle(id, width, height, point);

                rectangles.Add(id, rectangle);
            }

            for (int i = 0; i < m; i++)
            {
                var rects = Console.ReadLine().Trim().Split();

                var rect1 = rectangles[rects[0]];
                var rect2 = rectangles[rects[1]];

                Console.WriteLine(rect1.DoesIntersect(rect2).ToString().ToLower());
            }
        }
    }
}
