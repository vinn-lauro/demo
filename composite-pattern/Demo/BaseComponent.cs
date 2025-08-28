namespace Demo;

abstract class BaseComponent
{
    protected string Name;
    public BaseComponent(string name) => Name = name;
    public abstract void Add(BaseComponent component);
    public abstract void Remove(BaseComponent component);
    public virtual void WireUp(int length, string gauge)
    {
        string wire = "";
        for (int i = 1; i < length; i++)
        {
            wire += " ";
        }
        wire += gauge;
        Console.WriteLine(wire + Name);
    }
}
