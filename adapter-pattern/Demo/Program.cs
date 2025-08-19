namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Target target = new Adapter();
        target.Request();
    }
}
