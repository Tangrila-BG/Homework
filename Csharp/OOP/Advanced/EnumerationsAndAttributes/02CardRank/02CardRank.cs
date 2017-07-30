using System;

namespace Csharp.OOP.Advanced.EnumerationsAndAttributes._02CardRank
{
    class _02CardRank
    {
        public static void Solution()
        {
            Console.WriteLine("Card Ranks:");

            foreach (CardRank value in Enum.GetValues(typeof(CardRank)))
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }

    enum CardRank
    {
        Ace = 0,
        Two = 1,
        Three = 2,
        Four = 3,
        Five = 4,
        Six = 5,
        Seven = 6,
        Eight = 7,
        Nine = 8,
        Ten = 9,
        Jack = 10,
        Queen = 11,
        King = 12
    }

}
