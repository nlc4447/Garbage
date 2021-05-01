/*
Representation of the current hand, includes a two dimensional array of the cards as the hand
*/


public class Hand{
    
    private Card[][] hand = new Card[2][5];
    private Deck deck;

    public Hand(Deck deck){
        /**
         * creates a hand from the top of the deck
         */
        this.deck = deck;
        for(int i = 0; i < 2; i++){
            for(int j = 0; j < 5; j++){
                hand[i][j] = deck.drawTopCard();
            }
        }
    }

    public Card[][] getHand(){
        return hand;
    }

    public void displayHand(){
        /**
         * displays the current hand in a readable format
         */
        for(int i = 0; i < 2; i++){
            for(int j = 0; j < 5; j++){
                if(j == 4){
                    System.out.print(hand[i][j].getCardName());
                }
                else{
                    System.out.print(hand[i][j].getCardName() + ", ");
                }
                
            }
            System.out.println();
        }
    }
}
