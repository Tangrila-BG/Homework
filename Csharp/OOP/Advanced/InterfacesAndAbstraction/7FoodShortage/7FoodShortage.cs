using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._7FoodShortage
{
    class _7FoodShortage
    {
        public static void Solution()
        {
            var buyers = new List<IBuyer>();
            var people = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < people; i++)
            {
                var input = Console.ReadLine().Trim().Split();

                if (input.Length == 4)
                    buyers.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                else
                    buyers.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
            }

            while (true)
            {
                var input = Console.ReadLine().Trim();

                if (input.Equals("End", StringComparison.OrdinalIgnoreCase))
                    break;

                buyers
                    .FirstOrDefault(x => x.Name.Equals(input))
                    ?.BuyFood();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
