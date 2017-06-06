using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _04MaximalSum
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

                // changing this value affects how big of a square
                // inside the matrix will be scanned to get the sum
                // of its elements. This means this solution
                // does not only apply to 3x3 scenario, but to NxN
                var take = 3;

                var matrix = new int[rows][];

                for (int i = 0; i < rows; i++)
                    matrix[i] = Console.ReadLine()
                        .Trim()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

                var square = new int[take][];
                var maxSum = int.MinValue;
                for (int i = 0; i <= rows - take; i++)
                {
                    for (int j = 0; j <= cols - take; j++)
                    {
                        var tempArr = new int[take][];
                        var sum = 0;

                        for (int k = 0; k < take; k++)
                        {
                            var currentRow = matrix[i + k].Skip(j).Take(take);

                            sum += currentRow.Sum();
                            tempArr[k] = currentRow.ToArray();
                        }

                        if (sum <= maxSum)
                            continue;

                        maxSum = sum;
                        square = tempArr;
                    }

                }

                Console.WriteLine("Sum = " + maxSum);
                for (int i = 0; i < take; i++)
                    Console.WriteLine(string.Join(" ", square[i]));
            }
        }
    }
}
