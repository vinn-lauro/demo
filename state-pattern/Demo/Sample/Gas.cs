namespace Demo.Sample;

class Gas : IState
{
    public void Draw(ICompound material)
    {
        Console.WriteLine("****\n****\n  *");
    }

    public void StateCheck(ICompound material)
    {
        if (material.Temperature <= 0)
            material.State = new Solid();
        else if (material.Temperature < 100)
            material.State = new Liquid();
    }
}