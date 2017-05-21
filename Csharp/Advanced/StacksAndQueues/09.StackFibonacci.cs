using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _09StackFibonacci
        {
            public static void Solution()
            {
                // ulong cannot handle more than 93nth fibonacci number
                var nth = byte.Parse(Console.ReadLine());

                var stack = new Stack<ulong>();

                stack.Push(1);
                stack.Push(1);

                while (--nth > 0)
                {
                    var top = stack.Pop();
                    var bottom = stack.Pop();
                    stack.Push(top);
                    stack.Push(top + bottom);
                }

                stack.Pop();
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
