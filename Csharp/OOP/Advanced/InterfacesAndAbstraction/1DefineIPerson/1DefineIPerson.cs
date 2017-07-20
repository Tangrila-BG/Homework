using System;
using System.Reflection;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._1DefineIPerson
{
    class _1DefineIPerson
    {
        public static void Solution()
        {
            Type personInterface = typeof(Citizen).GetInterface("IPerson");
            PropertyInfo[] properties = personInterface.GetProperties();

            Console.WriteLine(properties.Length);

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            IPerson person = new Citizen(name, age);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }
    }
}
