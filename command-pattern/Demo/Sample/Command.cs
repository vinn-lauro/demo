namespace Demo.Sample;

class Command : ICommand
{
    public double n { get; set; }
    public Operation operation { get; set; }
    IReceiver receiver;

    public Command(Operation operation, double n, IReceiver receiver)
    {
        this.n = n;
        this.operation = operation;
        this.receiver = receiver;
    }

    public void Execute()
    {
        this.receiver.Calculate(this);
    }

    public void ExecuteOpposite()
    {
        Operation opposite;

        switch (this.operation)
        {
            case Operation.Add:
                opposite = Operation.Subtract;
                break;
            case Operation.Subtract:
                opposite = Operation.Add;
                break;
            case Operation.Multiply:
                opposite = Operation.Divide;
                break;
            case Operation.Divide:
                opposite = Operation.Multiply;
                break;
            default:
                opposite = Operation.Add;
                break;
        }

        this.receiver.Calculate(new Command(opposite, this.n, this.receiver));
    }
}
