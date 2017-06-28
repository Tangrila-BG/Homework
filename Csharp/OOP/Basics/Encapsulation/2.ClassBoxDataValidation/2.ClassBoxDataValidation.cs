using System;
using System.Linq;
using System.Reflection;

namespace Csharp.OOP.Basics.Encapsulation._2.ClassBoxDataValidation
{
    public partial class _2ClassBoxDataValidation
    {
        public static void Solution()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine(fields.Count());

            var length = double.Parse(Console.ReadLine().Trim());
            var width = double.Parse(Console.ReadLine().Trim());
            var height = double.Parse(Console.ReadLine().Trim());
            try
            {
                Console.WriteLine(new Box(length, width, height));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
