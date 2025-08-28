namespace Demo;

class Composite : BaseComponent
{
    public Composite(string name) : base(name) { }
    private List<BaseComponent> subComponents = new List<BaseComponent>();
    public override void Add(BaseComponent component) => subComponents.Add(component);
    public override void Remove(BaseComponent component) => subComponents.Remove(component);
    public override void WireUp(int length, string gauge)
    {
        base.WireUp(length, gauge);
        foreach (BaseComponent component in subComponents)
            component.WireUp(length + 1, gauge);
    }
}
