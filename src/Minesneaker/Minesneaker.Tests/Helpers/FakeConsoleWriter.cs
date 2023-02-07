namespace Minesneaker.Tests.Helpers;

public class FakeConsoleWriter : IConsoleWriter
{
    public void WriteLine(string data)
    {
        Data += data + Environment.NewLine;
    }

    public string Data { get; set; } = string.Empty;
}