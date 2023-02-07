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
        _writer.WriteLine("Press an arrow key to move");
    }

    public void Boom()
    {
        _writer.WriteLine(string.Empty);
        _writer.WriteLine("   BOOM!    ");
        _writer.WriteLine(string.Empty);
        _writer.WriteLine(string.Empty);
        _writer.WriteLine("You died ;(");
    }

    public void PromptForNewGame()
    {
        _writer.WriteLine("Press any key to start a new game...");
    }
}