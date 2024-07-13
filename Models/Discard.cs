
namespace Models 
{
    public class Discard 
    {
        private Stack<Card> _discardPile;

        public Discard()
        {
            _discardPile = new Stack<Card>();
        }
    }
}