using System;

namespace Csharp.OOP.Advanced.EnumerationsAndAttributes._05CardCompareTo
{
    class _05CardCompareTo
    {
        public static void Solution()
        {
            var rank = Console.ReadLine().Trim();
            var suit = Console.ReadLine().Trim();

            var card1 = new Card(rank, suit);

            rank = Console.ReadLine().Trim();
            suit = Console.ReadLine().Trim();

            var card2 = new Card(rank, suit);

            Console.WriteLine(card1.CompareTo(card2) > 0 ? card1 : card2);
        }
    }    
}
