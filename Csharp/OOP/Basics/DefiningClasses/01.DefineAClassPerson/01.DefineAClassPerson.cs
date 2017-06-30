using System;
using System.Reflection;

namespace Csharp.OOP.Basics.DefiningClasses._01.DefineAClassPerson
{
    public static partial class _01DefineAClassPerson
    {
        public static void Solution()
        {
            Type personType = typeof(Person);

            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine(fields.Length);

        }
    }
}
