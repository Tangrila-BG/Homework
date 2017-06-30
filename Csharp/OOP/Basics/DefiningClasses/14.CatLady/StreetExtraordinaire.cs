namespace Csharp.OOP.Basics.DefiningClasses._14.CatLady
{
    public static partial class _14CatLady
    {
        private class StreetExtraordinaire : Cat
        {
            private int DecibelsOfMeow { get; }

            public StreetExtraordinaire(string name, int decibelOfMewo) : base(name)
            {
                this.DecibelsOfMeow = decibelOfMewo;
            }

            public override string ToString()
            {
                return this.GetType().Name + " " + this.Name + " " + this.DecibelsOfMeow;
            }
        }
    }

}
