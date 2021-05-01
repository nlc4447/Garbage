/*
Enum representing the different suits in the deck of cards
*/
public enum Suit {
    CLUBS("Clubs"), SPADES("Spades"), HEARTS("Hearts"), DIAMONDS("Diamonds");

    private String suit;

    Suit(String suit){
        this.suit = suit;
    }

    String getSuit(){
        return suit;
    }
}
