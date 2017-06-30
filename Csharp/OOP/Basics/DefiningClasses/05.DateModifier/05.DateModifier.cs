using System;

namespace Csharp.OOP.Basics.DefiningClasses._05.DateModifier
{
    public static partial class _05DateModifier
    {
        public static void Solution()
        {
            var d1 = Console.ReadLine().Trim();
            var d2 = Console.ReadLine().Trim();

            Console.WriteLine(DateModifier.DatesDifference(d1, d2));
        }
    }
}
