using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long ID = long.Parse(Console.ReadLine());
            long employeeNum = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", fName);
            Console.WriteLine("Last name: {0}", lName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", ID);
            Console.WriteLine("Unique Employee number: {0}", employeeNum);
        }
    }
}