namespace Demo;

class ConcreteStateB : IState
{
    public void Switch(Subject subject)
    {
        subject.State = new ConcreteStateA();
        Console.WriteLine(subject.State.GetType().ToString());
    }
}

