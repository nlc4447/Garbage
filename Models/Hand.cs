/*
Representation of the current hand, includes a two dimensional array of the cards as the hand
*/

namespace Models
{
    public class Hand
    {
        private Card[,] _hand = new Card[2,5];
        private Deck _deck;

        public Hand(Deck _deck)
        {
            /**
            * creates a hand from the top of the deck
            */
            this._deck = _deck;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    _hand[i,j] = _deck.drawTopCard();
                }
            }
        }

        public Card[,] getHand()
        {
            return _hand;
        }


        public void displayHand()
        {
            /**
            * displays the current hand in a readable format
            * this function looks confusing, may need a bit of a refactor
            */

            string output = "";
            for(int i = 0; i < 2; i++)
            { 
                for(int j = 0; j < 5; j++)
                {
                    
                    if(_hand[i,j].isShowing())
                    {
                        output += "[ " + _hand[i,j].toSymbol();

                        if(_hand[i,j].getRank() != Rank.TEN) //formatting to work around extra character from "10"
                        { 
                            output += " ";
                        }
                    }
                    else
                    { //output if card is still hidden
                        output += "[ ?? ";
                    }
                    
                    
                    if(j == 4)
                    {
                        output += "]";

                    }
                    else
                    {
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