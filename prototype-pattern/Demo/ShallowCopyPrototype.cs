namespace Demo;

class ShallowCopyPrototype : AbstractPrototype
{
    public ShallowCopyPrototype(string name) : base(name) { }
    public override AbstractPrototype Clone()
    {
        //returns object reference 
        return (ShallowCopyPrototype)this.MemberwiseClone();
    }
}