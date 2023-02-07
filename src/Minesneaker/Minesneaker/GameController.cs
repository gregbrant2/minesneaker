namespace Minesneaker;

public class GameController : IGameController
{
    private readonly IGameInput _input;
    private readonly IPlayerPrompts _playerPrompts;
    private readonly IGameRenderer _renderer;
    private Board? _board;

    public GameController(
        IGameInput input, 
        IPlayerPrompts playerPrompts,
        IGameRenderer renderer)
    {
        _input = input;
        _playerPrompts = playerPrompts;
        _renderer = renderer;
    }

    public async Task NewGameAsync()
    {
        _board = new Board();
        
        var state = PlayerState.Alive;
        while (state == PlayerState.Alive)
        {
            _playerPrompts.PromptForMovement();
            var command = _input.ReadCommand();
            state = _board.Apply(command);
            _renderer.Render(_board);
        }
    }
}