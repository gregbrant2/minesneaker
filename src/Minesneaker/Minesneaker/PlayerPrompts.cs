namespace Minesneaker;

public class PlayerPrompts : IPlayerPrompts
{
    private readonly IConsoleWriter _writer;

    public PlayerPrompts(IConsoleWriter writer)
    {
        _writer = writer;
    }

    public void PromptForMovement()
    {
        _writer.Write("Press an arrow key to move");
    }
}