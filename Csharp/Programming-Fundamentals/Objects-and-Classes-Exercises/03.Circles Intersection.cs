using System;
using System.Linq;

namespace _03.CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point
            {
                X = input[0],
                Y = input[1]
            };
            Point point2 = new Point
            {
                X = input2[0],
                Y = input2[1]
            };

            Circle c1 = new Circle
            {
                Center = point,
                Radius = input[2],
            };

            Circle c2 = new Circle
            {
                Center = point2,
                Radius = input2[2],
            };

            Console.WriteLine(c1.Intersect(c2) ? "Yes" : "No");
        }

        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }

            public bool Intersect(Circle c2)
            {
                var c1 = this;
                var distanceBetweenCenters = c1.Center.CalcDistance(c2.Center);
                var combinedRadius = c1.Radius + c2.Radius;
                return distanceBetweenCenters <= combinedRadius;
            }
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int CalcDistance(Point p2)
            {
                var p1 = this;
                var sideA = Math.Abs(p1.X - p2.X);
                var sideB = Math.Abs(p1.Y - p2.Y);
                var cPow = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
                return (int) Math.Sqrt(cPow);
            }
        }
    }
}
