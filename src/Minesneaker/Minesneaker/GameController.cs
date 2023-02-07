namespace Minesneaker;

public class GameController
{
    private readonly IGameInput _input;
    private readonly IGameRenderer _renderer;
    private Board? _board;

    public GameController(IGameInput input, IGameRenderer renderer)
    {
        _input = input;
        _renderer = renderer;
    }

    public void NewGame()
    {
        _board = new Board();
    }
}