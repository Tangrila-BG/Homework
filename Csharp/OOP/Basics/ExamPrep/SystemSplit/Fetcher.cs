using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit
{
    public static class Fetcher
    {
        public static TCollection Fetch<TCollection>(this ICollection<TCollection> collection, Func<TCollection, bool> predicate)
        {
            var target = collection.FirstOrDefault(predicate);

            if (target == null)
                throw new ArgumentException("Component not found!");

            return target;
        }

        public static TCollection Fetch<TCollection>(this IReadOnlyCollection<TCollection> collection, Func<TCollection, bool> predicate)
        {
            var target = collection.FirstOrDefault(predicate);

            if (target == null)
                throw new ArgumentException("Component not found!");

            return target;
        }
    }
}
