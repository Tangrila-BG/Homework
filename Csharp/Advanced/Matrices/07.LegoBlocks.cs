using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _07LegoBlocks
        {
            public static void Solution()
            {
                var separators = " ,\n\t".ToCharArray();
                var n = int.Parse(Console.ReadLine().Trim());

                var matrices = new List<int[][]>();

                for (int i = 0; i < 2; i++)
                {
                    matrices.Add(new int[n][]);

                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0)
                            matrices[i][j] = Console.ReadLine()
                                .Trim()
                                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                        else
                            matrices[i][j] = Console.ReadLine()
                                .Trim()
                                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .Reverse()
                                .ToArray();

                    }
                }

                var result = new int[n][];
                for (int i = 0; i < 1; i++)
                    for (int j = 0; j < n; j++)
                        result[j] = matrices[i][j]
                            .Concat(matrices[i + 1][j]).ToArray();

                var cols = result[0].Length;
                bool rectangle = result.All(row => cols == row.Length);

                if (rectangle)
                {
                    foreach (var row in result)
                    {
                        Console.WriteLine('[' + string.Join(", ", row) + ']');
                    }
                }
                else
                {
                    var total = 0;
                    foreach (var row in result)
                        total += row.Length;

                    Console.WriteLine($"The total number of cells is: {total}");
                }
            }
        }
    }
}
