namespace Demo;

class Adapter : Target
{
    private Adaptee _adaptee = new Adaptee();
    public override void Request()
    {
        _adaptee.MismatchingRequest();
    }
}
