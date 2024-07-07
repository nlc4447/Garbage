/*
Representation of the current hand, includes a two dimensional array of the cards as the hand
*/

namespace Garbage{
    public class Hand{
        private Card[,] hand = new Card[2,5];
        private Deck deck;

        public Hand(Deck deck){
            /**
            * creates a hand from the top of the deck
            */
            this.deck = deck;
            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 5; j++){
                    hand[i,j] = deck.drawTopCard();
                }
            }
        }

        public Card[,] getHand(){
            return hand;
        }


        public void displayHand(){
            /**
            * displays the current hand in a readable format
            */

            String output = "";
            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 5; j++){
                    
                    if(hand[i,j].isShowing()){
                        output += "[ " + hand[i,j].toSymbol();

                        if(hand[i,j].getRank() != Rank.TEN){ //formatting to work around extra character from "10"
                            output += " ";
                        }
                    }
                    else{ //output if card is still hidden
                        output += "[ ?? ";
                    }
                    
                    
                    if(j == 4){
                        output += "]";

                    }
                    else{
                        output += "],   ";
                    }
                    
                }
                Console.WriteLine(output);
                output = "";
            }
        }


        //TODO create replace card function

    }
}