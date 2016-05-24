using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001m;

            if (Math.Abs(a - b) < eps)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}