namespace Demo;

class DeepCopyPrototype : AbstractPrototype
{
    public DeepCopyPrototype(string name) : base(name) { }

    public override AbstractPrototype Clone()
    {
        AbstractPrototype clone = (DeepCopyPrototype)this.MemberwiseClone();
        clone.Reference = new PrototypeReference();
        return clone;
    }
}