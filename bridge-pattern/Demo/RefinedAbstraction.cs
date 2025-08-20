namespace Demo;

class RefinedAbstraction : BaseAbstraction
{
    public override void Operation()
    {
        Implementation!.Operation();
    }
}