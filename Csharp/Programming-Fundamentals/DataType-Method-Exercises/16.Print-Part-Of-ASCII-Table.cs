using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfASCIItable
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            for (int i = from; i <= to; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}