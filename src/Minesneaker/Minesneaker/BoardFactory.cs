namespace Minesneaker;

public class BoardFactory : IBoardFactory
{
    public Board Create()
    {
        return new Board();
    }
}