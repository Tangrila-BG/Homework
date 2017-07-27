using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.IteratorsAndComparators._5ComparingObjects
{
    class _5ComparingObjects
    {
        public static void Solution()
        {
            var people = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine().Trim().Split();

                if (input[0].Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

                people.Add(new Person(input.First(), int.Parse(input.Skip(1).First()), input.Last()));
            }

            var n = int.Parse(Console.ReadLine().Trim());

            var person = people[n - 1];

            if (people.Count(p => person.CompareTo(p) == 0 && !p.Equals(person)) <= 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}",
                    people.Count(p => person.CompareTo(p) == 0),
                    people.Count(p => person.CompareTo(p) != 0),
                    people.Count);
            }
        }
    }

    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            var ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0) return ageComparison;
            return string.Compare(Town, other.Town, StringComparison.Ordinal);
        }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
    }
}
