using Moq;

namespace Minesneaker.Tests;

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