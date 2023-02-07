using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Minesneaker;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<MinesneakerHost>();
        services.AddTransient<IGameController, GameController>();

        services.AddTransient<IGameInput, GameInput>();
        services.AddTransient(_ => Console.In);

        services.AddTransient<IGameRenderer, SimpleConsoleRenderer>();
    })
    .Build();

await host.RunAsync();