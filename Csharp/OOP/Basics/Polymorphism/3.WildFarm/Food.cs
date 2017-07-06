namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
    {
        abstract class Food
        {
            public int Quantity { get; }

            protected Food(int quantity)
            {
                this.Quantity = quantity;
            }
        }
    }
}
