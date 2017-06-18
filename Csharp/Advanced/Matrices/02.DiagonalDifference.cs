using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _02DiagonalDifference
        {
            public static void Solution()
            {
                var rows = int.Parse(Console.ReadLine().Trim());

                var matrix = new int[rows][];

                for (int i = 0; i < rows; i++)
                    matrix[i] = Console.ReadLine()
                        .Trim()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

                var mainDiagonal = 0;
                var secondaryDiagonal = 0;

                for (int i = 0; i < rows; i++)
                {
                    mainDiagonal += matrix[i][i];
                    secondaryDiagonal += matrix[i][rows - 1 - i];
                }

                Console.WriteLine(Math.Abs(mainDiagonal - secondaryDiagonal));
            }
        }
    }
}
