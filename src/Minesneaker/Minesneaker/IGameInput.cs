namespace Minesneaker;

public interface IGameInput
{
    InputCommand ReadCommand();
}

public enum InputCommand
{
    NotSet = 0,
    MoveUp,
    MoveDown,
    MoveLeft,
    MoveRight
}