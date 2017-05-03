using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresInMatrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int rows = input[0];
            int cols = input[1];

            var matrix = new string[rows][];

            // fills the matrix
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split().ToArray();
            }

            var result = 0;

            // scans for 2x2 square of equal cells
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row][col] == matrix[row][col + 1] &&
                        matrix[row][col] == matrix[row + 1][col] &&
                        matrix[row][col] == matrix[row + 1][col + 1])
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}