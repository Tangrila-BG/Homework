namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        abstract class Mammal : Animal
        {
            protected string LivingRegion { get; }

            public override string ToString()
            {
                return string.Format("{0}[{1}, {2}, {3}, {4}]",
                    this.GetType().Name,
                    base.Name,
                    base.Weight,
                    this.LivingRegion,
                    base.FoodEaten);
            }

            protected Mammal(string name, double weight, string livingRegion)
                : base(name, weight)
            {
                this.LivingRegion = livingRegion;
            }

        }
    }
}
