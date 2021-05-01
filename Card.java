/*
Representation of a single card
*/
public class Card {

    private Type type;
    private Suit suit;
    private boolean showing = false;
    private boolean garbage = false;;
    private boolean wild = false;

    public Card(Type type, Suit suit){
        this.type = type;
        this.suit = suit;

        if(type == Type.KING || type == Type.QUEEN){
            this.garbage = true;
        }

        if(type == Type.JACK){
            this.wild = true;
        }
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

    public String getCardName(){
        /**
         * returns the card's name in a readable format ex. "Ace of Spades"
         */
        return type.getType() + " of " + suit.getSuit();
    }

    public boolean isWild(){
        return this.wild;
    }

    public boolean isGarbage(){
        return this.garbage;
    }
}
