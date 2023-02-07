namespace Minesneaker;

public class Board
{
    private const int OffsetToA = 64;

    private int _xPos = 1;
    private int _yPos = 1;

    public Board()
    {

    }

    public (char, int) CurrentPosition => ((char)(OffsetToA + _xPos), _yPos);

    public PlayerState Apply(InputCommand command)
    {
        throw new NotImplementedException();
    }
}