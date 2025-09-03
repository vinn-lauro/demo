namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        AbstractTemplate a = new ConcreteTemplateA();
        a.Sequence();

        AbstractTemplate b = new ConcreteTemplateB();
        b.Sequence();
    }
}

abstract class AbstractTemplate
{
    public void Sequence()
    {
        Start();
        Process();
        Exit();
    }


    public abstract void Process();
    public void Start() => Console.WriteLine("Starting Application...");
    public void Exit() => Console.WriteLine("Exiting Application...");
}

class ConcreteTemplateA : AbstractTemplate
{
    public override void Process() => Console.WriteLine("Starting Concrete Template A Process...");
}

class ConcreteTemplateB : AbstractTemplate
{
    public override void Process() => Console.WriteLine("Starting Concrete Template B Process...");
}
