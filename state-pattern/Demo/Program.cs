using Demo.Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject(new ConcreteStateA());
        subject.StateChange();
        subject.StateChange();
        subject.StateChange();
        subject.StateChange();
        subject.StateChange();
        subject.StateChange();

        ICompound water = new Water(new Liquid(), 100);
        water.Draw();
    }
}

