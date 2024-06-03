namespace Garbage{
    public class Card{
        private Type type;
        private Suit suit;
        private string name;
        private bool showing = false;
        private bool garbage = false;
        private bool wild = false;

        public Card(Type type, Suit suit){
            this.type = type;
            this.suit = suit;

            if(type == Type.KING || type == Type.QUEEN){
                this.garbage = true;
            }

            if(type == Type.JACK){
                this.wild = true;
            }

            name = type.ToString()[0] + type.ToString().Substring(1).ToLower() + " of " + suit.ToString()[0] + suit.ToString().Substring(1).ToLower();

        }
    
        public Suit getSuit(){
            return this.suit;
        }

        public Type getType(){
            return this.type;
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
            // return type + " of " + suit;
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