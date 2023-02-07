namespace Minesneaker.Tests
{
    public class BoardTests
    {
        [Fact]
        public void NewBoard_InitialisesDefaultPosition()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveDown()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            board.Apply(InputCommand.MoveDown);

            Assert.Equal(('A', 2), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveRight()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            board.Apply(InputCommand.MoveRight);

            Assert.Equal(('B', 1), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveUp()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);
            board.Apply(InputCommand.MoveDown);
            Assert.Equal(('A', 2), board.CurrentPosition);

            board.Apply(InputCommand.MoveUp);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveLeft()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            board.Apply(InputCommand.MoveRight);
            Assert.Equal(('B', 1), board.CurrentPosition);

            board.Apply(InputCommand.MoveLeft);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastLeftBound()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            Assert.Equal(('A', 1), board.CurrentPosition);
            board.Apply(InputCommand.MoveLeft);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastRightBound()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            board.Apply(InputCommand.MoveRight);

            Assert.Equal(('B', 1), board.CurrentPosition);
            board.Apply(InputCommand.MoveRight);

            Assert.Equal(('B', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastTopBound()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            Assert.Equal(('A', 1), board.CurrentPosition);
            board.Apply(InputCommand.MoveUp);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastBottomBound()
        {
            var cells = BuildCells(2, 2);
            var board = new Board(cells);

            board.Apply(InputCommand.MoveDown);

            Assert.Equal(('A', 2), board.CurrentPosition);
            board.Apply(InputCommand.MoveDown);

            Assert.Equal(('A', 2), board.CurrentPosition);
        }

        private Dictionary<int, Dictionary<int, CellState>> BuildCells(int width, int height)
        {
            var cells = new Dictionary<int, Dictionary<int, CellState>>();
            for (int x = 0; x < width; x++)
            {
                cells.Add(x, new Dictionary<int, CellState>());

                for (int y = 0; y < height; y++)
                {
                    cells[x].Add(y, CellState.Safe);
                }
            }

            return cells;
        }
    }
}