 using Microsoft.AspNetCore.SignalR;
 using System.Threading.Tasks;
using Services;

namespace Hubs 
{
    public class GameHub : Hub
    {
        private readonly GameService? _gameService;

        public GameHub(IGameService gameService)
        {
            _gameService = gameService as GameService;
        }

        public async Task SendMove(string move)
        {
            /*
            * Processes a move in this instance of GameService; Sends the move to the server asynchronously
            */
            string result = "";

            if (_gameService != null) result = _gameService.ProcessMove(move);

            await Clients.All.SendAsync("ReceiveMove", result);
        }
    }
}
 