using System;

namespace Csharp.OOP.Basics.Inheritance._1.Person
{
    public static partial class _1Person
    {
        class Person
        {
            protected int _age;
            private string _name;

            public string Name
            {
                get { return _name; }
                set
                {
                    if (value.Length < 3)
                        throw new ArgumentException("Name's length should not be less than 3 symbols!");

                    _name = value;
                }
            }

            public virtual int Age
            {
                get { return _age; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Age must be positive!");

                    _age = value;
                }
            }

            public override string ToString()
            {
                return $"Name: {this.Name}, Age: {this.Age}";
            }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }
    }
}
