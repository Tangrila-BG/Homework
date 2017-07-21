namespace Csharp.OOP.Advanced.Generics._02GenericBoxOfInteger
{
    class Box<TType>
    {
        private TType _val;

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
