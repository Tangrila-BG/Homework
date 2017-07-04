using System;

namespace Csharp.OOP.Basics.Inheritance._3.Mankind
{
    public static partial class _3Mankind
    {
        class Worker : Human
        {
            private double _weekSalary;
            private double _workHourPerDay;

            public double WeekSalary
            {
                get { return _weekSalary; }
                set
                {
                    if (value < 10)
                        throw new ArgumentException("Expected value mismatch! Argument: weekSalary");

                    _weekSalary = value;
                }
            }

            public double WorkHourPerDay
            {
                get { return _workHourPerDay; }
                set
                {
                    if (value < 1 || value > 12)
                        throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");

                    _workHourPerDay = value;
                }
            }

            public double CalcSalaryByHour()
            {
                return this.WeekSalary / 5 / this.WorkHourPerDay;
            }

            public override string ToString()
            {
                return $"First Name: {this.FirstName}\n" +
                       $"Last Name: {this.LastName}\n" +
                       $"Week Salary: {this.WeekSalary:F2}\n" +
                       $"Hours per day: {this.WorkHourPerDay:F2}\n" +
                       $"Salary per hour: {this.CalcSalaryByHour():F2}";

            }

            public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay) : base(firstName, lastName)
            {
                this.WeekSalary = weekSalary;
                this.WorkHourPerDay = hoursPerDay;
            }
        }
    }
}
