using Minesneaker.Tests.Helpers;

namespace Minesneaker.Tests;

public class PlayerPromptTests
{
    [Fact]
    public void PromptForInput()
    {
        var writer = new FakeConsoleWriter();
        var prompts = new PlayerPrompts(writer);

        prompts.PromptForMovement();

        Assert.Equal("Press an arrow key to move" + Environment.NewLine, writer.Data);
    }

    [Fact]
    public void PromptForNewGame()
    {
        var writer = new FakeConsoleWriter();
        var prompts = new PlayerPrompts(writer);

        prompts.PromptForNewGame();

        Assert.Equal("Press any key to start a new game..." + Environment.NewLine, writer.Data);
    }

    [Fact]
    public void Boom()
    {
        var writer = new FakeConsoleWriter();
        var prompts = new PlayerPrompts(writer);

        prompts.Boom();

        Assert.Equal(@"
   BOOM!    


You died ;(" + Environment.NewLine, writer.Data);
    }
}