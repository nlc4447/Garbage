namespace Models{
    public class Card{
        private Rank _rank;
        private Suit _suit;
        private string name;
        private string _symbol;
        private bool _showing = false;
        private bool _garbage = false;
        private bool _wild = false;

        public Card(Rank rank, Suit suit){
            _rank = rank;
            _suit = suit;

            if(_rank == Rank.KING || _rank == Rank.QUEEN){
                _garbage = true;
            }

            if(_rank == Rank.JACK){
                _wild = true;
            }

            name = _rank.ToString()[0] + _rank.ToString().Substring(1).ToLower() + " of " + _suit.ToString()[0] + _suit.ToString().Substring(1).ToLower();

            _symbol = "";

            switch(_suit){
                case Suit.SPADES:
                    _symbol += "♠";
                    break;
                case Suit.CLUBS:
                    _symbol += "♣";
                    break;
                case Suit.HEARTS:
                    _symbol += "♥";
                    break;
                case Suit.DIAMONDS:
                    _symbol += "♦";
                    break;
            }

            switch(_rank){
                case Rank.KING:
                    _symbol += "K";
                    break;
                case Rank.QUEEN:
                    _symbol += "Q";
                    break;
                case Rank.JACK:
                    _symbol += "J";
                    break;
                case Rank.ACE:
                    _symbol += "A";
                    break;
                default:
                    _symbol += (int)_rank;
                    break;
            }
        }
    
        public Suit getSuit(){
            return _suit;
        }

        public Rank getRank(){
            return _rank;
        }

        public bool isShowing(){
            return _showing;
        }

        public void showCard(){
            _showing = true;
        }

        public String toString(){
            /**
            * returns the card's name in a readable format ex. "Ace of Spades"
            */
            // return _rank + " of " + _suit;
            return this.name;
        }

        public String toSymbol(){
            return _symbol;
        }

        public bool isWild(){
            return _wild;
        }

        public bool isGarbage(){
            return _garbage;
        }
    }
}