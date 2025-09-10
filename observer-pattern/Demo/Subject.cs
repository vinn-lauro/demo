namespace Demo;

class Subject
{
    private List<AbstractObserver> observers;
    public string Name;

    public Subject(string name)
    {
        Name = name;
        observers = new List<AbstractObserver>();
    }

    public void Notify()
    {
        if (observers != null)
            foreach (var observer in observers)
                observer.Notify(this);
    }

    public void AddObserver(AbstractObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(AbstractObserver observer)
    {
        observers.Remove(observer);
    }
}
