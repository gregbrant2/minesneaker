namespace Minesneaker.Tests;

class GameInput : IGameInput
{
    private readonly TextReader _stream;

    public GameInput(TextReader stream)
    {
        _stream = stream;
    }
}