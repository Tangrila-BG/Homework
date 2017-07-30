using System;

namespace Csharp.OOP.Advanced.EnumerationsAndAttributes._0304CardPower
{
    class _0304CardPower
    {
        public static void Solution()
        {
            var rank = Console.ReadLine().Trim();
            var suit = Console.ReadLine().Trim();
            Console.WriteLine(new Card(rank, suit));
        }
    }

}
