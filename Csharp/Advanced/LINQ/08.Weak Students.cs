using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _08WeakStudents(string[] args)
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
                .Where(x => x.Count(y => y == '2' || y == '3') >= 2)
                .Select(x => string.Join("", x.TakeWhile(y => char.IsLetter(y) || char.IsSeparator(y)))
                    .Trim())
                )
            {
                Console.WriteLine(student);
            }

        }
    }
}
