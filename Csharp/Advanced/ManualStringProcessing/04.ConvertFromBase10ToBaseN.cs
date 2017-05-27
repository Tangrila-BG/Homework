using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _04ConvertFromBase10ToBaseN
        {
            public static void Solution()
            {
                var input = Console.ReadLine().Split();

                var toBase = int.Parse(input[0]);
                var number = BigInteger.Parse(input[1]);

                var converted = string.Empty;

                while (number > 0)
                {
                    // prepend
                    converted = number % (ulong)toBase + converted;
                    number /= (ulong)toBase;
                }

                Console.WriteLine(converted);
            }
        }
    }
}
