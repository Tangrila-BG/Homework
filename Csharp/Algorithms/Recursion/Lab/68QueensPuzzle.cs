using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Algorithms.Recursion.Lab
{
    class _68QueensPuzzle
    {
        private const int BoardSize = 8;
        private static bool[,] _chessBoard = new bool[BoardSize, BoardSize];

        private static HashSet<int> _attackedCols = new HashSet<int>();
        private static HashSet<int> _attackedLeftDiagonals = new HashSet<int>();
        private static HashSet<int> _attackedRightDiagonals = new HashSet<int>();

        public static void Solution()
        {
            PlaceQueen(0);
        }

        static void PlaceQueen(int row)
        {
            if (row == BoardSize)
            {
                Print();
                return;
            }

            for (int col = 0; col < BoardSize; col++)
            {
                if (!CanPlaceQueen(row, col)) continue;

                MarkAllAttackedPositions(row, col);
                PlaceQueen(row + 1);
                UnMarkAllAttackedPositions(row, col);
            }
        }

        private static void Print()
        {
            var sb = new StringBuilder();
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                    sb.Append(_chessBoard[row, col] ? "* " : "- ");

                sb.Length -= 1;
                sb.AppendLine();
                
            }
            Console.WriteLine(sb.ToString());
        }

        private static void UnMarkAllAttackedPositions(int row, int col)
        {
            _chessBoard[row, col] = false;

            _attackedCols.Remove(col);

            _attackedLeftDiagonals.Remove(row + col);
            _attackedRightDiagonals.Remove(row - col);
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            _chessBoard[row, col] = true;

            _attackedCols.Add(col);

            _attackedLeftDiagonals.Add(row + col);
            _attackedRightDiagonals.Add(row - col);
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return !_attackedCols.Contains(col)
                && !_attackedLeftDiagonals.Contains(row + col)
                && !_attackedRightDiagonals.Contains(row - col);
        }
    }
}
