using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Inheritance._6.Animals
{
    public static class _6Animals
    {
        public static void Solution()
        {
            var animals = new List<Animal>();

            while (true)
            {
                try
                {
                    var input = Console.ReadLine().Trim();

                    if (input.Equals("beast!", StringComparison.OrdinalIgnoreCase))
                        break;

                    var animalType = input;
                    var animalInfo = Console.ReadLine().Trim().Split();

                    var name = animalInfo[0];
                    var age = int.Parse(animalInfo[1]);
                    var gender = animalInfo[2];

                    var type = Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .FirstOrDefault(x => x.IsSubclassOf(typeof(Animal)) && x.Name.Equals(animalType));

                    var constructor = type.GetConstructor(new[] { typeof(string), typeof(int), typeof(string) });

                    var animal = (Animal)constructor.Invoke(new object[] { name, age, gender });

                    animals.Add(animal);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            animals.ForEach(Console.WriteLine);
        }

        class Animal : ISoundProducible
        {
            private string _name;
            private int _age;
            private string _gender;

            public string Name
            {
                get { return _name; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("Invalid input!");

                    _name = value;
                }
            }

            public int Age
            {
                get { return _age; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Invalid input!");

                    _age = value;
                }
            }

            public string Gender
            {
                get { return _gender; }
                set
                {
                    var temp = value.ToLowerInvariant();

                    if (temp != "male" && temp != "female")
                        throw new ArgumentException("Invalid input!");

                    _gender = value;
                }
            }

            public virtual string ProduceSound()
            {
                return "";
            }

            public override string ToString()
            {
                return $"{this.GetType().Name}\n" +
                       $"{this.Name} {this.Age} {this.Gender}\n" +
                       $"{this.ProduceSound()}";
            }

            protected Animal(string name, int age, string gender)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }
        }

        interface ISoundProducible
        {
            string ProduceSound();
        }

        class Dog : Animal
        {
            public override string ProduceSound()
            {
                return "BauBau";
            }

            public Dog(string name, int age, string gender) : base(name, age, gender)
            {
            }
        }

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

        class Kitten : Cat
        {
            public override string ProduceSound()
            {
                return "Miau";
            }

            public Kitten(string name, int age, string gender) : base(name, age, gender)
            {
            }
        }

        class Tomcat : Cat
        {
            public override string ProduceSound()
            {
                return "Give me one million b***h";
            }

            public Tomcat(string name, int age, string gender) : base(name, age, gender)
            {
            }
        }

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
}
