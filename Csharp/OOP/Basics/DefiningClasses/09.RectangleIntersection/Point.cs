namespace Csharp.OOP.Basics.DefiningClasses._09.RectangleIntersection
{
    public static partial class _09RectangleIntersection
    {
        private struct Point
        {
            public double X { get; private set; }
            public double Y { get; private set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
