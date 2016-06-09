using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string type = input[0].ToUpper();
            long rows = long.Parse(input[1]);
            long cols = long.Parse(input[2]);

            long[,] matrix = new long[rows, cols];

            if (type == "A")
            {
                typeA(matrix, rows, cols);
            }
            else if (type == "B")
            {
                typeB(matrix, rows, cols);
            }
            else if (type == "C")
            {
                typeC(matrix, rows, cols);
            }
            else if (type == "D")
            {
                typeD(matrix, rows, cols);
            }

            printMatrix(matrix, rows, cols);
        }

        private static void printMatrix(long[,] matrix, long rows, long cols)
        {
            for (long row = 0; row < rows; row++)
            {
                for (long col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                    if (col < cols)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void typeA(long[,] matrix, long rows, long cols)
        {
            long value = 1;
            long row = 0;
            long col = 0;

            while (value <= matrix.Length)
            {
                matrix[row, col] = value++;
                row++;
                if (row > rows - 1)
                {
                    row = 0;
                    col++;
                }
            }
        }

        private static void typeB(long[,] matrix, long rows, long cols)
        {
            long value = 1;
            long col = 0;
            long row = 0;
            int dir = 0;

            //
            // walks through the matrix 0,0 to rows-1,0
            // then col++ continues from rows-1,1 to 0,1
            // then col++ continues from 0,2 to rows-1,2
            // and so on
            //

            while (value <= matrix.Length)
            {
                matrix[row, col] = value++;

                if (dir == 0)
                {
                    row++;
                }
                else if (dir == 1)
                {
                    row--;
                }

                if (row > rows - 1)
                {
                    row--;
                    dir++;
                    col++;
                }
                else if (row < 0)
                {
                    row++;
                    dir++;
                    col++;
                }

                dir %= 2;
            }
        }

        private static void typeC(long[,] matrix, long rows, long cols)
        {
            long value = 1;
            long startRow = rows - 1;

            while (value <= matrix.Length)
            {
                long row = startRow;
                long col = 0;
                for (; row < rows && col < cols; row++, col++)
                {
                    if (row >= 0 && value <= matrix.Length)
                    {
                        matrix[row, col] = value++;
                    }
                }
                startRow--;
            }
        }

        private static void typeD(long[,] matrix, long rows, long cols)
        {
            long value = 1;
            long top = 0;
            long bottom = rows - 1;
            long left = 0;
            long right = cols - 1;
            long move = 0;

            while (value <= matrix.Length)
            {
                if (move == 0)
                {
                    for (long i = top; i <= bottom; i++)
                    {
                        matrix[i, left] = value++;
                    }
                    left++; move++;
                }
                else if (move == 1)
                {
                    for (long i = left; i <= right; i++)
                    {
                        matrix[bottom, i] = value++;
                    }
                    bottom--; move++;
                }
                else if (move == 2)
                {
                    for (long i = bottom; i >= top; i--)
                    {
                        matrix[i, right] = value++;
                    }
                    right--; move++;
                }
                else if (move == 3)
                {
                    for (long i = right; i >= left; i--)
                    {
                        matrix[top, i] = value++;
                    }
                    top++; move++;
                }
                move %= 4;
            }
        }
    }
}