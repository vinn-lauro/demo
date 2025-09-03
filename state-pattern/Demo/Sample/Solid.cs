namespace Demo.Sample;

class Solid : IState
{
    public void Draw(ICompound material)
    {
        Console.WriteLine("[][][][][]");
    }

    public void StateCheck(ICompound material)
    {
        if (material.Temperature > 0)
            material.State = new Liquid();
        else if (material.Temperature >= 100)
            material.State = new Gas();
    }
}
