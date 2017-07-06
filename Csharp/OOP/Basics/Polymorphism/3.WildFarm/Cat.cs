using System;

namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        class Cat : Feline
        {
            private string _breed { get; }

            public override void MakeSound()
            {
                Console.WriteLine("Meowwww");
            }

            public override string ToString()
            {
                return string.Format("{0}[{1}, {2}, {3}, {4}, {5}]",
                    this.GetType().Name,
                    base.Name,
                    this._breed,
                    base.Weight,
                    base.LivingRegion,
                    base.FoodEaten);
            }

            public Cat(string name, double weight, string livingRegion, string breed)
                : base(name, weight, livingRegion)
            {
                _breed = breed;
            }
        }
    }
}
