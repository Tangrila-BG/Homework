using System;
using System.Linq;
using System.Reflection;

namespace Csharp.OOP.Basics.Encapsulation._1.ClassBox
{
    public static partial class _1ClassBox
    {
        public static void Solution()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine(fields.Count());

            var length = double.Parse(Console.ReadLine().Trim());
            var width = double.Parse(Console.ReadLine().Trim());
            var height = double.Parse(Console.ReadLine().Trim());

            Console.WriteLine(new Box(length, width, height));
        }
    }
}
