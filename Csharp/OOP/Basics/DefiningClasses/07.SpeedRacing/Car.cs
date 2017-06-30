using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._07.SpeedRacing
{
    public static partial class _07SpeedRacing
    {
        private class Car
        {
            private static readonly List<Car> Cars = new List<Car>();
            private string _model;
            private double _fuel;
            private double _fuelCostPerKm;
            private double _distanceTraveled = 0;

            public Car(string model, double fuel, double fuelCostPerKm)
            {
                this._model = model;
                this._fuel = fuel;
                this._fuelCostPerKm = fuelCostPerKm;

                Cars.Add(new Car(fuel, fuelCostPerKm, model));
            }

            private Car(double fuel, double fuelCostPerKm, string model)
            {
                this._model = model;
                this._fuel = fuel;
                this._fuelCostPerKm = fuelCostPerKm;
            }

            private static void Drive(Car car, int distance)
            {
                var fuelForDrive = distance * car._fuelCostPerKm;

                if (fuelForDrive > car._fuel)
                    Console.WriteLine("Insufficient fuel for the drive");
                else
                {
                    car._fuel -= fuelForDrive;
                    car._distanceTraveled += distance;
                }
            }

            private static Car FindCar(string model)
            {
                return Cars.First(c => c._model == model);
            }

            public static void Activity(string activity, Queue<string> data)
            {
                activity = activity.ToLower();
                switch (activity)
                {
                    case "drive":
                        string model = data.Dequeue();
                        int distance = Convert.ToInt32(data.Dequeue());

                        Car car = FindCar(model);
                        Drive(car, distance);
                        break;
                }
            }

            public static void PrintCars()
            {
                Cars.ForEach(c =>
                    Console.WriteLine(string.Join(" ", c.ToString()))
                );
            }

            public override string ToString()
            {
                return $"{_model} {_fuel:F2} {_distanceTraveled}";
            }

        }
    }

}
