using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, b, c));
        }

        public static int GetMax(int a, int b, int c)
        {
            return (Math.Max(c, Math.Max(a, b)));
        }
    }
}