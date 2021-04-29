public class Card {

    private Type type;
    private Suit suit;

    public Card(Type type, Suit suit){
        this.type = type;
        this.suit = suit;
    }

    public Suit getSuit(){
        return this.suit;
    }

    public Type getType(){
        return this.type;
    }
}
