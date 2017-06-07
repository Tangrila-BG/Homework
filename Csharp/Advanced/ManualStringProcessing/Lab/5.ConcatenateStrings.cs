using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing.Lab
{
    public partial class ManualStringProcessingLab
    {
        public static class _5ConcatenateStrings
        {
            public static void Solution()
            {
                var n = int.Parse(Console.ReadLine().Trim());

                var output = "";

                while (n-- > 0)
                    output += Console.ReadLine() + " ";

                output.Remove(output.Length - 1);

                Console.WriteLine(output);
            }
        }
    }
}
