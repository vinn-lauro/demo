using Demo;
using Demo.Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Invoker invoker = new Invoker();
        invoker.SetCommand(new ConcreteCommand(new Receiver()));
        invoker.InitiateCommand();

        Calculator calculator = new Calculator();
        calculator.Do(Operation.Add, 4);
        calculator.Do(Operation.Divide, 5);

        calculator.Undo();
        calculator.Undo();
        calculator.Undo();

        calculator.Redo();
        calculator.Redo();
        calculator.Redo();
    }
}

interface IReceiver
{
    void Command();
}

class Receiver : IReceiver
{
    public void Command()
    {
        Console.WriteLine($"{this.GetType()} Command() called");
    }
}

interface ICommand
{
    void ExecuteCommand();
}

class ConcreteCommand : ICommand
{
    IReceiver _receiver;

    public ConcreteCommand(IReceiver receiver)
    {
        _receiver = receiver;
    }

    public void ExecuteCommand()
    {
        _receiver.Command();
    }
}

class Invoker
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void InitiateCommand()
    {
        _command.ExecuteCommand();
    }
}