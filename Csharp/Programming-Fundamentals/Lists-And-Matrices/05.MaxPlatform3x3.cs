using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3MaxPlatform
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split().
                Select(long.Parse).ToList();

            long rows = input[0];
            long cols = input[1];

            long[][] matrix = new long[rows][];

            for (long i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            }

            long sum = long.MinValue;
            long[,] result = new long[3, 3];

            for (long row = 0; row < rows - 2; row++)
            {
                for (long col = 0; col < cols - 2; col++)
                {
                    long temp =
                        // first row
                        matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                        // second row
                        matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                        // third row
                        matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (temp > sum)
                    {
                        sum = temp;
                        // first row
                        result[0, 0] = matrix[row][col]; result[0, 1] = matrix[row][col + 1];
                        result[0, 2] = matrix[row][col + 2];
                        // second row
                        result[1, 0] = matrix[row + 1][col];
                        result[1, 1] = matrix[row + 1][col + 1]; result[1, 2] = matrix[row + 1][col + 2];
                        // third row
                        result[2, 0] = matrix[row + 2][col]; result[2, 1] = matrix[row + 2][col + 1];
                        result[2, 2] = matrix[row + 2][col + 2];
                    }
                }
            }

            Console.WriteLine(sum);

            for (long i = 0; i < 3; i++)
            {
                for (long k = 0; k < 3; k++)
                {
                    Console.Write(result[i, k]);
                    if (k < 3)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}