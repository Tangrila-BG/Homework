using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Csharp.OOP.Basics.Encapsulation._3.AnimalFarm
{
    public partial class _3AnimalFarm
    {
        public static void Solution()
        {
            Type chickenType = typeof(Chicken);
            FieldInfo[] fields = chickenType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] methods = chickenType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            Debug.Assert(fields.Count(f => f.IsPrivate) == 2);
            Debug.Assert(methods.Count(m => m.IsPrivate) == 1);

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Chicken chicken = new Chicken(name, age);
                Console.WriteLine(
                    "Chicken {0} (age {1}) can produce {2} eggs per day.",
                    chicken.Name,
                    chicken.Age,
                    chicken.GetProductPerDay());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
