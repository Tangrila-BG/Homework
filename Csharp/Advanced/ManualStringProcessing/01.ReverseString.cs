using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _01ReverseString
        {
            public static void Solution()
            {
                var input = Console.ReadLine();
                var output = new StringBuilder();

                for (int i = input.Length - 1; i >= 0; --i)
                    output.Append(input[i]);

                Console.WriteLine(output);
            }
        }
    }
}
