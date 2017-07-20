namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._2MultipleImplementation
{
    internal class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }
    }
}
