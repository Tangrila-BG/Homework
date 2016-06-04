using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveofEratosthenes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long range = long.Parse(Console.ReadLine());

            bool[] primes = new bool[range + 1];

            for (long i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;

            for (long p = 0; p < primes.Length; p++)
            {
                if (primes[p] == true)
                {
                    Console.Write(p);
                    if (p < primes.Length)
                        Console.Write(" ");

                    for (long i = p; i < primes.Length; i++)
                    {
                        if (i * p < primes.Length)
                        {
                            primes[i * p] = false;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}