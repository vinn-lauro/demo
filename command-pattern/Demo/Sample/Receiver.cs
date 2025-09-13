namespace Demo.Sample;

class Receiver : IReceiver
{
    private double sum;
    public void Calculate(ICommand command)
    {
        switch (command.operation)
        {
            case Operation.Add:
                sum += command.n;
                break;
            case Operation.Subtract:
                sum -= command.n;
                break;
            case Operation.Multiply:
                sum *= command.n;
                break;
            case Operation.Divide:
                sum /= command.n;
                break;
            default:
                sum = 0;
                break;
        }
        Console.WriteLine(sum);
    }
}
