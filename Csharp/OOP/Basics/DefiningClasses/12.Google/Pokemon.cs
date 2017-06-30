namespace Csharp.OOP.Basics.DefiningClasses._12.Google
{
    public static partial class _12Google
    {
        private class Pokemon
        {
            private string _name;
            private string _type;


            public Pokemon(string name, string type)
            {
                _name = name;
                _type = type;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Type
            {
                get { return _type; }
                set { _type = value; }
            }

            public override string ToString()
            {
                return $"{_name} {_type}";
            }
        }
    }

}
