namespace Demo.EventSample;

public class Subject
{
    public string Name;
    public event EventHandler Handler;
    public Subject(string name)
    {
        Name = name;
    }

    public void Notify()
    {
        if (Handler != null)
            Handler(this, EventArgs.Empty);
    }
}

abstract class AbstractObserver
{
    public virtual void Notify(object sender, EventArgs e)
    {
        Subject s = sender as Subject;
        Console.WriteLine($"{this.GetType().Name} received notification from {s.Name}");
    }
}

class ObserverA : AbstractObserver { }
class ObserverB : AbstractObserver { }