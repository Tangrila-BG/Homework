using System;

namespace Csharp.OOP.Basics.Inheritance._3.Mankind
{
    public static partial class _3Mankind
    {
        class Student : Human
        {
            private string _facultyNumber;

            public string FacultyNumber
            {
                get { return _facultyNumber; }
                set
                {
                    if (IsNumberInvalid(value))
                        throw new ArgumentException("Invalid faculty number!");

                    _facultyNumber = value;
                }
            }

            public override string ToString()
            {
                return $"First Name: {this.FirstName}\n" +
                       $"Last Name: {this.LastName}\n" +
                       $"Faculty number: {this.FacultyNumber}";
            }

            public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
            {
                this.FacultyNumber = facultyNumber;
            }
        }
    }
}
