using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices.Lab
{
    public partial class MatricesLab
    {
        public static class _04PascalTriangle
        {
            public static void Solution()
            {
                var rows = long.Parse(Console.ReadLine());

                var matrix = new long[rows][];
                matrix[0] = new long[] { 1 };

                for (long i = 1; i < rows; i++)
                {
                    matrix[i] = new long[i + 1];
                    for (long j = 0; j < i + 1; j++)
                    {
                        if (j - 1 < 0)
                            matrix[i][j] = matrix[i - 1][j];
                        else if (j >= i)
                            matrix[i][j] = matrix[i - 1][j - 1];
                        else
                            matrix[i][j] = matrix[i - 1][j - 1] + matrix[i - 1][j];
                    }
                }

                foreach (var row in matrix)
                    Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
