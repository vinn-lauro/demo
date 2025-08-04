namespace Demo;

abstract class AbstractPrototype
{
    public PrototypeReference Reference = new PrototypeReference();
    public string Name;
    public AbstractPrototype(string name) => Name = name;

    public abstract AbstractPrototype Clone();
}

class PrototypeReference { public int x; }