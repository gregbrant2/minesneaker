using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Minesneaker;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<MinesneakerHost>();
        services.AddTransient<IGameController, GameController>();

        services.AddTransient<IGameInput, GameInput>();
        services.AddTransient<IConsoleReader, ConsoleReader>();

        services.AddTransient<IGameRenderer, SimpleConsoleRenderer>();
        services.AddTransient<IConsoleWriter, ConsoleWriter>();
    })
    .Build();

await host.RunAsync();