using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.DefiningClasses
{
    public partial class DefiningClasses
    {
        public static class _01DefineAClassPerson
        {
            public static void Solution()
            {
                Type personType = typeof(Person);

                FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);

                Console.WriteLine(fields.Length);

            }

            private class Person
            {
                public string name;
                public int age;

            }
        }
    }
}
