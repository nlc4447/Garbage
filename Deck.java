/*
Representation of a deck of cards
*/
import java.util.ArrayList;
import java.util.Collections;

public class Deck {
    
    private ArrayList<Card> deckCards = new ArrayList<Card>();

    public Deck(){
        for(Type type: Type.values()){ //nested for loop sets up one deck of cards
            for(Suit suit : Suit.values()){
                deckCards.add(new Card(type, suit));
            }
        }
    }

    public ArrayList<Card> getDeck(){
        return deckCards;
    }
    
    public Card drawTopCard(){
        /**
         * gets the top card of the deck and removes it
         */
        Card card = deckCards.get(0);
        deckCards.remove(0);
        return card;
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
