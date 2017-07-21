namespace Csharp.OOP.Advanced.Generics._03GenericSwapMethodStrings
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
