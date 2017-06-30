using System;

namespace Csharp.OOP.Basics.DefiningClasses._04.OpinionPoll
{
    public static partial class _04OpinionPoll
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
    }

}
