using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _09StudentsEnrolledIn2014Or2015(string[] args)
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
                .Where(x => x.Substring(x.IndexOf(" ") - 2, 2).CompareTo("14") == 0 ||
                 x.Substring(x.IndexOf(" ") - 2, 2).CompareTo("15") == 0)
                .Select(x => x.Substring(x.IndexOf(" ")).Trim()))
            {
                Console.WriteLine(student);
            }
        }
    }
}
