
/*
Main class which runs the whole program
*/
public class Application{


    public static void main(String[] args){
        Deck deck = new Deck();
        deck.shuffle();
        System.out.println(deck.getTopCard().getCardName());
    }
}