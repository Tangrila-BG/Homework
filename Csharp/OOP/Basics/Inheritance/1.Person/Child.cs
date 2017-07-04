using System;

namespace Csharp.OOP.Basics.Inheritance._1.Person
{
    public static partial class _1Person
    {
        class Child : Person
        {
            public sealed override int Age
            {
                get { return _age; }
                set
                {
                    if (value > 15)
                        throw new ArgumentException("Child's age must be less than 15!");

                    base.Age = value;
                }
            }

            public Child(string name, int age) : base(name, age)
            {
            }
        }
    }
}
