using System;

namespace Csharp.OOP.Advanced.EnumerationsAndAttributes._01CardSuit
{
    class _01CardSuit
    {
        public static void Solution()
        {
            Console.WriteLine("Card Suits:");

            foreach (CardSuit value in Enum.GetValues(typeof(CardSuit)))
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");

        }
    }

    enum CardSuit
    {
        Clubs = 0,
        Diamonds = 1,
        Hearts = 2,
        Spades = 3
    }
}
