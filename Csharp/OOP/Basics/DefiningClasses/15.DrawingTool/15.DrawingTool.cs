using System;

namespace Csharp.OOP.Basics.DefiningClasses._15.DrawingTool
{
    public static partial class _15DrawingTool
    {
        public static void Solution()
        {
            var canvas = new CorDraw();
            var type = Console.ReadLine().Trim();
            Figure figure;

            int length = int.Parse(Console.ReadLine().Trim());

            if (type == "Square")
                figure = new Square(length);
            else
            {
                int width = int.Parse(Console.ReadLine().Trim());
                figure = new Rectangle(length, width);
            }

            canvas.Figure = figure;
            canvas.Figure.Draw();
        }
    }
}
