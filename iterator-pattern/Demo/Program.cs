namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        IAggregate aggregate = new ConcreteAggregate(
            new object[] { "Item1", "Item2", "Item3", "Item4", "Item5" }
        );

        IIterator iterator = aggregate.CreateIterator();
        iterator.ForEach(a =>
        {
            if (a.CurrentItem().ToString().EndsWith("3"))
                Console.WriteLine(a.CurrentItem());
        });
    }
}
