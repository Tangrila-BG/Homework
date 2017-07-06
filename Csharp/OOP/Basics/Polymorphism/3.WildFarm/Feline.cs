namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        abstract class Feline : Mammal
        {
            protected Feline(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }
    }
}
