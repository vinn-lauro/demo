namespace Demo.Sample;

public class Calculator
{
    IReceiver calculator = new Receiver();
    List<ICommand> undoList = new List<ICommand>();
    List<ICommand> redoList = new List<ICommand>();

    public void Do(Operation operation, double n)
    {
        Command command = new Command(operation, n, calculator);
        command.Execute();
        undoList.Add(command);
        redoList = new List<ICommand>();
    }

    public void Undo()
    {
        if (undoList.Count == 0)
        {
            Console.WriteLine("No Operation To Undo");
            return;
        }

        ICommand lastCommand = undoList[undoList.Count - 1];
        Console.WriteLine("UNDO back to ");

        lastCommand.ExecuteOpposite();
        redoList.Add(lastCommand);
        undoList.Remove(lastCommand);
    }

    public void Redo()
    {
        if (redoList.Count == 0)
        {
            Console.WriteLine("NO Operation To Redo");
            return;
        }

        ICommand lastCommand = redoList[redoList.Count - 1];
        Console.WriteLine("REDO back to ");
        lastCommand.Execute();
        undoList.Add(lastCommand);
        redoList.Remove(lastCommand);
    }
}