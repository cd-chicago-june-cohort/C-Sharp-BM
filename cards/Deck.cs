using System;
using System.Collections.Generic;

namespace cardGame
{
    public class Deck

    {
        public List<Card> myDeck = new List<Card>();

        string[] suits = { "Clubs", "Spades", "Hearts", "Diamonds" };
        string[] val = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public Deck()
        {
            for (byte s = 0; s < 4; s++)
            {
                for (byte v = 1; v < 14; v++)
                {
                    Card newCard = new Card();
                    newCard.Suit = suits[s];
                    newCard.StringVal = val[v - 1];
                    newCard.Val = v;

                    myDeck.Add(newCard);
                }
            }
        }

        public Card deal()
        {
            Card dealt = myDeck[0];
            myDeck.RemoveAt(0);
            Console.WriteLine("Your card is: " + dealt.StringVal + " of " + dealt.Suit + " and there are: " + myDeck.Count + " cards left.");
            return dealt;
        }

        public void reset()
        {
            myDeck.Clear();
            Deck newDeck = new Deck();
            myDeck = newDeck.myDeck;
            Console.WriteLine($"There are now {myDeck.Count} cards in the deck");
        }

        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < myDeck.Count-1; i++)
            {
                int n = rand.Next(i, myDeck.Count);
                Card temp = myDeck[i];
                myDeck[i] = myDeck[n];
                myDeck[n] = temp;
                Console.WriteLine(myDeck[i].StringVal + " of " + myDeck[i].Suit);
            } 
        }
    }
}
