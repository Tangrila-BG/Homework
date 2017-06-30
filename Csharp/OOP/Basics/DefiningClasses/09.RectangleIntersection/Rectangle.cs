namespace Csharp.OOP.Basics.DefiningClasses._09.RectangleIntersection
{
    public static partial class _09RectangleIntersection
    {
        private class Rectangle
        {
            public string Id { get; }
            public string ID { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            public Point TopLeftPoint { get; set; }

            public bool DoesIntersect(Rectangle rect)
            {
                var a = this.TopLeftPoint;
                var b = rect.TopLeftPoint;

                return !(a.X + this.Width < b.X)
                    && !(b.X + rect.Width < a.X)
                    && !(a.Y + this.Height < b.Y)
                    && !(b.Y + rect.Height < a.Y);
            }

            public Rectangle(string id, double width, double height, Point topLeftPoint)
            {
                Id = id;
                Width = width;
                Height = height;
                TopLeftPoint = topLeftPoint;
            }
        }
    }
}
