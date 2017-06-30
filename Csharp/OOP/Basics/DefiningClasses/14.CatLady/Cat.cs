namespace Csharp.OOP.Basics.DefiningClasses._14.CatLady
{
    public static partial class _14CatLady
    {
        private abstract class Cat
        {
            public string Name { get; private set; }

            protected Cat(string name)
            {
                this.Name = name;
            }
        }
    }

}
