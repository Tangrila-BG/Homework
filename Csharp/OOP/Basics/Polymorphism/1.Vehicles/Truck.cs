namespace Csharp.OOP.Basics.Polymorphism._1.Vehicles
{
    public static partial class _1Vehicles
    {
        class Truck : Vehicle
        {
            public override double FuelConsumptionPerKm
            {
                get { return base.FuelConsumptionPerKm; }
                set { base.FuelConsumptionPerKm += value + 1.6; }
            }

            public override void Refuel(double liters)
            {
                base.Refuel(liters * 0.95);
            }

            public Truck(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
            {
            }
        }
    }
}
