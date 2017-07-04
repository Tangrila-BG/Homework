namespace Csharp.OOP.Basics.Inheritance._6.Animals
{

    class Cat : Animal
    {
        public override string ProduceSound()
        {
            return "MiauMiau";
        }

        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }
    }

}
