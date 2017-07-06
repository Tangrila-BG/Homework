using System;

namespace Csharp.OOP.Basics.Polymorphism._2.VehiclesExtension
{
    public static partial class _2VehiclesExtension
    {
        class Bus : Vehicle
        {
            protected override double FuelQuantity
            {
                get { return base.FuelQuantity; }
                set
                {
                    if (value > base.TankCapacity)
                        throw new ArgumentException("Cannot fit fuel in tank");

                    base.FuelQuantity = value;
                }
            }

            public override void Drive(double distance)
            {
                var cost = (this.FuelConsumptionPerKm + 1.4) * distance;
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

            public void DriveEmpty(double distance)
            {
                base.Drive(distance);
            }

            public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
            {
            }
        }
    }
}
