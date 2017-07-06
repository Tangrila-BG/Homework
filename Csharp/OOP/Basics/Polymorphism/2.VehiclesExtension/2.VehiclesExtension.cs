using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Polymorphism._2.VehiclesExtension
{
    public static partial class _2VehiclesExtension
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
    }
}
