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
    
    public Card getTopCard(){
        Card card = deckCards.get(0);
        deckCards.remove(0);
        return card;
    }

    public void shuffle(){
        Collections.shuffle(deckCards);
    }
}
