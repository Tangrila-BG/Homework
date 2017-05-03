using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                factorial += (i-1) * factorial;
            } 
            Console.WriteLine(factorial);
        }
    }
}
