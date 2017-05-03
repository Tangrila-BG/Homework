using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
               .Select(int.Parse).ToArray();

            int len = numbers.Length;

            int index = 0;
            int start = len / 2 - (len / 2 / 2);
            int end = len / 2 + 1;

            int[] innerArray = new int[len / 2];
            int[] outerArray = new int[len / 2];

            // for every 4th number in numbers.Length
            // adds 1 to end
            // e.g. numbers [1, 2, 3, 4]
            // end = len / 2 + 1 = 3
            // numbers [1, 2, 3, 4, 5, 6, 7, 8]
            // end = (len / 2 + 1 = 4) + (len / 4 - 1 = 1) = 5
            if (len > 4) end += len / 4 - 1;

            for (int firstRow = start; firstRow < end; firstRow++)
            {
                innerArray[index] = numbers[firstRow];
                index++;
            }

            // subtracts one from start because previously
            // start was starting at the first index we
            // wanted to extract for the innerArray
            // e.g. numbers array [1, 2, 3, 4]
            // first start is at index 1 after the
            // subtraction start is at index 0
            index = 0;
            start -= 1;
            end = 0;

            // loops until start reaches
            // arr.Length - $arr.Length / 4 - 1
            // e.g. arr of length 8 - arr.Length / 4 - 1 = 5
            while (start != len - len / 4 - 1)
            {
                outerArray[index] = numbers[start];
                index++;
                start--;

                if (start < 0)
                {
                    start = len - 1;
                    end = len / 2;
                }
            }

            // result of the addition of innerArray and outerArray
            // saved in innerArray
            for (int i = 0; i < innerArray.Length; i++)
            {
                innerArray[i] += outerArray[i];
            }

            Console.WriteLine(string.Join(" ", innerArray));
        }
    }
}