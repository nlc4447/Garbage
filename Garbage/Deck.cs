using System;
using System.Collections;

namespace Garbage{
    public class Deck{

        private Stack<Card> deckCards = new Stack<Card>();

        public Deck(){
        // for(Type type: Type.values()){ //nested for loop sets up one deck of cards
        //     for(Suit suit : Suit.values()){
        //         deckCards.push(new Card(type, suit));
        //     }
        // }



        foreach(Rank rank in  Enum.GetValues(typeof(Rank))){ //nested for loop sets up one deck of cards
            // for(Suit suit : Suit.values()){
            //     deckCards.push(new Card(type, suit));
            // }
        }
    }

    }
}