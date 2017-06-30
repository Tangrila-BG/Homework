using System;

namespace Csharp.OOP.Basics.DefiningClasses._05.DateModifier
{
    public static partial class _05DateModifier
    {
        private static class DateModifier
        {
            public static int DatesDifference(string date1, string date2)
            {
                var d1 = DateTime.Parse(date1);
                var d2 = DateTime.Parse(date2);

                return Math.Abs((d1 - d2).Days);
            }
        }
    }
}
