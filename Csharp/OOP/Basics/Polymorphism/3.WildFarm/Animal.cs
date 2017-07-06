namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        abstract class Animal
        {
            protected string Name { get; }
            protected double Weight { get; }
            protected int FoodEaten { get; private set; }

            public abstract void MakeSound();

            public virtual void Eat(Food food)
            {
                this.FoodEaten += food.Quantity;
            }

            public override string ToString()
            {
                return string.Format("{0}[{1}, {2}, {3}]",
                    this.GetType().Name,
                    this.Name,
                    this.Weight,
                    this.FoodEaten);
            }

            protected Animal(string name, double weight)
            {
                this.Name = name;
                this.Weight = weight;
            }
        }
    }
}
