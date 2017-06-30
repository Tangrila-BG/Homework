namespace Csharp.OOP.Basics.DefiningClasses._12.Google
{
    public static partial class _12Google
    {
        private class Child
        {
            private string _name;
            private string _birthday;

            public Child(string name, string birthday)
            {
                _name = name;
                _birthday = birthday;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Birthday
            {
                get { return _birthday; }
                set { _birthday = value; }
            }

            public override string ToString()
            {
                return $"{_name} {_birthday}";
            }
        }
    }

}
