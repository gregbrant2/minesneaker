namespace Minesneaker;

public class Board
{
    private const int OffsetToA = 64;

    private readonly Dictionary<int, Dictionary<int, CellState>> _cells;

    private int _xPos = 1;
    private int _yPos = 1;

    public Board(Dictionary<int, Dictionary<int, CellState>> cells)
    {
        _cells = cells;
    }

    public (char, int) CurrentPosition => ((char)(OffsetToA + _xPos), _yPos);

    public PlayerState Apply(InputCommand command)
    {
        switch (command)
        {
            case InputCommand.MoveUp:
                if (_yPos > 1) _yPos--;
                break;
            case InputCommand.MoveDown:
                if (_yPos < _cells[0].Count) _yPos++;
                break;
            case InputCommand.MoveLeft:
                if (_xPos > 1) _xPos--;
                break;
            case InputCommand.MoveRight:
                if (_xPos < _cells.Count) _xPos++;
                break;
        }

        return _cells[_xPos - 1][_yPos - 1] == CellState.Mine
            ? PlayerState.Dead
            : PlayerState.Alive;
    }
}