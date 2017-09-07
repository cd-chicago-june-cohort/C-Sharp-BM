using System;
using System.Collections.Generic;

namespace cardGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            Deck myDeck = new Deck();
            foreach (var card in myDeck.myDeck) {
            Console.WriteLine(card.StringVal + " of " + card.Suit);
            }

            myDeck.shuffle();
            
            
            Player myPlayer = new Player("Jerry");
            
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);

            foreach (Card card in myPlayer.hand) {
                Console.WriteLine(myPlayer + "'s Hand: " + card.StringVal + " of " + card.Suit);
            }

            myPlayer.discard(1);

            myDeck.reset();
        }
    }
}
