using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Polymorphism._1.Vehicles
{
    public static class _1Vehicles
    {
        public static void Solution()
        {
            var carInfo = Console.ReadLine().Trim().Split();

            var carFuel = double.Parse(carInfo[1]);
            var carConsumption = double.Parse(carInfo[2]);

            var car = new Car(carFuel, carConsumption);
            car.OnDriving += VehicleOnDriving;

            var truckInfo = Console.ReadLine().Trim().Split();

            var truckFuel = double.Parse(truckInfo[1]);
            var truckConsumption = double.Parse(truckInfo[2]);

            var truck = new Truck(truckFuel, truckConsumption);
            truck.OnDriving += VehicleOnDriving;

            var nActions = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < nActions; i++)
            {
                var input = Console.ReadLine().Trim().Split();

                var distanceOrFuel = double.Parse(input[2]);

                Vehicle vehicle;

                if (input[1].ToLowerInvariant() == "car")
                    vehicle = car;
                else
                    vehicle = truck;

                if (input[0].ToLowerInvariant() == "drive")
                    vehicle.Drive(distanceOrFuel);
                else
                    vehicle.Refuel(distanceOrFuel);
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void VehicleOnDriving(object sender, EventArgs eventArgs)
        {
            var args = (VehicleEventArgs)eventArgs;
            var senderName = sender.GetType().Name;

            if (args.NeedRefuel)
            {
                Console.WriteLine($"{senderName} needs refueling");
                return;
            }

            Console.WriteLine($"{senderName} travelled {args.Distance} km");
        }

        class VehicleEventArgs : EventArgs
        {
            public double Distance { get; }
            public bool NeedRefuel { get; }

            public VehicleEventArgs(double distance, bool needRefuel)
            {
                this.Distance = distance;
                this.NeedRefuel = needRefuel;
            }
        }

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
