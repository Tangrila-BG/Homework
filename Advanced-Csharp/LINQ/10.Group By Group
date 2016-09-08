using System;
using System.Collections.Generic;
using System.Linq;


namespace _10.GroupByGroup
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
                .GroupBy(x => int.Parse(x.Substring(x.LastIndexOf(" "))))
                .OrderBy(x => x.Key)
                .Select(g => new
                { GroupId = g.Key, Students = g.Select(x => x.Substring(0, x.LastIndexOf(" "))).ToList() })
                )
            {
                Console.WriteLine("{0} - {1}",
                    student.GroupId,
                    string.Join(", ", student.Students));
            }
        }
    }
}
