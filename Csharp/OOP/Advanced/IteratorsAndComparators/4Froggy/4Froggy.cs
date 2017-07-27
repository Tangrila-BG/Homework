using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.IteratorsAndComparators._4Froggy
{
    class _4Froggy
    {
        public static void Solution()
        {
            var lake = new Lake(Console.ReadLine().Trim()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Console.WriteLine(lake);
        }

        class CustomComparator : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                bool IsEven(int a) => a % 2 == 0;

                if (IsEven(x) && !IsEven(y))
                    return 1;
                if (!IsEven(x) && IsEven(y))
                    return -1;
                if (x > y && IsEven(y))
                    return -1;

                return 0;
            }
        }

        class Lake : IEnumerable<int>
        {
            private int[] _stones;

            public IEnumerator<int> GetEnumerator()
            {
                return (IEnumerator<int>)_stones.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public override string ToString()
            {
                this.Order();
                return string.Join(", ", _stones);
            }

            private void Order()
            {
                Array.Sort(_stones, new CustomComparator());
            }

            public Lake(int[] stones)
            {
                _stones = stones;
            }
        }
    }
}
