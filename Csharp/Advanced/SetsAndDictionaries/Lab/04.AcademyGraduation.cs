using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries.Lab
{
    public partial class SetsAndDictionariesLab
    {
        public static class _04AcademyGraduation
        {
            public static void Solution()
            {
                var studentCount = int.Parse(Console.ReadLine());

                var students = new SortedDictionary<string, List<double>>();
                var student = string.Empty;

                for (int i = 1; i <= studentCount * 2; i++)
                {
                    var input = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (i % 2 == 0)
                    {
                        students[student].AddRange(input.Select(double.Parse));
                    }
                    else
                    {
                        student = input[0];
                        students.Add(student, new List<double>());
                    }
                }

                foreach (var kvp in students)
                {
                    Console.WriteLine($"{kvp.Key} is graduated with {kvp.Value.Average()}");
                }
            }
        }
    }
}
