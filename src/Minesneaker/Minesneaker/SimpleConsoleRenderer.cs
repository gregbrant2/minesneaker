using Minesneaker;

public class SimpleConsoleRenderer : IGameRenderer
{
    private readonly IConsoleWriter _writer;

    public SimpleConsoleRenderer(IConsoleWriter writer)
    {
        _writer = writer;
    }

    public void Render(Board board)
    {
        _writer.Write($"Player is at {board.CurrentPosition}");
    }
}