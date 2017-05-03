using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortStudents
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
                students.Add(student);
            }

            foreach (var student in students
                .OrderBy(x => x.Substring(x.IndexOf(" ") + 1))
                .ThenByDescending(x => x.Substring(0, x.IndexOf(" "))))
                Console.WriteLine(student);
        }
    }
}
