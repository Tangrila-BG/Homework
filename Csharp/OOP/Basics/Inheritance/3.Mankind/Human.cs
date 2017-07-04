using System;

namespace Csharp.OOP.Basics.Inheritance._3.Mankind
{
    public static partial class _3Mankind
    {
        abstract class Human
        {
            private string _firstName;
            private string _lastName;

            protected string FirstName
            {
                get { return _firstName; }
                set
                {
                    if (!char.IsUpper(value[0]))
                        throw new ArgumentException("Expected upper case letter! Argument: firstName");

                    if (value.Length < 4)
                        throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");

                    _firstName = value;
                }
            }

            protected string LastName
            {
                get { return _lastName; }
                set
                {
                    if (!char.IsUpper(value[0]))
                        throw new ArgumentException("Expected upper case letter! Argument: lastName");

                    if (value.Length < 3)
                        throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");

                    _lastName = value;
                }
            }

            protected Human(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }
        }
    }
}
