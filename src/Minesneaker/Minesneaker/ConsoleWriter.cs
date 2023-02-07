class ConsoleWriter : IConsoleWriter
{
    public void Write(string data) => Console.WriteLine(data);
}