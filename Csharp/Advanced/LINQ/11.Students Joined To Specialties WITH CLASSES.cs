using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        public static void _11StudentsJoinedToSpecialties(string[] args)
        {
            List<StudentSpecialty> specialties = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "Students:")
                {
                    while (true)
                    {
                        input = Console.ReadLine().Split();
                        if (input[0] == "END")
                            break;

                        int fNumber = int.Parse(input[0]);
                        string studentName = input[1] + " " + input[2];
                        students.Add(new Student {StudentName = studentName, FacultyNumber = fNumber});
                    }
                    break;
                }
                string specialty = input[0] + " " + input[1];
                int facultyNumber = int.Parse(input[2]);

                specialties.Add(new StudentSpecialty {FacultyNumber = facultyNumber, SpecialtyName = specialty});
            }
            var joined = from st in students
                join sp in specialties on
                st.FacultyNumber equals sp.FacultyNumber
                select new {Student = st.StudentName, FacNum = sp.FacultyNumber, sp.SpecialtyName};

            foreach (var result in joined.OrderBy(x => x.Student))
                Console.WriteLine($"{result.Student} {result.FacNum} {result.SpecialtyName}");

        }
        private class StudentSpecialty
        {
            public string SpecialtyName { get; set; }

            public int FacultyNumber { get; set; }
        }

        private class Student
        {
            public string StudentName { get; set; }
            public int FacultyNumber { get; set; }
        }

    }
}
