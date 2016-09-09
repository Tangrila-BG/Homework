using System;
using System.Linq;

namespace _06.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Rectangle rectangle1 = new Rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
            Rectangle rectangle2 = new Rectangle
            {
                Left = input2[0],
                Top = input2[1],
                Width = input2[2],
                Height = input2[3]
            };

            Console.WriteLine(
                rectangle1.IsInside(rectangle2) ? "Inside" : "Not inside");
        }

        class Rectangle
        {
            public double Top { get; set; }
            public double Left { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            public double Right() {return Left + Width;}

            public double Bottom() { return Top + Height;}

            public bool IsInside(Rectangle r2)
            {
                var r1 = this;

                return r1.Left >= r2.Left &&
                       r1.Right() <= r2.Right() &&
                       r1.Top <= r2.Top &&
                       r1.Bottom() <= r2.Bottom();
            }
        }
    }
}
