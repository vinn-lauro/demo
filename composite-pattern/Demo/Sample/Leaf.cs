namespace Demo.Sample;

public abstract class Leaf : Component
{
    public Leaf(string name) : base(name) { }
    public override void Add(Component component) => throw new Exception(name + " is a leaf. Cannot ADD component");
    public override void Remove(Component component) => throw new Exception(name + " is a leaf. Cannot REMOVE component");
    public override void TraceFwd()
    {
        Console.WriteLine(name + " (Leaf)");
    }
}
