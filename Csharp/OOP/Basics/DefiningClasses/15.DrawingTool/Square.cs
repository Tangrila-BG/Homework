using System;

namespace Csharp.OOP.Basics.DefiningClasses._15.DrawingTool
{
    public static partial class _15DrawingTool
    {
        private class Square : Figure
        {
            public override void Draw()
            {
                Console.WriteLine("|{0}|", new string('-', this.Length));

                for (int i = 2; i < this.Length; i++)
                    Console.WriteLine("|{0}|", new string(' ', this.Length));

                Console.WriteLine("|{0}|", new string('-', this.Length));

            }

            public Square(int length)
            {
                this.Length = length;
            }
        }
    }
}
