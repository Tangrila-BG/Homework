using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Split(' ').ToArray();

            int shorterArray = Math.Min(array1.Length, array2.Length);

            int countRight = 0;
            int countLeft = 0;

            // scanning from the right
            while (countRight < array1.Length &&
                   countRight < array2.Length)
                if (array1[array1.Length - countRight - 1] ==
                    array2[array2.Length - countRight - 1])
                    countRight++;
                else
                    break;

            // scanning from the left
            for (int i = 0; i < shorterArray; i++)
            {
                if (array1[i].Equals(array2[i]))
                    countLeft++;
            }

            if (countLeft >= countRight)
                Console.WriteLine(countLeft);
            else
                Console.WriteLine(countRight);
        }
    }
}
