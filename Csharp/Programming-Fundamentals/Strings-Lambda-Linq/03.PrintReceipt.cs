using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAReceipt
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine("/----------------------\\");
            foreach (var num in numbers)
            {
                Console.WriteLine("|{0,21:F2} |", num);
            }
            Console.WriteLine("|----------------------|");
            Console.WriteLine("| Total: {0,13:F2} |", numbers.Sum());
            Console.WriteLine("\\----------------------/");
        }
    }
}