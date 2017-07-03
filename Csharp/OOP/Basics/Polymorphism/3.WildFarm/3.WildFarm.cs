using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static class _3WildFarm
    {
        public static void Solution()
        {
            var n = 0;
            Animal animal = null;

            while (true)
            {
                string[] input = Console.ReadLine().Trim().Split();

                if (input[0].ToLowerInvariant() == "end")
                    break;

                if (n % 2 == 0)
                {
                    Type animalType = GetType(typeof(Animal), input[0]);
                    string animalName = input[1];
                    double animalWeight = double.Parse(input[2]);
                    string animalLivingRegion = input[3];

                    if (animalType.Name == "Cat")
                    {
                        var breed = input[4];

                        animal = (Animal)GetConstructor(animalType,
                            new object[] { animalName, animalWeight, animalLivingRegion, breed },
                            typeof(string), typeof(double), typeof(string), typeof(string));
                    }
                    else
                    {
                        animal = (Animal)GetConstructor(animalType,
                            new object[] { animalName, animalWeight, animalLivingRegion },
                            typeof(string), typeof(double), typeof(string));
                    }
                }
                else
                {
                    animal.MakeSound();

                    Type foodType = GetType(typeof(Food), input[0]);
                    var quantity = int.Parse(input[1]);

                    var food = (Food)GetConstructor(foodType, new object[] { quantity }, typeof(int));

                    try
                    {
                        animal.Eat(food);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }

                    Console.WriteLine(animal);
                }

                n++;
            }
        }

        static Type GetType(Type subClassOf, string type)
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .First(x => x.IsSubclassOf(subClassOf)
                            && x.Name.Equals(type));
        }

        static object GetConstructor(Type constructorOf, object[] args, params Type[] types)
        {
            return constructorOf.GetConstructor(types).Invoke(args);
        }

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

        abstract class Mammal : Animal
        {
            protected string LivingRegion { get; }

            public override string ToString()
            {
                return string.Format("{0}[{1}, {2}, {3}, {4}]",
                    this.GetType().Name,
                    base.Name,
                    base.Weight,
                    this.LivingRegion,
                    base.FoodEaten);
            }

            protected Mammal(string name, double weight, string livingRegion)
                : base(name, weight)
            {
                this.LivingRegion = livingRegion;
            }

        }

        abstract class Feline : Mammal
        {
            protected Feline(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }

        class Tiger : Feline
        {
            public override void MakeSound()
            {
                Console.WriteLine("ROAAR!!!");
            }

            public override void Eat(Food food)
            {
                if (food is Vegetable)
                    throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");

                base.Eat(food);
            }

            public Tiger(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }

        class Cat : Feline
        {
            private string _breed { get; }

            public override void MakeSound()
            {
                Console.WriteLine("Meowwww");
            }

            public override string ToString()
            {
                return string.Format("{0}[{1},{2}, {3}, {4}, {5}]",
                    this.GetType().Name,
                    base.Name,
                    this._breed,
                    base.Weight,
                    base.LivingRegion,
                    base.FoodEaten);
            }

            public Cat(string name, double weight, string livingRegion, string breed)
                : base(name, weight, livingRegion)
            {
                _breed = breed;
            }
        }

        class Zebra : Mammal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Zs");
            }

            public override void Eat(Food food)
            {
                if (food is Meat)
                    throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");

                base.Eat(food);
            }

            public Zebra(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }

        class Mouse : Mammal
        {
            public override void MakeSound()
            {
                Console.WriteLine("SQUEEEAAAK!");
            }

            public override void Eat(Food food)
            {
                if (food is Meat)
                    throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");

                base.Eat(food);
            }

            public Mouse(string name, double weight, string livingRegion)
                : base(name, weight, livingRegion)
            {
            }
        }

        abstract class Food
        {
            public int Quantity { get; }

            protected Food(int quantity)
            {
                this.Quantity = quantity;
            }
        }

        class Vegetable : Food
        {
            public Vegetable(int quantity) : base(quantity)
            {
            }
        }

        class Meat : Food
        {
            public Meat(int quantity) : base(quantity)
            {
            }
        }
    }
}
