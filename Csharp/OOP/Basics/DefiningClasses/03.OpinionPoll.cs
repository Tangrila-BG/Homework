using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.DefiningClasses
{
    public partial class DefiningClasses
    {
        public static class _03OpinionPoll
        {
            public static void Solution()
            {
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();

                    string name = input[0];
                    int age = int.Parse(input[1]);

                    Person person = new Person(name, age);
                    Person.Persons.Add(person);
                }

                Person.PrintPersonsOver30();
            }

            private class Person
            {
                public static List<Person> Persons = new List<Person>();
                public string name;
                public int age;

                public Person()
                {
                    name = "No name";
                    age = 1;
                }

                public Person(int age)
                {
                    this.name = "No name";
                    this.age = age;
                }

                public Person(string name, int age)
                {
                    this.name = name;
                    this.age = age;
                }

                public static void PrintPersonsOver30()
                {
                    var filteredPersons = Persons.Where(p => p.age > 30).OrderBy(p => p.name);
                    filteredPersons.ToList().ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
                }

            }
        }
    }
}
