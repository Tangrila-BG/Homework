namespace Csharp.OOP.Basics.DefiningClasses._12.Google
{
    public static partial class _12Google
    {
        private class Car
        {
            private string _model;
            private int _speed;

            public Car(string model, int speed)
            {
                _model = model;
                _speed = speed;
            }

            public Car()
            {
            }

            public string Model
            {
                get { return _model; }
                set { _model = value; }
            }

            public int Speed
            {
                get { return _speed; }
                set { _speed = value; }
            }

            public override string ToString()
            {
                dynamic speed = _speed == 0 ? (dynamic)"" : _speed;
                return $"{_model} {speed}";
            }
        }
    }

}
