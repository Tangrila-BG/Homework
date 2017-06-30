using System;
using System.Collections.Generic;

namespace Csharp.OOP.Basics.DefiningClasses._10.CarSalesman
{
    public static partial class _10CarSalesman
    {
        private class Car
        {
            private string _model;
            private int _weight = -1;
            private string _color = "n/a";
            private Engine _engine;
            private static readonly List<Car> Cars = new List<Car>();

            public Car(string model, int weight, string color, Engine engine)
            {
                _model = model;
                _weight = weight;
                _color = color;
                _engine = engine;

                Cars.Add(new Car(_model, _engine, _weight, _color));

            }

            public Car(string model, int weight, Engine engine)
            {
                _model = model;
                _weight = weight;
                _engine = engine;

                Cars.Add(new Car(_model, _engine, _weight, _color));

            }

            public Car(string model, string color, Engine engine)
            {
                _model = model;
                _color = color;
                _engine = engine;

                Cars.Add(new Car(_model, _engine, _weight, _color));

            }

            public Car(string model, Engine engine)
            {
                _model = model;
                _engine = engine;

                Cars.Add(new Car(_model, _engine, _weight, _color));
            }

            private Car(string model, Engine engine, int weight, string color)
            {
                _model = model;
                _engine = engine;
                _weight = weight;
                _color = color;
            }

            public static void PrintCars()
            {
                Cars.ForEach(c => Console.WriteLine(c.ToString()));
            }

            public override string ToString()
            {
                dynamic weight = _weight == -1 ? (dynamic)"n/a" : _weight;
                return $"{_model}:\n  {_engine.ToString()}\n  Weight: {weight}\n  Color: {_color}";
            }

        }
    }

}
