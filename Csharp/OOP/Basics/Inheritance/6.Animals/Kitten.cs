namespace Csharp.OOP.Basics.Inheritance._6.Animals
{

    class Kitten : Cat
    {
        public override string ProduceSound()
        {
            return "Miau";
        }

        public Kitten(string name, int age, string gender) : base(name, age, "Female")
        {
        }
    }

}
