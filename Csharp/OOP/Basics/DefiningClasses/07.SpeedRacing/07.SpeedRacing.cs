using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._07.SpeedRacing
{
    public static partial class _07SpeedRacing
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                double fuel = double.Parse(input[1]);
                double fuelCost = double.Parse(input[2]);

                new Car(model, fuel, fuelCost);

            }

            while (true)
            {
                Queue<string> input = new Queue<string>(Console.ReadLine().Split());

                string activity = input.Dequeue();

                if (activity.ToLower() == "end")
                    break;

                Car.Activity(activity, input);

            }

            Car.PrintCars();
        }
    }

}
