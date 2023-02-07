namespace Minesneaker;

public class GameInput : IGameInput
{
    private readonly TextReader _stream;

    public GameInput(TextReader stream)
    {
        _stream = stream;
    }

    public Task<InputCommand> ReadCommandAsync()
    {
        throw new NotImplementedException();
    }
}