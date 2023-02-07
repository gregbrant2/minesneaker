using System.Text;
using Moq;

namespace Minesneaker.Tests
{
    public class GameControllerTests
    {
        [Fact]
        public void NewGame_Something()
        {
            var input = new Mock<IGameInput>();
            var renderer = new Mock<IGameRenderer>();
            var controller = new GameController(input.Object, renderer.Object);

            controller.NewGame();
        }
    }

    public class GameController
    {
        private readonly IGameInput _input;
        private readonly IGameRenderer _renderer;
        private Board? _board;

        public GameController(IGameInput input, IGameRenderer renderer)
        {
            _input = input;
            _renderer = renderer;
        }

        public void NewGame()
        {
            _board = new Board();
        }
    }

    public interface IGameRenderer
    {
    }

    public interface IGameInput
    {
    }

    public class GameInputTests
    {
        [Fact]
        public void Foo()
        {
            var testInput = new TestInput();
            var input = new GameInput(testInput);
        }
    }

    public class TestInput : TextReader
    {
        private readonly MemoryStream _stream = new();

        public void Write(string data)
        {
            _stream.Write(Encoding.ASCII.GetBytes(data));
        }
    }

    class GameInput : IGameInput
    {
        private readonly TextReader _stream;

        public GameInput(TextReader stream)
        {
            _stream = stream;
        }
    }

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