namespace Minesneaker;

public class GameInput : IGameInput
{
    readonly Dictionary<ConsoleKey, InputCommand> _commands = new()
    {
        {ConsoleKey.UpArrow, InputCommand.MoveUp},
        {ConsoleKey.DownArrow, InputCommand.MoveDown},
        {ConsoleKey.LeftArrow, InputCommand.MoveLeft},
        {ConsoleKey.RightArrow, InputCommand.MoveRight},
    };
    private readonly IConsoleReader _consoleReader;

    public GameInput(IConsoleReader consoleReader)
    {
        _consoleReader = consoleReader;
    }

    public InputCommand ReadCommand()
    {
        var key = _consoleReader.ReadKey();
        while (!_commands.ContainsKey(key.Key))
        {
            key = _consoleReader.ReadKey();
        }

        return _commands[key.Key];
    }
}

public interface IConsoleReader
{
    ConsoleKeyInfo ReadKey();
}

class ConsoleReader : IConsoleReader
{
    public ConsoleKeyInfo ReadKey() => Console.ReadKey();
}