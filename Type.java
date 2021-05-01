/*
Enum representing the different types of cards in the deck of cards
*/
public enum Type {
    ACE("Ace"), TWO("Two"), THREE("Three"), FOUR("Four"), FIVE("Five"), SIX("Six"), SEVEN("Seven"), EIGHT("Eight"), NINE("Nine"), TEN("Ten"), JACK("Jack"), QUEEN("Queen"), KING("King");

    private String type;

    Type(String type){
        this.type = type;
    }

    String getType(){
        return type;
    }
}
