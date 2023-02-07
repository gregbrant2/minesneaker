namespace Minesneaker;

public class BoardFactory : IBoardFactory
{
    private const int Width = 8;
    private const int Height = 8;

    public Board Create()
    {
        var rand = new Random(DateTime.Now.Millisecond);

        var cells = new Dictionary<int, Dictionary<int, CellState>>();
        for (int x = 0; x < Width; x++)
        {
            cells.Add(x, new Dictionary<int, CellState>());

            for (int y = 0; y < Height; y++)
            {
                var state = (CellState) (rand.Next() % 2);

                cells[x].Add(y, state);
            }
        }

        return new Board(cells);
    }
}