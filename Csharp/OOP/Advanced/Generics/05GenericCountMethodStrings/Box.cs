using System;

namespace Csharp.OOP.Advanced.Generics._05GenericCountMethodStrings
{
    class Box<TType> : IComparable<TType> where TType : IComparable
    {
        private TType _val;

        public int CompareTo(TType other)
        {
            return _val.CompareTo(other);
        }

        public override string ToString()
        {
            return $"{typeof(TType).FullName}: {_val}";
        }

        public Box(TType val)
        {
            _val = val;
        }
    }
}
