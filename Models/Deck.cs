using System;
using System.Collections;


namespace Models{
    public class Deck{

        private Stack<Card> _deckCards = new Stack<Card>();

        public Deck(){
            //nested for loop sets up one deck of cards
            foreach(Suit suit in  Enum.GetValues(typeof(Suit))){ 
                foreach(Rank rank in Enum.GetValues(typeof(Rank))){
                    _deckCards.Push(new Card(rank, suit));
                }
            }

            shuffle();
        }

        public Stack<Card> getDeck(){
            return _deckCards;
        }

        public Card drawTopCard(){
            /**
            * gets the top card of the deck and removes it
            */
            return _deckCards.Pop();
        }
        
        public Card peekTopCard(){
            /**
            * gets the top card of the deck without removing it
            */
            return _deckCards.Peek();
        }

        public void shuffle(){
            Random rand = new Random();
            Card[] list = _deckCards.ToArray();

            //Fisher-Yates shuffle alg, complexity O(n)
            for (int i = list.Length - 1; i > 0; i--){
                int k = rand.Next(i + 1);
                Card c = list[k];
                list[k] = list[i];
                list[i] = c;
            }

            _deckCards = new Stack<Card>(list);
        }

    }
}