using System;
using System.Linq;

namespace Csharp.OOP.Basics.Encapsulation._5.PizzaCalories
{
    public partial class _5PizzaCalories
    {
        public static void Solution()
        {
            while (true)
            {
                var input = Console.ReadLine().Trim().Split();

                if (input[0].Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

                try
                {
                    if (input[0].Equals("pizza", StringComparison.OrdinalIgnoreCase))
                    {
                        var name = input[1];
                        var toppingCount = int.Parse(input[2]);

                        var pizza = new Pizza(name, toppingCount);

                        while (toppingCount-- >= 0)
                            Output(Console.ReadLine().Trim().Split(), pizza);

                        Console.WriteLine(pizza);
                    }
                    else
                    {
                        Output(input);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    break;
                }
            }
        }

        private static void Output(string[] input, Pizza pizza = null)
        {
            if (input[0].Equals("dough", StringComparison.OrdinalIgnoreCase))
            {
                var flourType = input[1];
                var bakingTechnique = input[2];
                var weight = double.Parse(input[3]);

                var dough = new Dough(flourType, bakingTechnique, weight);

                if (pizza == null)
                    Console.WriteLine("{0:F2}", dough.CaloriesPerGram);
                else
                    pizza.Dough = dough;
            }
            else
            {
                var toppingType = input[1];
                var weight = double.Parse(input[2]);

                var topping = new Topping(toppingType, weight);

                if (pizza == null)
                    Console.WriteLine("{0:F2}", topping.CaloriesPerGram);
                else
                    pizza.AddTopping(topping);
            }
        }
    }
}
