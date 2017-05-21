using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _06TruckTour
        {
            private const int DistancePerLitre = 1;

            public static void Solution()
            {
                var n = int.Parse(Console.ReadLine());

                var gasStations = new Queue<GasStation>();
                var truck = new Truck();

                while (n-- > 0)
                {
                    var gasStationParams = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

                    var fuel = gasStationParams[0];
                    var distanceToNextGasStation = gasStationParams[1];

                    var gasStation = new GasStation(new Pump(fuel), distanceToNextGasStation);

                    gasStations.Enqueue(gasStation);
                }

                while (true)
                {
                    // current station
                    var current = gasStations.Dequeue();
                    gasStations.Enqueue(current);

                    // dumps the fuel - returning to 0
                    // so it can start from another gas station
                    truck.DumpFuel();

                    int startId = current.Id;

                    // truck is unable to embark on a journey
                    // from current station, skip it
                    if (!current.EntryPoint)
                        continue;

                    truck.GasStop(current);
                    truck.Travel(current);

                    while (truck.Fuel >= 0)
                    {
                        current = gasStations.Dequeue();
                        gasStations.Enqueue(current);

                        truck.GasStop(current);
                        truck.Travel(current);

                        // returned to initial gas station
                        // exit successfully
                        if (startId.Equals(current.Id))
                        {
                            Console.WriteLine(startId);
                            Environment.Exit(0);
                        }
                    }
                }
            }

            private class GasStation
            {
                private static int _id = 0;

                public GasStation(Pump pump, int distanceToNextGasStation)
                {
                    this.Id = _id++;
                    this.Pump = pump;
                    this.DistanceToNextGasStation = distanceToNextGasStation;
                    this.EntryPoint = pump.Fuel >= distanceToNextGasStation;
                }

                public int Id { get; }
                public Pump Pump { get; }
                public int DistanceToNextGasStation { get; }
                public bool EntryPoint { get; }
            }

            private class Pump
            {
                public Pump(int fuel)
                {
                    this.Fuel = fuel;
                }

                public int Fuel { get; }
            }

            private class Truck
            {
                public int? Fuel { get; private set; }

                public void GasStop(GasStation station)
                {
                    this.Fuel += station.Pump.Fuel;
                }

                public void Travel(GasStation destination)
                {
                    this.Fuel -= destination.DistanceToNextGasStation * DistancePerLitre;
                }

                public void DumpFuel()
                {
                    this.Fuel = 0;
                }
            }
        }
    }
}
