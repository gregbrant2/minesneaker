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
    }

    public class Board
    {
        private const int OffsetToA = 64;

        private int _xPos = 1;
        private int _yPos = 1;

        public Board()
        {

        }

        public (char, int) CurrentPosition => ((char)(OffsetToA + _xPos), _yPos);
    }
}