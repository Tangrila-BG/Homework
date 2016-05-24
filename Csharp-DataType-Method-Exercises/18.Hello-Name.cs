using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    internal class ProgrammingFundamentals
    {
        private static void Main()
        {
            Console.WriteLine(Hello());
        }

        public static string Hello()
        {
            var name = Console.ReadLine();
            return $"Hello, {name}!";
        }
    }
}