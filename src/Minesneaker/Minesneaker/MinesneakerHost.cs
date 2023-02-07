using Microsoft.Extensions.Hosting;

namespace Minesneaker;

public class MinesneakerHost : IHostedService
{
    private readonly IGameController _gameController;

    public MinesneakerHost(IGameController gameController)
    {
        _gameController = gameController;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Hello, Minesneaker!");

        _gameController.NewGame();
     
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}