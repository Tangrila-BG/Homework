using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _11StudentsJoinedToSpecialtiesWithoutClasses(string[] args)
        {
            List<string> info = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "end")
                    break;
                if (input.ToLower() == "students:")
                    continue;
                info.Add(input);
            }

            var specialties = info.Where(x => char.IsLetter(x[0]))
                .Select(x => new { Specialty = x.Substring(0, x.LastIndexOf(" ")).Trim(),
                    FacNum = int.Parse(x.Substring(x.LastIndexOf(" ")).Trim()) });

            var students = info.Where(x => char.IsDigit(x[0]))
                .Select(
                    x => new {StudentName = x.Substring(x.IndexOf(" ")).Trim(),
                        FacNum = int.Parse(x.Substring(0, x.IndexOf(" ")).Trim())});

            var joined = students.Join(specialties, st => st.FacNum, sp => sp.FacNum, (st, sp) => new
            {
                StudentName = st.StudentName,
                FacultyNumber = st.FacNum,
                Specialty = sp.Specialty
            }).OrderBy(x => x.StudentName);

            foreach (var student in joined)
                Console.WriteLine($"{student.StudentName} {student.FacultyNumber} {student.Specialty}");
        }
    }
}
