using System;

namespace Csharp.OOP.Basics.Inheritance._3.Mankind
{
    public static class _3Mankind
    {
        public static void Solution()
        {
            var studentInfo = Console.ReadLine().Trim().Split();
            var workerInfo = Console.ReadLine().Trim().Split();

            var workerSalary = double.Parse(workerInfo[2]);
            var workHoursPerDay = double.Parse(workerInfo[3]);

            try
            {
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0], workerInfo[1], workerSalary, workHoursPerDay);
                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }


        abstract class Human
        {
            private string _firstName;
            private string _lastName;

            protected string FirstName
            {
                get { return _firstName; }
                set
                {
                    if (value.Length < 4)
                        throw new ArgumentException("Expected length at least 4 symbols!Argument: firstName");

                    if (!char.IsUpper(value[0]))
                        throw new ArgumentException("Expected upper case letter!Argument: firstName");

                    _firstName = value;
                }
            }

            protected string LastName
            {
                get { return _lastName; }
                set
                {
                    if (value.Length < 3)
                        throw new ArgumentException("Expected length at least 3 symbols!Argument: lastName");

                    if (!char.IsUpper(value[0]))
                        throw new ArgumentException("Expected upper case letter!Argument: lastName");

                    _lastName = value;
                }
            }

            protected Human(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }
        }

        class Worker : Human
        {
            private double _weekSalary;
            private double _workHourPerDay;

            public double WeekSalary
            {
                get { return _weekSalary; }
                set
                {
                    if (value <= 10)
                        throw new ArgumentException("Expected value mismatch!Argument: weekSalary");

                    _weekSalary = value;
                }
            }

            public double WorkHourPerDay
            {
                get { return _workHourPerDay; }
                set
                {
                    if (value < 1 || value > 12)
                        throw new ArgumentException("Expected value mismatch!Argument: workHoursPerDay");

                    _workHourPerDay = value;
                }
            }

            public double CalcSalaryByHour()
            {
                return this.WeekSalary / 7 / this.WorkHourPerDay;
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

        class Student : Human
        {
            private string _facultyNumber;

            public string FacultyNumber
            {
                get { return _facultyNumber; }
                set
                {
                    if (value.Length < 5 || value.Length > 10)
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
