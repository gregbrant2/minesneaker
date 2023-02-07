namespace Minesneaker;

public interface IGameInput
{
    Task<InputCommand> ReadCommandAsync();
}

public class InputCommand
{
}