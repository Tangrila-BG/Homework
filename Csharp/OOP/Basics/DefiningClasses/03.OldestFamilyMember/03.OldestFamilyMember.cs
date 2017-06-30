using System;
using System.Linq;
using System.Reflection;

namespace Csharp.OOP.Basics.DefiningClasses._03.OldestFamilyMember
{
    public static partial class _03OldestFamilyMember
    {
        public static void Solution()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");

            if (oldestMemberMethod == null || addMemberMethod == null)
                throw new Exception();

            int n = int.Parse(Console.ReadLine().Trim());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim().Split();

                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember());
        }
    }
}
