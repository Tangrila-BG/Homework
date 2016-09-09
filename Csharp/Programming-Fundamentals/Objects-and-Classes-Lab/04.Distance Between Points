using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var inputB = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point a = new Point
            {
                X = inputA[0],
                Y = inputA[1]
            };
            Point b = new Point
            {
                X = inputB[0],
                Y = inputB[1]
            };
            Console.WriteLine($"{a.CalcDistance(b):F3}");

        }

        class Point
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

    }
}
