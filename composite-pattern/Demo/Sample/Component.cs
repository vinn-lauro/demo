using System.ComponentModel;

namespace Demo.Sample;

public abstract class Component
{
    protected string name;
    public GameObject? Parent;
    public Component(string name) => this.name = name;
    public abstract void Add(Component component);
    public abstract void Remove(Component component);

    public virtual void TraceFwd()
    {
        Console.WriteLine("\n" + name + " (Composite) has connected to it:");
        GameObject g = (this as GameObject)!;
        foreach (Component c in g.subComponents)
            c.TraceFwd();
    }

    public virtual void TraceBck()
    {
        Console.WriteLine(this.name);
        if (Parent != null)
        {
            Console.WriteLine(" Traces Back To ");
            Parent.TraceBck();
        }
        Console.WriteLine();
    }
}
