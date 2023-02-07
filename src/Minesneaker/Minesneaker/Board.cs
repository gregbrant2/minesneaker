namespace Minesneaker;

public class Board
{
    private const int Width = 8;
    private const int Height = 8;
    private const int OffsetToA = 64;

    private int _xPos = 1;
    private int _yPos = 1;

    public Board()
    {

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
                if (_yPos < Height - 1) _yPos++;
                break;
            case InputCommand.MoveLeft:
                if (_xPos > 1) _xPos--;
                break;
            case InputCommand.MoveRight:
                if (_xPos < Width - 1) _xPos++;
                break;
        }

        return PlayerState.Alive;
    }
}