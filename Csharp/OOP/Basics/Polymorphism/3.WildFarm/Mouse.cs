using System;

namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        class Mouse : Mammal
        {
            public override void MakeSound()
            {
                Console.WriteLine("SQUEEEAAAK!");
            }

            public override void Eat(Food food)
            {
                if (food is Meat)
                    throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");

                base.Eat(food);
            }

            public Mouse(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }
    }
}
