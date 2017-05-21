using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _08RecursiveFibonacci
        {
            public static void Solution()
            {
                Console.WriteLine(
                    NthFibonacci(
                        byte.Parse(Console.ReadLine()),
                        new Dictionary<ulong, ulong>()
                        ));
            }

            public static ulong NthFibonacci(ulong nth, Dictionary<ulong, ulong> memoize)
            {
                if (nth <= 2)
                    return 1;

                ulong value;
                if (memoize.TryGetValue(nth, out value))
                    return value;

                value = NthFibonacci(nth - 1, memoize) + NthFibonacci(nth - 2, memoize);
                memoize.Add(nth, value);
                return value;
            }
        }
    }
}
