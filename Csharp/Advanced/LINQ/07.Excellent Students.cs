using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ExcellentStudents
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
                .Where(x => x.Contains("6"))
                .Select(x => string.Join("", x.TakeWhile(y => char.IsLetter(y) || char.IsSeparator(y)))
                    .Trim()))
            {
                Console.WriteLine(student);
            }
        }
    }
}
