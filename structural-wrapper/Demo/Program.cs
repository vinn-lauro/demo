namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        ILog loggerA = new LogWrapperA();
        loggerA.Log("Success");

        ILog loggerB = new LogWrapperB();
        loggerB.Log("Fail");
    }
}

class LogFrameworkTypeA
{
    public void Log(string message) => Console.WriteLine($"Logging Framework #1 Outputs: {message}");
}

class LogFrameworkTypeB
{
    public void Log(bool error) => Console.WriteLine($"Loggin Framework #2 Error: {error}");
}

interface ILog
{
    void Log(object message);
}

class LogWrapperA : ILog
{
    private LogFrameworkTypeA _externalModule;

    public LogWrapperA() => _externalModule = new LogFrameworkTypeA();
    public void Log(object message)
    {
        string msg = message as string;
        _externalModule.Log(msg);
    }
}

class LogWrapperB : ILog
{
    private LogFrameworkTypeB _externalModule;

    public LogWrapperB() => _externalModule = new LogFrameworkTypeB();

    public void Log(object message)
    {
        bool error = ((string)message == "Fail") ? true : false;
        _externalModule.Log(error);
    }
}