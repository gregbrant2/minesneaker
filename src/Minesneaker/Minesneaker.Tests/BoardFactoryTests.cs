namespace Minesneaker.Tests;

public class BoardFactoryTests
{
    [Fact]
    public void Create()
    {
        var factory = new BoardFactory();
        var board = factory.Create();
        Assert.NotNull(board);
    }
}