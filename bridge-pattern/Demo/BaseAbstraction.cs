namespace Demo;

abstract class BaseAbstraction
{
    public AbstractImplementation? Implementation;

    public virtual void Operation()
    {
        Implementation!.Operation();
    }
}
