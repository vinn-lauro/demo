namespace Demo;

class Leaf : BaseComponent
{
    public Leaf(string name) : base(name) { }
    public override void Add(BaseComponent component) => throw new Exception("Attaching component in leaf NOT ALLOWED.");
    public override void Remove(BaseComponent component) => throw new Exception("Removing component in leaf NOT ALLOWED.");
    public override void WireUp(int length, string gauge) => base.WireUp(length, gauge);
}