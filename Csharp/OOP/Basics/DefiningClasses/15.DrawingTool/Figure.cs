namespace Csharp.OOP.Basics.DefiningClasses._15.DrawingTool
{
    public static partial class _15DrawingTool
    {
        private abstract class Figure
        {
            protected int Length { get; set; }
            protected int Width { get; set; }

            public abstract void Draw();
        }
    }
}
