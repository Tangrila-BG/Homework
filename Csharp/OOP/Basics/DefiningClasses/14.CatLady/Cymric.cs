namespace Csharp.OOP.Basics.DefiningClasses._14.CatLady
{
    public static partial class _14CatLady
    {
        private class Cymric : Cat
        {
            private double FurLength { get; }

            public Cymric(string name, double furLength) : base(name)
            {
                this.FurLength = furLength;
            }

            public override string ToString()
            {
                return $"{this.GetType().Name} {this.Name} {this.FurLength:F2}";
            }
        }
    }

}
