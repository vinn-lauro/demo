namespace Demo;

class ConcreteIterator : IIterator
{
    private ConcreteAggregate _aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        _aggregate = aggregate;
    }

    public object CurrentItem()
    {
        return _aggregate[current];
    }

    public object First()
    {
        return _aggregate[0];
    }

    public bool IsDone()
    {
        return current >= _aggregate.Count - 1;
    }

    public object Next()
    {
        return (current < _aggregate.Count - 1) ? _aggregate[current++] : null;
    }

    public void ForEach(Action<ConcreteIterator> action)
    {
        while (true)
        {
            action(this);
            if (IsDone())
            {
                current = 0;
                return;
            }

            Next();
        }
    }
}