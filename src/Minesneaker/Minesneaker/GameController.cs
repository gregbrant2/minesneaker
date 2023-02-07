namespace Minesneaker;

public class GameController : IGameController
{
    private readonly IGameInput _input;
    private readonly IGameRenderer _renderer;
    private Board? _board;

    public GameController(IGameInput input, IGameRenderer renderer)
    {
        _input = input;
        _renderer = renderer;
    }

    public async Task NewGameAsync()
    {
        _board = new Board();

        var state = PlayerState.Alive;
        while (state == PlayerState.Alive)
        {
            var command = _input.ReadCommand();
            state = _board.Apply(command);
            _renderer.Render(_board);
        }
    }
}