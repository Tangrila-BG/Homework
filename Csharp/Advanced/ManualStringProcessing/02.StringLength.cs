using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _02StringLength
        {
            public static void Solution()
            {
                var input = Console.ReadLine();
                var output = input.Length <= 20 ? input.PadRight(20, '*') : input.Substring(0, 20);

                Console.WriteLine(output);
            }
        }
    }
}
