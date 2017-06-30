using System;

namespace Csharp.OOP.Basics.DefiningClasses._15.DrawingTool
{
    public static partial class _15DrawingTool
    {
        private class Rectangle : Figure
        {
            public override void Draw()
            {
                Console.WriteLine("|{0}|", new string('-', this.Length));

                for (int i = 2; i < this.Width; i++)
                    Console.WriteLine("|{0}|", new string(' ', this.Length));

                Console.WriteLine("|{0}|", new string('-', this.Length));
            }

            public Rectangle(int length, int width)
            {
                this.Length = length;
                this.Width = width;
            }
        }
    }
}
