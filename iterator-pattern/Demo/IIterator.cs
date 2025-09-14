namespace Demo;

interface IIterator
{
    object First();
    object Next();
    bool IsDone();
    object CurrentItem();
    void ForEach(Action<ConcreteIterator> action);
}
