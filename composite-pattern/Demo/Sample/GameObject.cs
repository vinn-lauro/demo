namespace Demo.Sample;

public class GameObject : Component
{
    public GameObject(string name) : base(name) { }
    public List<Component> subComponents = new List<Component>();
    public override void Add(Component component)
    {
        component.Parent = this;
        subComponents.Add(component);
    }
    public override void Remove(Component component)
    {
        subComponents.Remove(component);
    }


}
