namespace Demo.Sample;

interface ICommand
{
    double n { get; set; }
    Operation operation { get; set; }

    void Execute();
    void ExecuteOpposite();
}
