namespace Sample;

public interface ILog
{
    void Log(string message);
}

class WindowsLog : ILog
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging Framework for Windows Output: {message}");
    }
}

class LinuxLog : ILog
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging Framework for Linux Output: {message}");
    }
}

interface ILogger
{
    ILog Module { get; set; }
    void Log(string message);
}

class Logger : ILogger
{
    public ILog Module { get; set; }

    public void Log(string message)
    {
        Module.Log(message);
    }
}