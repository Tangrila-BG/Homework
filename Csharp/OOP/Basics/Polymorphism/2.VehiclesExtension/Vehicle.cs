using System;

namespace Csharp.OOP.Basics.Polymorphism._2.VehiclesExtension
{
    public static partial class _2VehiclesExtension
    {
        abstract class Vehicle
        {
            private double _fuelQuantity;
            public event EventHandler OnDriving;

            public double TankCapacity { get; set; }

            protected virtual double FuelQuantity
            {
                get { return _fuelQuantity; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Fuel must be a positive number");

                    _fuelQuantity = value;
                }
            }

            public virtual double FuelConsumptionPerKm { get; set; }

            public virtual void Drive(double distance)
            {
                var cost = this.FuelConsumptionPerKm * distance;
                var needRefuel = cost > this.FuelQuantity;

                var vehicle = this.GetType().Name;

                if (needRefuel)
                {
                    Console.WriteLine($"{vehicle} needs refueling");
                    return;
                }

                Console.WriteLine($"{vehicle} travelled {distance} km");


                this.FuelQuantity -= cost;
            }

            public virtual void Refuel(double liters)
            {
                this.FuelQuantity += liters;
            }

            public override string ToString()
            {
                return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
            }

            protected Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
            {
                this.TankCapacity = tankCapacity;
                this.FuelQuantity = fuelQuantity;
                this.FuelConsumptionPerKm = litersPerKm;
            }
        }
    }
}
