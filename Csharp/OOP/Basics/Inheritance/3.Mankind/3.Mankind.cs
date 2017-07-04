using System;
using System.Text.RegularExpressions;

namespace Csharp.OOP.Basics.Inheritance._3.Mankind
{
    public static partial class _3Mankind
    {
        public static void Solution()
        {
            var studentInfo = Console.ReadLine().Trim().Split();
            var workerInfo = Console.ReadLine().Trim().Split();

            var workerSalary = double.Parse(workerInfo[2]);
            var workHoursPerDay = double.Parse(workerInfo[3]);

            try
            {
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0], workerInfo[1], workerSalary, workHoursPerDay);
                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static bool IsNumberInvalid(string value)
        {
            bool isNumberInvalid = false;

            string numberPattern = @"^([0-9a-zA-Z]{5,10})$";

            var regex = new Regex(numberPattern);

            var match = regex.Match(value);

            if (match.Success)
                return isNumberInvalid;

            return !isNumberInvalid;
        }
    }
}
