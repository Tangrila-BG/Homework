using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices.Lab
{
    public partial class MatricesLab
    {
        public static class _03GroupNumbers
        {
            public static void Solution()
            {
                var separators = " ,".ToCharArray();

                var numbers = Console.ReadLine()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                List<int>[] matrix = new List<int>[3];

                for (int i = 0; i < matrix.Length; i++)
                    matrix[i] = new List<int>();

                foreach (var number in numbers)
                {
                    var remainder = Math.Abs(number % 3);

                    switch (remainder)
                    {
                        case 0:
                            matrix[0].Add(number);
                            break;
                        case 1:
                            matrix[1].Add(number);
                            break;
                        case 2:
                            matrix[2].Add(number);
                            break;
                    }
                }

                foreach (var row in matrix)
                    Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
