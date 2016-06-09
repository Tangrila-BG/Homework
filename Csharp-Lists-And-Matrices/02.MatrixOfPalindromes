using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int rows = input[0];
            int cols = input[1];

            string[][] matrixPalindromes = new string[rows][];
            var corrector = 0;

            for (int row = 0; row < rows; row++)
            {
                var index = 0;
                string[] tempArray = new string[cols];

                for (int col = 0; col < cols; col++)
                {
                    var letters = "" + (char)(row + 97) +
                        (char)(col + corrector + 97) + (char)(row + 97);

                    tempArray[index] = letters;

                    index++;
                }

                corrector++;
                matrixPalindromes[row] = tempArray;
            }

            // prints the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrixPalindromes[row][col]);
                    if (col < cols)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
