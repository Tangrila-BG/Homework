using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _05SequenceWithQueue
        {
            public static void Solution()
            {
                var n = long.Parse(Console.ReadLine());

                var members = 50;
                var calcs = new Queue<long>();
                var result = new long[50];
                calcs.Enqueue(n);

                for (int i = 0; i < members; ++i)
                {
                    long current = calcs.Dequeue();

                    result[i] = current;

                    calcs.Enqueue(current + 1); // S1
                    calcs.Enqueue(2 * current + 1); // S2
                    calcs.Enqueue(current + 2); // S3
                }

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
