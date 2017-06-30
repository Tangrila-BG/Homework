using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._10.CarSalesman
{
    public static partial class _10CarSalesman
    {
        public static void Solution()
        {
            for (int i = 0; i < 2; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < n; j++)
                {
                    Queue<string> input = new Queue<string>(Console.ReadLine().Split());
                    if (i == 0) // Engines input
                    {
                        string model = input.Dequeue();
                        int power = Convert.ToInt32(input.Dequeue());
                        int displacement = -1;
                        string efficiency = "n/a";

                        if (input.Count > 0)
                        {
                            if (input.Peek().Any(char.IsDigit))
                            {
                                displacement = Convert.ToInt32(input.Dequeue());
                            }

                            if (input.Count > 0)
                            {
                                if (input.Peek().Any(char.IsLetter))
                                {
                                    efficiency = input.Dequeue();
                                }
                            }
                        }

                        new Engine(model, power, displacement, efficiency);
                    }
                    else // Cars input
                    {
                        string model = input.Dequeue();
                        string engineModel = input.Dequeue();
                        Engine engine = Engine.FindEngine(engineModel);
                        string color = "n/a";
                        int weight = -1;

                        if (input.Count > 0)
                        {
                            if (input.Peek().Any(char.IsDigit))
                            {
                                weight = Convert.ToInt32(input.Dequeue());
                            }

                            if (input.Count > 0)
                            {
                                if (input.Peek().Any(char.IsLetter))
                                {
                                    color = input.Dequeue();
                                }
                            }
                        }
                        new Car(model, weight, color, engine);

                    }

                }
            }

            Car.PrintCars();
        }
    }

}
