using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _06FilterStudentsByPhone(string[] args)
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
                .Where(x => x.Substring(x.LastIndexOf(" ") + 1).StartsWith("02") ||
                x.Substring(x.LastIndexOf(" ") + 1).StartsWith("+3592"))
                .Select(x => x.Substring(0, x.LastIndexOf(" "))))
            {
                Console.WriteLine(student);
            }
        }
    }
}
