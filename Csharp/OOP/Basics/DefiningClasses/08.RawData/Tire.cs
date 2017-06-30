namespace Csharp.OOP.Basics.DefiningClasses._08.RawData
{

    public static partial class _08RawData
    {
        private class Tire
        {
            private int _age;
            private double _pressure;

            public Tire(int age, double pressure)
            {
                _age = age;
                _pressure = pressure;
            }

            public double Pressure
            {
                get { return _pressure; }
                set { _pressure = value; }
            }

            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }
        }
    }
}
