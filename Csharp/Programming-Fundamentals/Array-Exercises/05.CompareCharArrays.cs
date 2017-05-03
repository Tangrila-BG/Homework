using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    internal class Program
    {
        private static void Main()
        {
            char[] array1 = Console.ReadLine().Split().
                Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split().
                Select(char.Parse).ToArray();

            Console.WriteLine(CompareCharArrays(array1, array2));
        }

        private static string CompareCharArrays(char[] array1, char[] array2)
        {
            if (array1.Length < array2.Length)
            {
                return string.Join("", array1) + "\n" +
                        string.Join("", array2);
            }
            else if (array2.Length < array1.Length)
            {
                return string.Join("", array2) + "\n" +
                        string.Join("", array1);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    if (array1[i] - '0' < array2[i] - '0')
                    {
                        return string.Join("", array1) + "\n" +
                        string.Join("", array2);
                    }
                    else
                    {
                        return string.Join("", array2) + "\n" +
                        string.Join("", array1);
                    }
                }
            }
            return string.Join("", array1) + "\n" +
                        string.Join("", array2); ;
        }
    }
}