using System.ComponentModel;
using Demo.Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        BaseComponent baseComponent = new BaseComponent();
        Decorator a = new DecoratorA();
        Decorator b = new DecoratorB();
        a.AttachComponent(baseComponent);
        b.AttachComponent(a);
        b.Operation();

        Window window = new Window();
        WindowDecorator border = new Border();
        WindowDecorator shadow = new Shadow();
        border.AttachComponent(window);
        shadow.AttachComponent(border);
        shadow.Draw();
    }
}

interface IComponent
{
    void Operation();
}

class BaseComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("Base Component Operation!");
    }
}

abstract class Decorator : IComponent
{
    protected IComponent _component;
    public void AttachComponent(IComponent component) => _component = component;
    public virtual void Operation()
    {
        if (_component != null) _component.Operation();
    }
}

class DecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("Decorator A Operation");
    }
}

class DecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("Decorator B Operation");
    }
}