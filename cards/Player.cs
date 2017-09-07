using System;
using System.Collections.Generic;

namespace cardGame
{
    public class Player
    {
        public String name;
        public List<Card> hand = new List<Card>();

        public Player(string yourName = "")
        {
            name = yourName;
        }

        public Card draw(Deck deck)
        {
            Card card = deck.deal();
            hand.Add(card);
            return card;
        }

        public Card discard(int i)
        {
            if (hand.Count < 0)
            {
                return null;
            }
            Card discarded = hand[i];
            hand.RemoveAt(i);
            Console.WriteLine(discarded.StringVal + " of " + discarded.Suit + " discarded.");
            return discarded;
        }

    }
}
