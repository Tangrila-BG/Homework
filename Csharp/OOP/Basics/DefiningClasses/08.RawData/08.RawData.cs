using System;
using System.Collections.Generic;

namespace Csharp.OOP.Basics.DefiningClasses._08.RawData
{

    public static partial class _08RawData
    {
        public static void Solution()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Queue<string> input = new Queue<string>(Console.ReadLine().Split());

                string model = input.Dequeue();
                int engineSpeed = Convert.ToInt32(input.Dequeue());
                int enginePower = Convert.ToInt32(input.Dequeue());
                int cargoWeight = Convert.ToInt32(input.Dequeue());
                string cargoType = input.Dequeue();
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Car car = new Car(model, enginePower, engineSpeed, cargo);

                int tireAge = -1;
                double tirePressure = -1;

                /* 0 - store tire pressure
                 * 1 - store tire age 
                 * 2 - add tire to car 
                 */
                short counter = 0;

                while (true)
                {
                    switch (counter)
                    {
                        case 0:
                            tirePressure = Double.Parse(input.Dequeue());
                            break;
                        case 1:
                            tireAge = Convert.ToInt32(input.Dequeue());
                            break;
                        case 2:
                            car.AddTire(new Tire(tireAge, tirePressure));
                            break;
                    }
                    counter++;
                    counter %= 3;

                    if (input.Count == 0)
                    {
                        car.AddTire(new Tire(tireAge, tirePressure));
                        break;
                    }
                }
            }

            string command = Console.ReadLine().ToLower();

            Car.Print(Car.Calc(command));
        }
    }
}
