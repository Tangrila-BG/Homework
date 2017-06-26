using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.DefiningClasses
{
    public partial class DefiningClasses
    {
        public static class _04CompanyRoster
        {
            public static void Solution()
            {
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();

                    string name = input[0];
                    decimal salary = decimal.Parse(input[1]);
                    string position = input[2];
                    string department = input[3];
                    string email = "n/a";
                    int age = -1;

                    for (int j = 4; j < input.Length; j++)
                    {
                        if (input[j].Contains("@"))
                        {
                            email = input[j];
                        }
                        else
                        {
                            try
                            {
                                age = int.Parse(input[j]);
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    new Employee(name, position, department, salary, age, email);

                }

                Employee.Print();
            }

            private class Employee
            {
                private static readonly List<Employee> Employees = new List<Employee>();
                private string name;
                private int age;
                private string position;
                private string department;
                private decimal salary;
                private string email;

                public Employee(string name, string position, string department, decimal salary, int age, string email)
                {
                    this.name = name;
                    this.age = age;
                    this.position = position;
                    this.department = department;
                    this.salary = salary;
                    this.email = email;

                    Employees.Add(new Employee(name, age, position, department, email, salary));
                }

                private Employee(string name, int age, string position, string department, string email, decimal salary)
                {
                    this.name = name;
                    this.age = age;
                    this.position = position;
                    this.department = department;
                    this.salary = salary;
                    this.email = email;
                }

                public static void Print()
                {
                    var departments = Employees.Select(e => e.department).Distinct();
                    decimal maxAverageSalary = Decimal.MinValue;
                    string targetDepartment = String.Empty;

                    foreach (var dprmnt in departments)
                    {
                        decimal averageSalary = Employees
                            .Where(e => e.department == dprmnt)
                            .Select(e => e.salary)
                            .Average();

                        if (averageSalary > maxAverageSalary)
                        {
                            maxAverageSalary = averageSalary;
                            targetDepartment = dprmnt;
                        }
                    }

                    Console.WriteLine($"Highest Average Salary: {targetDepartment}");

                    Employees.Where(e => e.department == targetDepartment)
                        .OrderByDescending(e => e.salary)
                        .ToList().
                        ForEach(
                            e => Console.WriteLine($"{e.name} {e.salary:F2} {e.email} {e.age}")
                        );

                }

            }
        }
    }
}
