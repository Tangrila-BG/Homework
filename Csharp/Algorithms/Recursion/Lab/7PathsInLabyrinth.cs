using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Algorithms.Recursion.Lab
{
    class _7PathsInLabyrinth
    {
        private static char[][] _labyrinth;
        private static int _rows;
        private static int _cols;
        private static LinkedList<char> _path = new LinkedList<char>();

        public static void Solution()
        {
            _rows = int.Parse(Console.ReadLine().Trim());
            _cols = int.Parse(Console.ReadLine().Trim());

            _labyrinth = new char[_rows][];

            for (int i = 0; i < _rows; i++)
            {
                _labyrinth[i] = Console.ReadLine().Trim().ToCharArray();
            }

            RecursiveFindAllPaths(0, 0, 'e', 'S');
            
        }

        private static void RecursiveFindAllPaths(int row, int col, char target, char direction)
        {
            if (!IsValidCell(row, col))
                return;

            _path.AddLast(direction);

            
            if (!IsValidCell(row, col))
                return;
            
            if (_labyrinth[row][col] == target)
            {
                PrintPath();
            }
            else if (_labyrinth[row][col] != 'v')
            {
                _labyrinth[row][col] = 'v';
                RecursiveFindAllPaths(row, col + 1, target, 'R');
                RecursiveFindAllPaths(row - 1, col, target, 'U');
                RecursiveFindAllPaths(row, col - 1, target, 'L');
                RecursiveFindAllPaths(row + 1, col, target, 'D');
                _labyrinth[row][col] = '-';
            }

            _path.RemoveLast();
        }

        private static void PrintPath()
        {
            Console.WriteLine(string.Join("", _path.Skip(1)));
        }

        private static bool IsValidCell(int row, int col)
        {
            return row >= 0 && row < _rows
                && col >= 0 && col < _cols
                && _labyrinth[row][col] != '*';
        }
    }
}
