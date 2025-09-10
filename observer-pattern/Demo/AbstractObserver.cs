namespace Demo;

abstract class AbstractObserver
{
    public virtual void Notify(Subject sender)
    {
        Console.WriteLine($"{this.GetType().Name} received notification from {sender.Name}");
    }
}
