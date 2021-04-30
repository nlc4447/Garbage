public class Card {

    private Type type;
    private Suit suit;
    private boolean showing = false;

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

    public boolean isShowing(){
        return showing;
    }

    public void showCard(){
        this.showing = true;
    }
}
