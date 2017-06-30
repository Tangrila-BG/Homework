using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._04.OpinionPoll
{
    public static partial class _04OpinionPoll
    {
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
