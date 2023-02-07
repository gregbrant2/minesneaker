using System.Text;

namespace Minesneaker.Tests;

public class TestInput : TextReader
{
    private readonly MemoryStream _stream = new();

    public void Write(string data)
    {
        _stream.Write(Encoding.ASCII.GetBytes(data));
    }
}