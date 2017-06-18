using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _06TargetPractice
        {
            public static void Solution()
            {
                var separators = " ,\n\t".ToCharArray();

                var rc = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var rows = rc[0];
                var cols = rc[1];
                var matrix = new char[rows][];

                var snake = Console.ReadLine();
                var shot = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                FillWithSnakes(matrix, snake, rows, cols);
                ShootSnakes(matrix, shot[0], shot[1], shot[2]);
                FallDown(matrix);

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("", row));
                }


            }

            private static void FallDown(char[][] matrix)
            {
                int width = matrix[0].Length;

                for (int row = matrix.Length - 1; row >= 0; row--)
                {
                    for (int column = 0; column < width; column++)
                    {
                        if (matrix[row][column] != ' ')
                            continue;

                        int currentRow = row - 1;
                        while (currentRow >= 0)
                        {
                            if (matrix[currentRow][column] != ' ')
                            {
                                matrix[row][column] = matrix[currentRow][column];
                                matrix[currentRow][column] = ' ';
                                break;
                            }

                            currentRow--;
                        }
                    }
                }


            }

            private static void ShootSnakes(char[][] matrix, int impactRow, int impactCol, int radius)
            {
                int temp = 0;
                for (int i = Math.Max(impactRow - radius, 0); i <= impactRow; i++)
                {
                    for (int j = Math.Max(impactCol - (temp / 2), 0); j <= Math.Min(impactCol + (temp / 2), matrix[i].Length - 1); j++)
                        matrix[i][j] = ' ';
                    temp += radius;
                }

                temp = 0;
                for (int i = Math.Min(impactRow + radius, matrix.GetLength(0) - 1); i > impactRow; i--)
                {
                    for (int j = Math.Max(impactCol - temp / 2, 0); j <= Math.Min(impactCol + temp / 2, matrix[i].Length - 1); j++)
                        matrix[i][j] = ' ';

                    temp += radius;
                }

            }

            private static void FillWithSnakes(char[][] matrix, string snake, int rows, int cols)
            {
                var remainder = new StringBuilder();
                var hasRemainder = snake.Length > cols;
                bool moveLeft = true;

                for (int i = rows - 1; i >= 0; --i)
                {
                    var temp = remainder.Length;

                    if (remainder.Length <= 0)
                    {
                        if (moveLeft)
                            matrix[i] = snake.Substring(0, cols)
                                .Reverse()
                                .ToArray();
                        else
                            matrix[i] = snake.Substring(0, cols)
                                .ToArray();
                    }

                    if (remainder.Length > 0)
                    {
                        if (moveLeft)
                            matrix[i] = (remainder + snake.Substring(0, Math.Abs(cols - remainder.Length)))
                                .ToArray();
                        else
                            matrix[i] = (remainder + snake.Substring(0, Math.Abs(cols - remainder.Length)))
                                .Reverse()
                                .ToArray();

                        remainder.Length = 0;
                    }

                    if (hasRemainder)
                        remainder.Append(snake.Substring(Math.Abs(cols - temp)));

                    moveLeft = !moveLeft;

                    if (i == rows - 1)
                        moveLeft = !moveLeft;
                }

            }

        }
    }
}
