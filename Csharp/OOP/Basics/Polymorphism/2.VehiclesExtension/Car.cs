using System;

namespace Csharp.OOP.Basics.Polymorphism._2.VehiclesExtension
{
    public static partial class _2VehiclesExtension
    {
        class Car : Vehicle
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

            public override double FuelConsumptionPerKm
            {
                get { return base.FuelConsumptionPerKm; }
                set { base.FuelConsumptionPerKm += value + 0.9; }
            }

            public Car(double fuelQuantity, double litersPerKm, double tankCapacity)
                : base(fuelQuantity, litersPerKm, tankCapacity)
            {
            }
        }
    }
}
