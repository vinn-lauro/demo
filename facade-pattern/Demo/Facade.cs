namespace Demo;

class Facade
{
    private ModuleA a;
    private ModuleB b;
    private ModuleC c;

    public Facade()
    {
        a = new ModuleA();
        b = new ModuleB();
        c = new ModuleC();
    }

    public void FacadeMethodA()
    {
        Console.WriteLine("Facade Method A: ");
        a.OperationX();
        c.OperationZ();
    }


    public void FacadeMethodB()
    {
        Console.WriteLine("Facade Method B: ");
        b.OperationY();
        c.OperationZ();
    }


    public void FacadeMethodC()
    {
        Console.WriteLine("Facade Method C: ");
        c.OperationZ();
    }
}