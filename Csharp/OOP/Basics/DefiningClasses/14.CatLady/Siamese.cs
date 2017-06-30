namespace Csharp.OOP.Basics.DefiningClasses._14.CatLady
{
    public static partial class _14CatLady
    {
        private class Siamese : Cat
        {
            private int EarSize { get; }

            public Siamese(string name, int earSize) : base(name)
            {
                this.EarSize = earSize;
            }

            public override string ToString()
            {
                return this.GetType().Name + " " + this.Name + " " + this.EarSize;
            }
        }
    }

}
