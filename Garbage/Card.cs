namespace Garbage{
    public class Card{
        private Rank rank;
        private Suit suit;
        private string name;
        private bool showing = false;
        private bool garbage = false;
        private bool wild = false;

        public Card(Rank rank, Suit suit){
            this.rank = rank;
            this.suit = suit;

            if(rank == Rank.KING || rank == Rank.QUEEN){
                this.garbage = true;
            }

            if(rank == Rank.JACK){
                this.wild = true;
            }

            name = rank.ToString()[0] + rank.ToString().Substring(1).ToLower() + " of " + suit.ToString()[0] + suit.ToString().Substring(1).ToLower();

        }
    
        public Suit getSuit(){
            return this.suit;
        }

        public Rank getRank(){
            return this.rank;
        }

        public bool isShowing(){
            return showing;
        }

        public void showCard(){
            this.showing = true;
        }

        public String toString(){
            /**
            * returns the card's name in a readable format ex. "Ace of Spades"
            */
            // return rank + " of " + suit;
            return name;
        }

        public bool isWild(){
            return this.wild;
        }

        public bool isGarbage(){
            return this.garbage;
        }
    }
}