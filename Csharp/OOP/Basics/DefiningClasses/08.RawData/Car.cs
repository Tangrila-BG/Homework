using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._08.RawData
{

    public static partial class _08RawData
    {
        private class Car
        {
            private string _model;
            private int _engineSpeed;
            private int _enginePower;
            private Cargo _cargo;
            private List<Tire> _tires = new List<Tire>();
            private static readonly List<Car> Cars = new List<Car>();

            public Car(string model, int enginePower, int engineSpeed, Cargo cargo)
            {
                this._model = model;
                this._enginePower = enginePower;
                this._engineSpeed = engineSpeed;
                this._cargo = cargo;

            }

            private Car(int enginePower, int engineSpeed, Cargo cargo, string model, List<Tire> tires)
            {
                this._model = model;
                this._enginePower = enginePower;
                this._engineSpeed = engineSpeed;
                this._cargo = cargo;
                this._tires = tires;
            }

            public void AddTire(Tire tire)
            {
                if (_tires.Count < 4)
                    _tires.Add(tire);

                if (_tires.Count == 4)
                    Cars.Add(new Car(_enginePower, _engineSpeed, _cargo, _model, _tires));
            }

            public static void Print(IEnumerable<Car> cars)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car._model);
                }
            }

            public static IEnumerable<Car> Calc(string command)
            {
                IEnumerable<Car> filteredCars = new Car[4];
                switch (command)
                {
                    case "fragile":
                        filteredCars = Cars
                            .Where(c => c._cargo.CargoType == command)
                            .Where(c => c._tires.Count(t => t.Pressure < 1) > 0);
                        break;
                    case "flamable":
                        filteredCars = Cars
                            .Where(c => c._enginePower > 250)
                            .Where(c => c._cargo.CargoType == command);
                        break;
                }

                return filteredCars;
            }
        }
    }
}
