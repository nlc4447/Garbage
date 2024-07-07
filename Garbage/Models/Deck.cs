using System;
using System.Collections;


namespace Garbage{
    public class Deck{

        private Stack<Card> deckCards = new Stack<Card>();

        public Deck(){
            //nested for loop sets up one deck of cards
            foreach(Suit suit in  Enum.GetValues(typeof(Suit))){ 
                foreach(Rank rank in Enum.GetValues(typeof(Rank))){
                    deckCards.Push(new Card(rank, suit));
                }
            }

            this.shuffle();
        }

        public Stack<Card> getDeck(){
            return deckCards;
        }

        public Card drawTopCard(){
            /**
            * gets the top card of the deck and removes it
            */
            return deckCards.Pop();
        }
        
        public Card peekTopCard(){
            /**
            * gets the top card of the deck without removing it
            */
            return deckCards.Peek();
        }

        public void shuffle(){
            Random rand = new Random();
            Card[] list = deckCards.ToArray();

            //Fisher-Yates shuffle alg, complexity O(n)
            for (int i = list.Length - 1; i > 0; i--){
                int k = rand.Next(i + 1);
                Card c = list[k];
                list[k] = list[i];
                list[i] = c;
            }

            deckCards = new Stack<Card>(list);
        }

    }
}