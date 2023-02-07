namespace Minesneaker;

public interface IGameInput
{
    InputCommand ReadCommand();
    void WaitForKey();
}