using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversedchars
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            string str = Console.ReadLine();
            str += Console.ReadLine();
            str += Console.ReadLine();
            string str2 = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 += "" + str[i];
            }
            Console.WriteLine(str);
        }
    }
}