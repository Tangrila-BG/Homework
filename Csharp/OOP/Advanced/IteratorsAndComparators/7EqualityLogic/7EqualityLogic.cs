using System;
using System.Collections.Generic;

namespace Csharp.OOP.Advanced.IteratorsAndComparators._7EqualityLogic
{
    class _7EqualityLogic
    {
        public static void Solution()
        {
            var peopleSorted = new SortedSet<Person>();
            var peopleHash = new HashSet<Person>();
            var n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim().Split();

                peopleSorted.Add(new Person(input[0], int.Parse(input[1])));
                peopleHash.Add(new Person(input[0], int.Parse(input[1])));
            }

            Console.WriteLine(peopleSorted.Count);
            Console.WriteLine(peopleHash.Count);
        }
    }

    class Person : IEquatable<Person>, IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public bool Equals(Person other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Name, other.Name) && Age == other.Age;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ Age;
            }
        }

        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            return Age.CompareTo(other.Age);
        }
    }
}
