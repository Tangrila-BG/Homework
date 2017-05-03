using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // example matrix
            //
            // 11 2  4
            // 4  5  6
            // 10 8 -12
            //

            int rows = int.Parse(Console.ReadLine());

            var matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
            }

            var row = 0;
            var col = 0;
            var rDiagonal = 0;
            var lDiagonal = 0;
            var control = 0;
            var check = false;

            // starts scanning the matrix from
            // left to right, beginning at index 0,0
            while (true)
            {
                if (row == col && check == false)
                {
                    rDiagonal += matrix[row][col];
                }
                else if (row == control && col == rows - 1 - control)
                {
                    lDiagonal += matrix[row][col];
                }

                if (control < rows - 1 && check == false)
                {
                    col++;
                    row++;
                    control++;
                }
                // switches the variables so that we start
                // scanning the matrix from right to left
                // beginning at index 0,2 on the example
                else
                {
                    if (control == rows - 1 && check == true)
                        break;

                    if (!check)
                    {
                        col = rows - 1;
                        row = 0;
                        control = 0;

                        check = true;
                        continue;
                    }

                    col--;
                    row++;
                    control++;
                }
            }

            Console.WriteLine(Math.Abs(lDiagonal - rDiagonal));
        }
    }
}