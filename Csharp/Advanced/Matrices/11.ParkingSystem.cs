using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _11ParkingSystem
        {
            public static void Solution()
            {
                var dimensions = Console.ReadLine().Trim().Split()
                    .Select(int.Parse)
                    .ToArray();

                var rows = dimensions[0];
                var cols = dimensions[1];

                var parkingLot = new char[rows][];

                for (int row = 0; row < rows; row++)
                {
                    parkingLot[row] = new char[cols];
                    for (int col = 1; col < cols; col++)
                    {
                        parkingLot[row][col] = 'P';
                    }
                }

                foreach (var row in parkingLot)
                {
                    Console.WriteLine(string.Join(" ", row));
                }

                while (true)
                {
                    var parkingSpot = Console.ReadLine().Trim().Split();

                    if (parkingSpot[0].ToLower() == "stop")
                        break;

                    var z = int.Parse(parkingSpot[0]);
                    var x = int.Parse(parkingSpot[1]);
                    var y = int.Parse(parkingSpot[2]);
                    var carPoint = new Point(z, 0);
                    var target = new Point(x, y);
                    Console.WriteLine(LengthOfHypotenuse(carPoint, target));
                    var found = false;

                    var steps = 0;

                    if (!found)
                        Console.WriteLine($"Row {x} full");
                    else
                        Console.WriteLine(steps);
                }



            }

            struct Point
            {
                public int X { get; }
                public int Y { get; }

                public Point(int x, int y)
                {
                    X = x;
                    Y = y;
                }
            }

            private static double LengthOfHypotenuse(Point a, Point b)
            {
                double aSq = Math.Pow(a.X - b.X, 2); // horizontal length squared
                double bSq = Math.Pow(a.Y - b.Y, 2); // vertical length  squared
                return Math.Sqrt(aSq + bSq); // length of the hypotenuse
            }
        }
    }
}
