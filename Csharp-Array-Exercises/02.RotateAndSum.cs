using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            int rotateRight = int.Parse(Console.ReadLine());

            int[] sumNumbers = new int[numbers.Length];

            for (int i = 0; i < rotateRight; i++)
            {
                for (int k = numbers.Length - 1; k > 0; k--)
                {
                    var old = numbers[k];
                    numbers[k] = numbers[k - 1];
                    numbers[k - 1] = old;
                }

                for (int k = 0; k < numbers.Length; k++)
                {
                    sumNumbers[k] += numbers[k];
                }
            }

            Console.WriteLine(string.Join(" ", sumNumbers));
        }
    }
}