

namespace Models
{
    public class Player 
    {
        private Hand _hand;
        private string _name;

        public Player(Hand hand, string name)
        {
            _hand = hand;
            _name = name;
        }
        
    }
}