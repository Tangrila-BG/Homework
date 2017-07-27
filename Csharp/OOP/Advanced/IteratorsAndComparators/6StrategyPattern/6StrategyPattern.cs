using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.OOP.Advanced.IteratorsAndComparators._6StrategyPattern
{
    class _6StrategyPattern
    {
        public static void Solution()
        {
            var nameSorted = new SortedSet<Person>(new NameComparator());
            var ageSorted = new SortedSet<Person>(new AgeComparator());

            var n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim().Split();
                nameSorted.Add(new Person(input[0], int.Parse(input[1])));
                ageSorted.Add(new Person(input[0], int.Parse(input[1])));
            }

            foreach (var person in nameSorted)
                Console.WriteLine(person);
            foreach (var person in ageSorted)
                Console.WriteLine(person);
        }
    }

    interface IComparePersonStrategy : IComparer<Person> { }

    class NameComparator : IComparePersonStrategy
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
                result = x.Name.ToLowerInvariant()[0].CompareTo(y.Name.ToLowerInvariant()[0]);

            return result;
        }
    }

    class AgeComparator : IComparePersonStrategy
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return new StringBuilder($"{this.Name} {this.Age}").ToString();
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
