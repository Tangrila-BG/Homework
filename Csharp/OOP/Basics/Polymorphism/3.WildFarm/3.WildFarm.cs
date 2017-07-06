using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Polymorphism._3.WildFarm
{
    public static partial class _3WildFarm
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
    }
}
