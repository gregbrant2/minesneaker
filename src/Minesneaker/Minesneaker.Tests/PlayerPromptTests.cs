using Minesneaker.Tests.Helpers;

namespace Minesneaker.Tests;

public class PlayerPromptTests
{
    [Fact]
    public void PromptForInput()
    {
        var writer = new FakeConsoleWriter();
        var prompts = new PlayerPrompts(writer);

        Assert.Null(writer.Data);
        prompts.PromptForMovement();

        Assert.Equal("Press an arrow key to move", writer.Data);
    }
}