import java.util.ArrayList;

public class Deck {
    
    private ArrayList<Card> deckCards = new ArrayList<Card>();

    public Deck(){
        for(Type type: Type.values()){
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
}
