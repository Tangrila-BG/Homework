namespace Csharp.OOP.Basics.Polymorphism._2.VehiclesExtension
{
    public static partial class _2VehiclesExtension
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

            public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
                : base(fuelQuantity, litersPerKm, tankCapacity)
            {
            }
        }
    }
}
