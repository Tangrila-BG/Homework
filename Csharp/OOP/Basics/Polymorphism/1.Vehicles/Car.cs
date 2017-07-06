namespace Csharp.OOP.Basics.Polymorphism._1.Vehicles
{
    public static partial class _1Vehicles
    {
        class Car : Vehicle
        {
            public override double FuelConsumptionPerKm
            {
                get { return base.FuelConsumptionPerKm; }
                set { base.FuelConsumptionPerKm += value + 0.9; }
            }

            public Car(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
            {
            }
        }
    }
}
