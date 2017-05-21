using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _02BasicStackOperations { 
            public static void Solution()
            {
                Stack<int> stack = new Stack<int>();

                var instructions = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                numbers.ForEach(x => stack.Push(x));
                for (int i = 0; i < instructions[1]; i++)
                    stack.Pop();

                if (stack.Count == 0)
                    Console.WriteLine(0);
                else if (stack.Contains(instructions[2]))
                    Console.WriteLine("true");
                else
                    Console.WriteLine(stack.Min());

            }
        }
    }
}
