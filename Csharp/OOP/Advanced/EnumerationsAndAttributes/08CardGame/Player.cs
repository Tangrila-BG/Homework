using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Advanced.EnumerationsAndAttributes._08CardGame
{
    class Player
    {
        private readonly string _name;
        private readonly List<Card> _hand;

        public List<Card> Hand => _hand;
        public string Name => _name;

        public Card GetBestCard()
        {
            return _hand.Single(c => c.GetPower().Equals(_hand.Max(ca => ca.GetPower())));
        }

        public void AddCard(Card card)
        {
            this._hand.Add(card);
        }
        public Player(string name)
        {
            _name = name;
            _hand = new List<Card>();
        }
    }

}
