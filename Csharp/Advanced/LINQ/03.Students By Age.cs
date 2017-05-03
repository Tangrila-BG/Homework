using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _03StudentsByAge(string[] args)
        {
            List<string> students = new List<string>();
            while (true)
            {
                var student = Console.ReadLine();

                if (student == "END")
                    break;

                var age = int.Parse(string.Join("", student.Where(char.IsDigit)));
                if (age <= 24 && age >= 18)
                    students.Add(student);
            }
            foreach (var student in students)
                Console.WriteLine(student);
        }
    }
}
