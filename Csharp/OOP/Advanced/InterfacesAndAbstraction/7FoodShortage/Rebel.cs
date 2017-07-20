namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._7FoodShortage
{
    class Rebel : IBuyer
    {
        public string Name { get; }
        public string Group { get; }
        public int Age { get; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }
    }

}
