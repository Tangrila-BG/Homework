using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._10.CarSalesman
{
    public static partial class _10CarSalesman
    {
        private class Engine
        {
            private string _model;
            private int _power;
            private int _displacement = -1;
            private string _efficiency = "n/a";
            private static readonly List<Engine> Engines = new List<Engine>();

            public Engine(string model, int power, int displacement, string efficiency)
            {
                _model = model;
                _power = power;
                _displacement = displacement;
                _efficiency = efficiency;

                Engines.Add(new Engine(_power, _model, _displacement, _efficiency));
            }

            public Engine(string model, int power, string efficiency)
            {
                _model = model;
                _power = power;
                _efficiency = efficiency;

                Engines.Add(new Engine(_power, _model, _displacement, _efficiency));

            }

            public Engine(string model, int power, int displacement)
            {
                _model = model;
                _power = power;
                _displacement = displacement;

                Engines.Add(new Engine(_power, _model, _displacement, _efficiency));

            }

            public Engine(string model, int power)
            {
                _model = model;
                _power = power;

                Engines.Add(new Engine(_power, _model, _displacement, _efficiency));

            }

            public Engine()
            {
                _model = "n/a";
                _power = -1;
            }

            private Engine(int power, string model, int displacement, string efficiency)
            {
                _power = power;
                _model = model;
                _displacement = displacement;
                _efficiency = efficiency;
            }

            public static Engine FindEngine(string model)
            {
                return Engines.First(e => e._model == model);
            }

            public override string ToString()
            {
                dynamic displacement = _displacement == -1 ? (dynamic)"n/a" : _displacement;
                return $"{_model}:\n    Power: {_power}\n" +
                       $"    Displacement: {displacement}\n    Efficiency: {_efficiency}";
            }
        }
    }

}
