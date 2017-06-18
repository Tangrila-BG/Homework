using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.Matrices
{
    public partial class Matrices
    {
        public static class _09Crossfire
        {
            public static void Solution()
            {
                var dimensions = Console.ReadLine().Trim().Split()
                    .Select(int.Parse)
                    .ToArray();

                var rows = dimensions[0];
                var cols = dimensions[1];

                var matrix = new List<int>[rows];

                var n = 1;
                for (int row = 0; row < rows; row++)
                {
                    matrix[row] = new List<int>();

                    for (int col = 0; col < cols; col++)
                        matrix[row].Add(n++);
                }

                var commands = new List<CrossFire>();

                ReadCommands(commands);
                Destroy(matrix, commands);

                foreach (var list in matrix.Where(x => x.Count > 0))
                    Console.WriteLine(string.Join(" ", list));
            }

            private static void Destroy(List<int>[] matrix, List<CrossFire> commands)
            {
                foreach (var crossFire in commands)
                {

                    var beginX = crossFire.X - crossFire.R;
                    var endX = crossFire.X + crossFire.R;

                    for (int x = endX; x >= beginX; x--)
                    {
                        if (IsInRange(matrix, crossFire.Y, x))
                            matrix[crossFire.Y].RemoveAt(x);
                    }

                    var beginY = crossFire.Y - crossFire.R;
                    var endY = crossFire.Y + crossFire.R;

                    for (int y = beginY; y < endY; y++)
                    {
                        if (IsInRange(matrix, y, crossFire.X))
                            matrix[y].RemoveAt(crossFire.X);
                    }
                }
            }

            private static void ReadCommands(List<CrossFire> commandlList)
            {
                while (true)
                {
                    var input = Console.ReadLine().Trim();

                    if (input.ToLower() == "nuke it from orbit")
                        break;

                    var args = input.Split()
                        .Select(int.Parse)
                        .ToArray();

                    // row, col, radius
                    commandlList.Add(new CrossFire(args[0], args[1], args[2]));
                }
            }

            private static bool IsInRange(List<int>[] matrix, int row, int col)
            {
                return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Count;
            }

            private struct CrossFire
            {
                public int X { get; }
                public int Y { get; }
                public int R { get; }

                public CrossFire(int row, int col, int radius)
                {
                    X = col;
                    Y = row;
                    R = radius;
                }
            }
        }
    }
}
