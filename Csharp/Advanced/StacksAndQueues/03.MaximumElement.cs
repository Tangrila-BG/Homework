using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _03MaximumElement {
            public static void Solution()
            {
                var t = int.Parse(Console.ReadLine());
                var stack = new Stack<int>();
                var maxStack = new Stack<int>();

                while (t-- > 0)
                {
                    var input = Console.ReadLine().Split().Select(int.Parse).ToList();

                    if (input[0] == 1)
                    {
                        if (maxStack.Count == 0)
                        {
                            maxStack.Push(input[1]);
                            stack.Push(input[1]);
                        }
                        else if (maxStack.Peek() < input[1])
                        {
                            maxStack.Push(input[1]);
                            stack.Push(stack.Peek());
                        }
                        else
                        {
                            maxStack.Push(maxStack.Peek());
                            stack.Push(input[1]);
                        }
                    }
                    else if (input[0] == 2)
                    {
                        maxStack.Pop();
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine(maxStack.Peek());
                    }
                }
            }
        }
    }
}
