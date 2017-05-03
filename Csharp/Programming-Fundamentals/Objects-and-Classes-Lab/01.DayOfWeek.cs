using System;
using System.Linq;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('-').Select(x => Convert.ToInt32(x)).ToArray();
            DateTime date = new DateTime(input[2], input[1], input[0]);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
