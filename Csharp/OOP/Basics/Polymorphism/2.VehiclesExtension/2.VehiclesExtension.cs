using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Polymorphism._2.VehiclesExtension
{
    public static class _2VehiclesExtension
    {
        public static void Solution()
        {

            var carInfo = Console.ReadLine().Trim().Split();

            var carFuel = double.Parse(carInfo[1]);
            var carConsumption = double.Parse(carInfo[2]);
            var carCapacity = double.Parse(carInfo[3]);

            var car = new Car(carFuel, carConsumption, carCapacity);

            var truckInfo = Console.ReadLine().Trim().Split();

            var truckFuel = double.Parse(truckInfo[1]);
            var truckConsumption = double.Parse(truckInfo[2]);
            var truckCapacity = double.Parse(truckInfo[3]);

            var truck = new Truck(truckFuel, truckConsumption, truckCapacity);

            var busInfo = Console.ReadLine().Trim().Split();

            var busFuel = double.Parse(busInfo[1]);
            var busConsumption = double.Parse(busInfo[2]);
            var busCapacity = double.Parse(busInfo[3]);

            var bus = new Bus(busFuel, busConsumption, busCapacity);

            var nActions = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < nActions; i++)
            {
                try
                {
                    var input = Console.ReadLine().Trim().Split();

                    var distanceOrFuel = double.Parse(input[2]);

                    Vehicle vehicle;

                    switch (input[1].ToLowerInvariant())
                    {
                        case "car":
                            vehicle = car;
                            break;
                        case "bus":
                            vehicle = bus;
                            break;
                        default:
                            vehicle = truck;
                            break;
                    }

                    switch (input[0].ToLowerInvariant())
                    {
                        case "drive":
                            vehicle.Drive(distanceOrFuel);
                            break;
                        case "driveempty":
                            (vehicle as Bus).DriveEmpty(distanceOrFuel);
                            break;
                        default:
                            vehicle.Refuel(distanceOrFuel);
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
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
