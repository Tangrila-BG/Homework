using System;

namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        class Tiger : Feline
        {
            public override void MakeSound()
            {
                Console.WriteLine("ROAAR!!!");
            }

            public override void Eat(Food food)
            {
                if (food is Vegetable)
                    throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");

                base.Eat(food);
            }

            public Tiger(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }
    }
}
