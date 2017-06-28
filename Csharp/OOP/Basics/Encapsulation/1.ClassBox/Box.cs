namespace Csharp.OOP.Basics.Encapsulation._1.ClassBox
{
    public static partial class _1ClassBox
    {
        private class Box
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            public Box(double length, double width, double height)
            {
                Length = length;
                Width = width;
                Height = height;
            }

            public double Volume()
            {
                return this.Length * this.Width * this.Height;
            }

            public double LateralSurfaceArea()
            {
                return 2 * (this.Length * this.Height + this.Width * this.Height);
            }

            public double SurfaceArea()
            {
                return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
            }

            public override string ToString()
            {
                return
                    $"Surface Area - {this.SurfaceArea():F2}\n" +
                    $"Lateral Surface Area - {this.LateralSurfaceArea():F2}\n" +
                    $"Volume - {this.Volume():F2}";
            }
        }
    }
}
