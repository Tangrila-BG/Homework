using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.IteratorsAndComparators._3Stack
{
    class _3Stack
    {
        public static void Solution()
        {
            var stack = new CustomStack<int>();
            while (true)
            {
                var input = Console.ReadLine().Trim()
                    .Split(new string[] {" ", ", "}, StringSplitOptions.RemoveEmptyEntries);

                if (input[0].Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;
                try
                {
                    switch (input[0].ToLowerInvariant())
                    {
                        case "push":
                            foreach (var item in input.Skip(1).Select(int.Parse))
                            {
                                stack.Push(item);
                            }
                            break;
                        case "pop":
                            stack.Pop();
                            break;
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }

        class CustomStack<T> : ICollection, IReadOnlyCollection<T>
        {
            private T[] _array;
            static T[] _emptyArray = new T[0];
            private const int DefaultCapacity = 4;
            private int _size;
            private int _version;

            [NonSerialized]
            private Object _syncRoot;

            public object SyncRoot => _syncRoot;
            public bool IsSynchronized => false;

            int ICollection.Count => _array.Length;
            int IReadOnlyCollection<T>.Count => _array.Length;

            public int Count => _size;

            bool ICollection.IsSynchronized => false;

            Object ICollection.SyncRoot
            {
                get
                {
                    if (_syncRoot == null)
                        System.Threading.Interlocked.CompareExchange<object>(ref _syncRoot, new Object(), null);

                    return _syncRoot;
                }
            }

            public void Push(T element)
            {
                if (_size == _array.Length)
                   Grow();

                _array[_size++] = element;
                _version++;
            }

            public T Pop()
            {
                if (_size == 0)
                    throw new InvalidOperationException("No elements");

                _version++;
                var element = _array[--_size];
                _array[_size] = default(T); // Free memory quicker. 
                return element;
            }

            private void Grow()
            {
                var newArray = new T[_array.Length == 0 ? DefaultCapacity : 2 * _array.Length];
                Array.Copy(_array, 0, newArray, 0, _size);
                _array = newArray;
            }

            public IEnumerator<T> GetEnumerator()
            {
                return new Enumerator(this);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public void CopyTo(Array array, int index)
            {
                if (array == null)
                    throw new ArgumentNullException(nameof(array), "must not be null");
                
                if (array.Rank != 1)
                    throw new ArgumentException("Muldimensional array not supported.");

                if (array.GetLowerBound(0) != 0)
                    throw new ArgumentException("Lower bound must not be a zero.");

                if (index < 0 || index > array.Length)
                    throw new ArgumentOutOfRangeException(nameof(index), index, "must be non-negative.");

                if (array.Length - index < _size)
                    throw new ArgumentException("Invalid length");

                try
                {
                    Array.Copy(_array, 0, array, index, _size);
                    Array.Reverse(array, index, _size);
                }
                catch (ArrayTypeMismatchException)
                {
                    throw new ArgumentException("Invalid array type");
                }
            }

            private struct Enumerator : IEnumerator<T>
            {
                private CustomStack<T> _stack;
                private int _index;
                private int _version;
                private T currentElement;

                internal Enumerator(CustomStack<T> stack)
                {
                    _stack = stack;
                    _version = _stack._version;
                    _index = -2;
                    currentElement = default(T);
                }

                public void Dispose()
                {
                    _index = -1;
                }

                public bool MoveNext()
                {
                    bool retval;
                    if (_version != _stack._version)
                        throw new InvalidOperationException("Enum failed version");

                    if (_index == -2)
                    {  // First call to enumerator.
                        _index = _stack._size - 1;
                        retval = (_index >= 0);

                        if (retval)
                            currentElement = _stack._array[_index];

                        return retval;
                    }
                    if (_index == -1)
                    {  // End of enumeration.
                        return false;
                    }

                    retval = (--_index >= 0);

                    currentElement = retval ? _stack._array[_index] : default(T);

                    return retval;
                }
                
                public T Current
                {
                    get
                    {
                        if (_index == -2)
                            throw new InvalidOperationException("enumration not started");
                        if (_index == -1)
                            throw new InvalidOperationException("enumration ended");

                        return currentElement;
                    }
                }

                Object IEnumerator.Current
                {
                    get
                    {
                        if (_index == -2)
                            throw new InvalidOperationException("enumration not started");
                        if (_index == -1)
                            throw new InvalidOperationException("enumration ended");

                        return currentElement;
                    }
                }

                void IEnumerator.Reset()
                {
                    if (_version != _stack._version)
                        throw new InvalidOperationException("Enum failed version");

                    _index = -2;
                    currentElement = default(T);
                }
            }

            public CustomStack(IEnumerable<T> collection)
            {
                if (collection == null)
                    throw new ArgumentNullException(nameof(collection), "Provided collection is null");

                var c = collection as ICollection<T>;
                if (c != null)
                {
                    int count = c.Count;
                    _array = new T[count];
                    c.CopyTo(_array, 0);
                    _size = count;
                }
                else
                {
                    _size = 0;
                    _array = new T[DefaultCapacity];

                    using (var en = collection.GetEnumerator())
                    {
                        while (en.MoveNext())
                        {
                            this.Push(en.Current);
                        }
                    }
                }
            }

            public CustomStack(int capacity)
            {
                if (capacity < 0)
                    throw new ArgumentOutOfRangeException(nameof(capacity), capacity, "Provided capacity is out of range.");

                _array = new T[capacity];
                _size = 0;
                _version = 0;
            }

            public CustomStack()
            {
                _array = _emptyArray;
                _size = 0;
                _version = 0;
            }
        }
    }
}
