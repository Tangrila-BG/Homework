using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Inheritance._1.Person
{
    public static partial class _1Person
    {
        public static void Solution()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
