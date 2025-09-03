namespace Demo;

class ConcreteStateA : IState
{
    public void Switch(Subject subject)
    {
        subject.State = new ConcreteStateB();
        Console.WriteLine(subject.State.GetType().ToString());
    }
}

