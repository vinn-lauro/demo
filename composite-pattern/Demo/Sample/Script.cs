namespace Demo.Sample;

class Script : Leaf
{
    public Script(string name) : base(name) { }

    public override void TraceFwd()
    {
        base.TraceFwd();
        Update();
    }

    private void Update() => Console.WriteLine("[Updating Loop Running]");
}