using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablinHexFormat
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            var hex1 = Console.ReadLine();
            var temp = hex1.Substring(2, hex1.Length - 2);
            decimal converted = Int32.Parse(temp, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine(converted);
        }
    }
}