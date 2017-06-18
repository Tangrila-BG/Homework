using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _08RadioactiveBunnies
        {
            public static void Solution()
            {
                var input = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var rows = input[0];
                var cols = input[1];

                // key: row, value: col
                var player = new KeyValuePair<int, int>();

                var matrix = new char[rows][];

                for (int row = 0; row < rows; row++)
                {
                    matrix[row] = Console.ReadLine()
                        .Trim()
                        .ToCharArray();

                    // find player's position
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row][col] != 'P')
                            continue;

                        player = new KeyValuePair<int, int>(row, col);
                    }
                }

                var commands = Console.ReadLine().Trim();

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("", row));
                }
            }
        }
    }
}
