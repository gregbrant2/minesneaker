using Minesneaker.Tests.Helpers;

namespace Minesneaker.Tests;

public class GameInputTests
{
    [Theory]
    [InlineData(ConsoleKey.UpArrow, InputCommand.MoveUp)]
    [InlineData(ConsoleKey.DownArrow, InputCommand.MoveDown)]
    [InlineData(ConsoleKey.LeftArrow, InputCommand.MoveLeft)]
    [InlineData(ConsoleKey.RightArrow, InputCommand.MoveRight)]
    public void ReadCommand_ReturnsCorrectValue(ConsoleKey key, InputCommand expected)
    {
        var testInput = new TestInput(key);
        var input = new GameInput(testInput);
        
        var command = input.ReadCommand();

        Assert.Equal(expected, command);
    }
}