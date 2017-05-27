using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _06CountSubstringOccurrences
        {
            public static void Solution()
            {
                var stack = Console.ReadLine();
                string hay = Console.ReadLine();

                var count = 0;
                for (int i = 0; i < stack.Length - hay.Length + 1; i++)
                {
                    if (String.Equals(stack.Substring(i, hay.Length),
                            hay,
                            StringComparison.InvariantCultureIgnoreCase))
                        ++count;
                }

                Console.WriteLine(count);
            }
        }
    }
}
