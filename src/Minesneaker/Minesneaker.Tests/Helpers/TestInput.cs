using System.Text;

namespace Minesneaker.Tests.Helpers;

public class TestInput : IConsoleReader
{
    private readonly ConsoleKey _key;

    public TestInput(ConsoleKey key)
    {
        _key = key;
    }

    public ConsoleKeyInfo ReadKey()
    {
        return new ConsoleKeyInfo((char)_key, _key, false, false, false);
    }
}