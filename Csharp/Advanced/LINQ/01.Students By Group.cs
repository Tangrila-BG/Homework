using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StudentsByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            while (true)
            {
                var student = Console.ReadLine();

                if (student == "END")
                    break;
                var valid = student.Contains("2") ? student.Where(x => char.IsLetter(x) || char.IsSeparator(x)) : null;
                if (valid != null) students.Add(string.Join("", valid));
            }

            foreach (string student in students.OrderBy(x => x.Substring(0, x.IndexOf(" "))))
            {
                Console.WriteLine(student);
            }
        }
    }
}
