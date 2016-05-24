using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60m;
            decimal seconds = minutes * 60m;
            decimal miliseconds = seconds * 1000m;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.Write($"{centuries} centuries = ");
            Console.Write($"{years} years = ");
            Console.Write($"{days} days = ");
            Console.Write($"{hours} hours = ");
            Console.Write($"{minutes} minutes = ");
            Console.Write($"{seconds} seconds = ");
            Console.Write($"{miliseconds} milliseconds = ");
            Console.Write($"{microseconds} microseconds = ");
            Console.Write($"{nanoseconds} nanoseconds");
        }
    }
}