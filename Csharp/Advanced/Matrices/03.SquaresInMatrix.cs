using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _03SquaresInMatrix
        {
            public static void Solution()
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int rows = input[0];
                int cols = input[1];

                var matrix = new string[rows][];

                // fills the matrix
                for (int i = 0; i < rows; i++)
                    matrix[i] = Console.ReadLine().Split().ToArray();

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
}
