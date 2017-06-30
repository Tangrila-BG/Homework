namespace Csharp.OOP.Basics.DefiningClasses._08.RawData
{

    public static partial class _08RawData
    {
        private class Cargo
        {
            private string _cargoType;
            private int _cargoWeight;

            public Cargo(string cargoType, int cargoWeight)
            {
                _cargoType = cargoType;
                _cargoWeight = cargoWeight;
            }

            public int CargoWeight
            {
                get { return _cargoWeight; }
                set { _cargoWeight = value; }
            }

            public string CargoType
            {
                get { return _cargoType; }
                set { _cargoType = value; }
            }
        }
    }
}
