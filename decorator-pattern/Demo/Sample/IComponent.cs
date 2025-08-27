using System.ComponentModel;

namespace Demo.Sample;

public interface IWindowComponent
{
    void Draw();
}

class Window : IWindowComponent
{
    public void Draw()
    {
        Console.WriteLine("Draw a window");
    }
}

abstract class WindowDecorator : IWindowComponent
{
    protected IWindowComponent _component;

    public void AttachComponent(IWindowComponent component) => _component = component;

    public virtual void Draw()
    {
        if (_component != null) _component.Draw();
    }
}

class Border : WindowDecorator
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Draw a border");
    }
}

class Shadow : WindowDecorator
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Draw a shadow");
    }
}