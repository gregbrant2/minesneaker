namespace Minesneaker;

class ConsoleReader : IConsoleReader
{
    public ConsoleKeyInfo ReadKey() => Console.ReadKey();
}