using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            var str = Convert.ToBoolean(Console.ReadLine());
            if (str == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}