using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.IteratorsAndComparators._2Collection
{
    class _2Collection
    {
        public static void Solution()
        {
            var myList = new ListyIterator<dynamic>();

            while (true)
            {
                var input = Console.ReadLine().Trim().Split();

                if (input[0].Equals("End", StringComparison.OrdinalIgnoreCase))
                    break;

                switch (input[0].ToLowerInvariant())
                {
                    case "create":
                        if (input.Length != 1)
                            myList = new ListyIterator<dynamic>(input.Skip(1).Select(x => x as dynamic).ToList());
                        break;
                    case "move":
                        Console.WriteLine(myList.Move());
                        break;
                    case "hasnext":
                        Console.WriteLine(myList.HasNext());
                        break;
                    case "print":
                        try
                        {
                            myList.Print();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                    case "printall":
                        try
                        {
                            myList.PrintAll();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                }
            }
        }
    }

    class ListyIterator<TType> : IEnumerable<TType>
    {
        private List<TType> _collection;
        private int _index;

        public bool Move()
        {
            var output = _index + 1 < _collection.Count;

            if (output)
                _index++;

            return output;
        }

        public bool HasNext()
        {
            return _index < _collection.Count - 1;
        }

        public void Print()
        {
            if (_collection.Count == 0)
                throw new ArgumentException("Invalid Operation");

            Console.WriteLine(_collection[_index]);
        }

        public void PrintAll()
        {
            if (_collection.Count == 0)
                throw new ArgumentException("Invalid Operation");

            Console.WriteLine(string.Join(" ", this));
        }

        public IEnumerator<TType> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetEnumerator();
        }

        public ListyIterator(List<TType> collection)
        {
            _collection = collection;
        }

        public ListyIterator()
        {
            _collection = new List<TType>();
        }
    }
}
