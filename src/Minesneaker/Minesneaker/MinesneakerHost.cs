using Microsoft.Extensions.Hosting;
using Minesneaker;

public class MinesneakerHost : IHostedService
{
    private readonly IGameController _gameController;

    public MinesneakerHost(IGameController gameController)
    {
        _gameController = gameController;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Hello, Minesneaker!");

        await _gameController.NewGameAsync();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}