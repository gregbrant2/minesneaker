namespace Minesneaker.Tests
{
    public class BoardTests
    {
        [Fact]
        public void NewBoard_InitialisesDefaultPosition()
        {
            var board = new Board();

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveDown()
        {
            var board = new Board();

            board.Apply(InputCommand.MoveDown);

            Assert.Equal(('A', 2), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveRight()
        {
            var board = new Board();

            board.Apply(InputCommand.MoveRight);

            Assert.Equal(('B', 1), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveUp()
        {
            var board = new Board();
            board.Apply(InputCommand.MoveDown);
            Assert.Equal(('A', 2), board.CurrentPosition);

            board.Apply(InputCommand.MoveUp);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void Apply_MoveLeft()
        {
            var board = new Board();

            board.Apply(InputCommand.MoveRight);
            Assert.Equal(('B', 1), board.CurrentPosition);

            board.Apply(InputCommand.MoveLeft);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastLeftBound()
        {
            var board = new Board();

            Assert.Equal(('A', 1), board.CurrentPosition);
            board.Apply(InputCommand.MoveLeft);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastRightBound()
        {
            var board = new Board();

            board.Apply(InputCommand.MoveRight);
            board.Apply(InputCommand.MoveRight);
            board.Apply(InputCommand.MoveRight);
            board.Apply(InputCommand.MoveRight);
            board.Apply(InputCommand.MoveRight);
            board.Apply(InputCommand.MoveRight);
            board.Apply(InputCommand.MoveRight);

            Assert.Equal(('H', 1), board.CurrentPosition);
            board.Apply(InputCommand.MoveRight);

            Assert.Equal(('H', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastTopBound()
        {
            var board = new Board();

            Assert.Equal(('A', 1), board.CurrentPosition);
            board.Apply(InputCommand.MoveUp);

            Assert.Equal(('A', 1), board.CurrentPosition);
        }

        [Fact]
        public void MovePastBottomBound()
        {
            var board = new Board();

            board.Apply(InputCommand.MoveDown);
            board.Apply(InputCommand.MoveDown);
            board.Apply(InputCommand.MoveDown);
            board.Apply(InputCommand.MoveDown);
            board.Apply(InputCommand.MoveDown);
            board.Apply(InputCommand.MoveDown);
            board.Apply(InputCommand.MoveDown);

            Assert.Equal(('A', 8), board.CurrentPosition);
            board.Apply(InputCommand.MoveDown);

            Assert.Equal(('A', 8), board.CurrentPosition);
        }
    }
}