using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterStudentsByEmailDomain
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

            foreach (string student in students
                .Where(x => x.Contains("@gmail.com"))
                .Select(x => x.Substring(0, x.LastIndexOf(" "))))
                Console.WriteLine(student);
        }
    }
}
