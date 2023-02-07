namespace Minesneaker;

public class GameController : IGameController
{
    private readonly IBoardFactory _boardFactory;
    private readonly IGameInput _input;
    private readonly IPlayerPrompts _playerPrompts;
    private readonly IGameRenderer _renderer;
    private Board? _board;

    public GameController(
        IBoardFactory boardFactory,
        IGameInput input, 
        IPlayerPrompts playerPrompts,
        IGameRenderer renderer)
    {
        _boardFactory = boardFactory;
        _input = input;
        _playerPrompts = playerPrompts;
        _renderer = renderer;
    }

    public void NewGame()
    {
        while (true)
        {
            _board = _boardFactory.Create();

            var state = PlayerState.Alive;
            while (state == PlayerState.Alive)
            {
                _playerPrompts.PromptForMovement();
                var command = _input.ReadCommand();
                state = _board.Apply(command);

                if (state == PlayerState.Alive)
                {
                    _renderer.Render(_board);
                }
                else
                {
                    _playerPrompts.Boom();
                    _playerPrompts.PromptForNewGame();
                }
            }
        }
    }
}