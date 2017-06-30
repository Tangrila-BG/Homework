using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._12.Google
{
    public static partial class _12Google
    {
        public static void Solution()
        {
            List<Person> peoples = new List<Person>();

            while (true)
            {
                Queue<string> input = new Queue<string>(Console.ReadLine().Split());

                if (input.Peek().ToLower() == "end")
                    break;

                string name = input.Dequeue();

                Person person = peoples.FirstOrDefault(p => p.Name == name) ?? new Person(name);
                string infoType = input.Dequeue();

                switch (infoType.ToLower())
                {
                    case "company":
                        string companyName = input.Dequeue();
                        string department = input.Dequeue();
                        decimal salary = Decimal.Parse(input.Dequeue());
                        Company company = new Company(companyName, department, salary);

                        person.UpdatePerson(company);
                        break;
                    case "car":
                        string carModel = input.Dequeue();
                        int carSpeed = Convert.ToInt32(input.Dequeue());
                        Car car = new Car(carModel, carSpeed);

                        person.UpdatePerson(car);
                        break;

                    case "pokemon":
                        string pokemonName = input.Dequeue();
                        string pokemonType = input.Dequeue();
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonType);

                        person.UpdatePerson(pokemon);
                        break;

                    case "parents":
                        string parentName = input.Dequeue();
                        string parentBirthday = input.Dequeue();
                        Parent parent = new Parent(parentName, parentBirthday);

                        person.UpdatePerson(parent);
                        break;

                    case "children":
                        string childName = input.Dequeue();
                        string childBirthday = input.Dequeue();
                        Child child = new Child(childName, childBirthday);

                        person.UpdatePerson(child);
                        break;
                }

                if (!peoples.Exists(p => p.Name == person.Name))
                    peoples.Add(person);
            }
            string target = Console.ReadLine();
            var personToPrint = peoples.First(p => p.Name == target);

            Console.WriteLine(personToPrint);
        }
    }

}
