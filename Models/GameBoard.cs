using System.Runtime.CompilerServices;

namespace Models
{
    public class GameBoard
    {
        private Player _player1;
        private Player _player2;
        
        private Deck _deck;
        private Discard _discardPile;
        
        public GameBoard()
        {
            _deck = new Deck();
            _discardPile = new Discard();
            
        }
    }
}