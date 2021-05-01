/*
Representation of the current hand, includes a two dimensional array of the cards as the hand
*/


public class Hand{
    
    private Card[][] hand;
    private Deck deck;

    public Hand(Deck deck){
        this.deck = deck;
        for(int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
                hand[i][j] = deck.getTopCard();
            }
        }
    }

    public Deck getUpdatedDeck(){
        return deck;
    }

    public Card[][] getHand(){
        return hand;
    }

    
}
