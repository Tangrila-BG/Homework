using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            while (t-- > 0)
            {
                var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                var point = new Point
                {
                    X = input[0],
                    Y = input[1]
                };
                points.Add(point);
            }

            var result = FindClosestPoints(points);

            Console.WriteLine($"{result[0].CalcDistance(result[1]):F3}\n" +
                              $"({result[0].X}, {result[0].Y})\n" +
                              $"({result[1].X}, {result[1].Y})");
        }

        internal class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public double CalcDistance(Point p2)
            {
                var p1 = this;
                var sideA = Math.Abs(p1.X - p2.X);
                var sideB = Math.Abs(p1.Y - p2.Y);
                var cPow = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
                return Math.Sqrt(cPow);
            }
        }

        public static Point[] FindClosestPoints(List<Point> points)
        {
            double min = double.MaxValue;
            Point point1 = new Point();
            Point point2 = new Point();

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j <= points.Count - 1; j++)
                {
                    if (min > points[i].CalcDistance(points[j]))
                    {
                        min = points[i].CalcDistance(points[j]);
                        point1 = points[i];
                        point2 = points[j];
                    }
                }
            }
            return new Point[] { point1, point2 };
        }
    }
}
