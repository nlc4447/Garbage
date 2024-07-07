 using Microsoft.AspNetCore.SignalR;
 using System.Threading.Tasks;

 public class GameHub : Hub
 {
    private readonly IGameService gameService;

    public GameHub(IGameService gameService)
    {
        this.gameService = gameService;
    }

    public async Task SendMove(string move)
    {
        string result = this.gameService.ProcessMove(move);

        await Clients.All.SendAsync("ReceiveMove", result);
    }
 }