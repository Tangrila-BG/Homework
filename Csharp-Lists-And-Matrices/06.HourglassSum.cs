using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourglassSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long[][] matrix = new long[6][];

            for (int i = 0; i < 6; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }

            long sum = long.MinValue;

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    var temp =
                        // first row
                        matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                        // second row - middle element
                        matrix[row + 1][col + 1] +
                        // third row
                        matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (temp > sum)
                    {
                        sum = temp;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}