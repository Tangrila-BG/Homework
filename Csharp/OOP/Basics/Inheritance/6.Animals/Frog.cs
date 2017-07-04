namespace Csharp.OOP.Basics.Inheritance._6.Animals
{

    class Frog : Animal
    {
        public override string ProduceSound()
        {
            return "Frogggg";
        }

        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }
    }

}
