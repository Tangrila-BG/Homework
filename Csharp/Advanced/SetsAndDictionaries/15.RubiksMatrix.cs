using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _15RubiksMatrix
        {
            public static void Solution()
            {
                var rc = Console.ReadLine().Split();

                var rows = int.Parse(rc[0]);
                var cols = int.Parse(rc[1]);
                var matrix = new int[rows][];

                for (int i = 0; i < rows; i++)
                    matrix[i] = Enumerable.Range(cols * i + 1, cols).ToArray();

                var commands = int.Parse(Console.ReadLine());

                while (commands-- > 0)
                {
                    var args = Console.ReadLine().Split();

                    var position = int.Parse(args[0]);
                    var direction = args[1];
                    var moves = int.Parse(args[2]);

                    switch (direction)
                    {
                        // move the column moves times in the direction
                        case "down":
                        case "up":
                            MoveColumn(matrix, position, moves, direction == "up");
                            break;

                        // move the row moves times in the direction
                        case "left":
                        case "right":
                            MoveRow(matrix, position, moves, direction == "left");
                            break;
                    }
                }

                RearrangeMatrix(matrix);

                //foreach (var row in matrix)
                //{
                //    Console.WriteLine(string.Join(" ", row));
                //}
            }

            public static void RearrangeMatrix(int[][] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        int initValue = i * matrix[i].Length + (j + 1);
                        int currentValue = matrix[i][j];

                        if (initValue != currentValue)
                        {
                            for (int k = 0; k < matrix.GetLength(0); k++)
                            {
                                var currentRow = matrix[k];
                                int index = Array.IndexOf(currentRow, initValue);

                                if (index > -1)
                                {
                                    matrix[k][index] = currentValue;
                                    matrix[i][j] = initValue;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({k}, {index})");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No swap required");
                        }
                    }
                }
            }

            private static void MoveColumn(int[][] matrix, int col, int moves, bool up)
            {
                for (int i = 0; i < moves; i++)
                {
                    // move up
                    if (up)
                    {
                        for (int j = 0; j < matrix.GetLength(0) - 1; j++)
                        {
                            var temp = matrix[j][col]; ;
                            matrix[j][col] = matrix[j + 1][col];
                            matrix[j + 1][col] = temp;
                        }
                    }
                    // move down
                    else
                    {
                        for (int j = matrix.GetLength(0) - 1; j > 0; j--)
                        {
                            var temp = matrix[j][col];
                            matrix[j][col] = matrix[j - 1][col];
                            matrix[j - 1][col] = temp;
                        }
                    }
                }
            }

            private static void MoveRow(int[][] matrix, int row, int moves, bool left)
            {
                if (!left)
                    RotateArrayRight(matrix[row], moves);

                if (left)
                    RotateArrayLeft(matrix[row], moves);
            }

            private static void RotateArrayRight<T>(T[] array, int count)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException("count");

                if (count == 0)
                    return;

                // If (count == array.Length) there is nothing to do.
                // So we need the remainder (count % array.Length):
                count %= array.Length;

                // Create a temp array to store the tail of the source array
                T[] tmp = new T[count];

                // Copy tail of the source array to the temp array
                Array.Copy(array, array.Length - count, tmp, 0, count);

                // Shift elements right in the source array
                Array.Copy(array, 0, array, count, array.Length - count);

                // Copy saved tail to the head of the source array
                Array.Copy(tmp, array, count);
            }

            private static void RotateArrayLeft<T>(T[] array, int count)
            {
                if (count < 0)
                    throw new ArgumentOutOfRangeException("count");

                if (count == 0)
                    return;

                // If (count == array.Length) there is nothing to do.
                // So we need the remainder (count % array.Length):
                count %= array.Length;

                // Create a temp array to store the tail of the source array
                T[] tmp = new T[count];

                // Copy head of the source array to the temp array
                Array.Copy(array, tmp, count);

                // Shift elements left in the source array
                Array.Copy(array, count, array, 0, array.Length - count);

                // Copy saved head to the tail of the source array
                Array.Copy(tmp, 0, array, array.Length - count, tmp.Length);
            }
        }
    }
}
