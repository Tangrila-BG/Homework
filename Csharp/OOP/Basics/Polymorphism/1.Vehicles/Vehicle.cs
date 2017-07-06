using System;

namespace Csharp.OOP.Basics.Polymorphism._1.Vehicles
{
    public static partial class _1Vehicles
    {
        abstract class Vehicle
        {
            public event EventHandler OnDriving;

            private double FuelQuantity { get; set; }
            public virtual double FuelConsumptionPerKm { get; set; }

            public void Drive(double distance)
            {
                var cost = this.FuelConsumptionPerKm * distance;
                var needRefuel = cost > this.FuelQuantity;

                OnDriving(this, new VehicleEventArgs(distance, needRefuel));

                if (!needRefuel)
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

            protected Vehicle(double fuelQuantity, double litersPerKm)
            {
                this.FuelQuantity = fuelQuantity;
                this.FuelConsumptionPerKm = litersPerKm;
            }
        }
    }
}
