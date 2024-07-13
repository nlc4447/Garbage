namespace Models
{
    public class Card
    {
        private Rank _rank;
        private Suit _suit;
        private string _name;
        private string _symbol;
        private bool _showing = false;
        private bool _garbage = false;
        private bool _wild = false;

        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;

            if(rank == Rank.KING || rank == Rank.QUEEN)
            {
                _garbage = true;
            }

            if(rank == Rank.JACK)
            {
                _wild = true;
            }

            _name = rank.ToString()[0] + rank.ToString().Substring(1).ToLower() + " of " + suit.ToString()[0] + suit.ToString().Substring(1).ToLower();  // readable string format

            _symbol = "";

            switch(suit)
            {
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

            switch(rank)
            {
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
                    _symbol += (int)rank;
                    break;
            }
        }
    
        public Suit getSuit()
        {
            return _suit;
        }

        public Rank getRank()
        {
            return _rank;
        }

        public bool isShowing()
        {
            return _showing;
        }

        public void showCard()
        {
            _showing = true;
        }

        public string toString()
        {
            return _name;
        }

        public string toSymbol()
        {
            return _symbol;
        }

        public bool isWild()
        {
            return _wild;
        }

        public bool isGarbage()
        {
            return _garbage;
        }
    }
}