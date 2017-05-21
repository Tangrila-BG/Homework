using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _04BasicQueueOperations
        {
            public static void Solution()
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Queue<int> queue = new Queue<int>();
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int i = 0; i < input[0]; i++)
                    queue.Enqueue(numbers[i]);

                for (int i = 0; i < input[1]; i++)
                    queue.Dequeue();

                if (queue.Contains(input[2]))
                    Console.WriteLine("true");
                else
                    Console.WriteLine(queue.Count > 0 ? queue.Min() : 0);
            }
        }
    }
}
