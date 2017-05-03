using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            while (t-- > 0)
            {
                var input = Console.ReadLine();
                var name = input.Substring(0, input.IndexOf(" "));
                var grades = input.Substring(input.IndexOf(" ") + 1).Split().Select(double.Parse).ToList();
                var student = new Student
                {
                    Name = name,
                    Grades = grades
                };
                if (student.AverageGrade() >= 5)
                    students.Add(student);
            }
            foreach (var student in students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade()))
                Console.WriteLine($"{student.Name} -> {student.AverageGrade():F2}");
        }

        class Student
        {
            public string Name { get; set; }

            public List<double> Grades { get; set; }

            public double AverageGrade()
            {
                return Grades.Sum() / Grades.Count;
            }
        }
    }
}
