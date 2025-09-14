namespace Demo;

class ConcreteAggregate : IAggregate
{
    private object[] _items;

    public ConcreteAggregate(object[] items)
    {
        _items = items;
    }

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public object this[int index]
    {
        get { return _items[index]; }
        set { _items[index] = value; }
    }

    public int Count
    {
        get { return _items.Length; }
    }
}
