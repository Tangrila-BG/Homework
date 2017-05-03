using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _02StudentsByFirstAndLastName(string[] args)
        {
            List<string> students = new List<string>();
            while (true)
            {
                var student = Console.ReadLine();

                if (student == "END")
                    break;
                students.Add(student);
            }

            foreach (string student in students.Where(x =>
                String.CompareOrdinal(x.Substring(0, x.IndexOf(" ")), x.Substring(x.IndexOf(" ") + 1)) < 0)
                )
            {
                Console.WriteLine(student);
            }
        }
    }
}
