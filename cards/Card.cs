using System;
using System.Collections.Generic;

namespace cardGame
{
    public class Card
    {

        public string StringVal;
        public string Suit;
        public int Val;
    
        public Card(string stringVal = "", string suit = "", int val = 0) {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }   
    }
}
