namespace Minesneaker.Tests.Helpers;

public class FakeConsoleWriter : IConsoleWriter
{
    public void Write(string data)
    {
        Data = data;
    }

    public string? Data { get; set; }
}