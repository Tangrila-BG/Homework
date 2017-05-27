using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _01ReverseNumbers
        {
            public static void Solution()
            {
                Console.WriteLine(string.Join(" ", new Stack<string>(Console.ReadLine().Split())));
            }
        }
    }
}
