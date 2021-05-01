/*
Representation of a deck of cards
*/
import java.util.Collections;
import java.util.Stack;

public class Deck {
    
    private Stack<Card> deckCards = new Stack<Card>();

    public Deck(){
        for(Type type: Type.values()){ //nested for loop sets up one deck of cards
            for(Suit suit : Suit.values()){
                deckCards.push(new Card(type, suit));
            }
        }
    }

    public Stack<Card> getDeck(){
        return deckCards;
    }
    
    public Card drawTopCard(){
        /**
         * gets the top card of the deck and removes it
         */
        return deckCards.pop();
    }

    public Card getTopCard(){
        /**
         * gets the top card of the deck without removing it
         */
        return deckCards.get(0);
    }

    public void shuffle(){
        Collections.shuffle(deckCards);
    }
}
