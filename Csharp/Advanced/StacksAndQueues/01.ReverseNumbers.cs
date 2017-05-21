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
                Stack<string> stack = new Stack<string>();

                var input = Console.ReadLine().Split().ToList();
                input.ForEach(x => stack.Push(x));

                Console.WriteLine(string.Join(" ", stack.ToArray()));
            }
        }
    }
}
