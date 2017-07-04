using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Inheritance._4.MordorCrueltyPlan
{
    public static partial class _4MordorCrueltyPlan
    {
        public static void Solution()
        {
            var food = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var gandalf = new Gandalf();

            foreach (var s in food)
            {
                var f = FoodFactory.ProduceFood(s);
                gandalf.Eat(f);
            }
            Console.WriteLine(gandalf);
        }
    }
}
