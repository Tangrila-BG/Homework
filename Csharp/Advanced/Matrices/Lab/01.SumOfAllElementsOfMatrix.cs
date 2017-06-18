using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices.Lab
{
    public partial class MatricesLab
    {
        public static class _01SumOfAllElementsOfMatrix
        {
            public static void Solution()
            {
                var separators = " ,\t\n".ToCharArray();
                var input = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var rows = input[0];
                var cols = input[1];

                var matrix = new int[rows][];

                for (int i = 0; i < rows; i++)
                    matrix[i] = Console.ReadLine()
                        .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                Console.WriteLine(rows + "\n" + cols);
                Console.WriteLine(matrix.SelectMany(x => x).Sum());
            }
        }
    }
}
