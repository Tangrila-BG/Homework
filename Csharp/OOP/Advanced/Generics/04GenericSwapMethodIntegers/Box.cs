namespace Csharp.OOP.Advanced.Generics._04GenericSwapMethodIntegers
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
