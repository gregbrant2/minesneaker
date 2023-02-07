namespace Minesneaker;

class ConsoleWriter : IConsoleWriter
{
    public void WriteLine(string data) => Console.WriteLine(data);
}