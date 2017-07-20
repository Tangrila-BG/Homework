namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._7FoodShortage
{
    class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public string Id { get; }
        public string Name { get; }
        public string Birthday { get; }
        public int Age { get; }
        public int Food { get; private set; }


        public void BuyFood()
        {
            this.Food += 10;
        }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }
    }

}
