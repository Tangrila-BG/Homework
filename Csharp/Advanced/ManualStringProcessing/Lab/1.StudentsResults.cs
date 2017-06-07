using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing.Lab
{
    public partial class ManualStringProcessingLab
    {
        public static class _1StudentsResults
        {
            public static void Solution()
            {
                var studentsCount = int.Parse(Console.ReadLine().Trim());
                var separators = " ,-".ToCharArray();
                var students = new Dictionary<string, double[]>();

                while (studentsCount-- > 0)
                {
                    var student = Console.ReadLine().Trim()
                        .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    var studentName = student[0];
                    var cadvGrade = double.Parse(student[1]);
                    var coopGrade = double.Parse(student[2]);
                    var advOopGrade = double.Parse(student[3]);

                    if (!students.ContainsKey(studentName))
                        students.Add(studentName, new double[] { cadvGrade, coopGrade, advOopGrade });
                    else
                        students[studentName] = new double[] { cadvGrade, coopGrade, advOopGrade };
                }

                Console.WriteLine("{0, -10}|{1, 7}|{2, 7}|{3, 7}|{4, 7}|",
                    "Name", "CAdv", "COOP", "AdvOOP", "Average");

                foreach (var student in students)
                {
                    Console.WriteLine("{0, -10}|{1, 7:F2}|{2, 7:F2}|{3, 7:F2}|{4, 7:F4}|",
                        student.Key, student.Value[0], student.Value[1], student.Value[2], student.Value.Average());
                }

            }
        }
    }
}
