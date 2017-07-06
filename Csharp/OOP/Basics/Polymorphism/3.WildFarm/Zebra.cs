using System;

namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        class Zebra : Mammal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Zs");
            }

            public override void Eat(Food food)
            {
                if (food is Meat)
                    throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");

                base.Eat(food);
            }

            public Zebra(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }
    }
}
