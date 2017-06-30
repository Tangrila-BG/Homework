namespace Csharp.OOP.Basics.DefiningClasses._03.OldestFamilyMember
{
    public static partial class _03OldestFamilyMember
    {
        private class Person
        {
            private string _name;
            private int _age;

            public int Age
            {
                get { return _age; }
                private set { _age = value; }
            }

            public override string ToString()
            {
                return $"{this._name} {this.Age}";
            }

            public Person(string name, int age)
            {
                this._name = name;
                this.Age = age;
            }
        }
    }
}
