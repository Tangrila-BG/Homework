namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._7FoodShortage
{
    interface IBuyer : IDescribable
    {
        int Food { get; }
        void BuyFood();
    }

}
