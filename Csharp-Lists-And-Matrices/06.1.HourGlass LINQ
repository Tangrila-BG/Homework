using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    private static void Main(String[] args)
        {
            int[][] arr = new int[6][];

            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int row = 0;
            int col = 0;
            int maxSum = int.MinValue;

            while (true)
            {
                int sum = 0;
                sum += arr[row].Skip(col).Take(3).Sum();
                sum += arr[row + 1].Skip(col + 1).Take(1).Sum();
                sum += arr[row + 2].Skip(col).Take(3).Sum();
                col++;

                if (sum > maxSum)
                    maxSum = sum;

                // if we take less than 3 numbers we go one row down
                // and start from col 0
                if (arr[row].Skip(col).Take(3).Count() < 3)
                {
                    col = 0;
                    row++;
                    if (row >= arr.Length - 2)
                        break;
                }
            }
            Console.WriteLine(maxSum);
        }
}
