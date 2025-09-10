namespace Demo.RealSample;

delegate void StateChangeHandler(ISubject subject);

enum DemandStatus { Normal, High, Low, }

interface ISubject
{
    event StateChangeHandler OnStateChange;
    DemandStatus State { get; set; }
    float Price { get; set; }
    string Name { get; set; }
}

class Product : ISubject
{
    public string Name { get; set; }
    public float Price { get; set; }

    public Product(string name, float price)
    {
        Name = name;
        Price = price;
    }

    private StateChangeHandler _onStateChange;
    public event StateChangeHandler OnStateChange
    {
        add { _onStateChange += value; }
        remove { _onStateChange -= value; }
    }

    private DemandStatus _state;

    public DemandStatus State
    {
        get { return _state; }
        set
        {
            if (_state == value) return;
            else
            {
                _state = value;
                notify();
            }
        }
    }

    private void notify()
    {
        if (_onStateChange != null) _onStateChange(this);
    }
}

interface IObserver
{
    void Register(ISubject subject);
    void Notify(ISubject subject);
}

abstract class Observer : IObserver
{
    public virtual void Notify(ISubject subject)
    {
        Console.WriteLine("{0} noticed {1}'s {2} changed to {3}",
        this.GetType().Name,
        subject.Name,
        subject.State.GetType().Name,
        subject.State
            );
    }

    public void Register(ISubject subject)
    {
        subject.OnStateChange += Notify;
    }
}

class PriceAdjustment : Observer
{
    public override void Notify(ISubject subject)
    {
        if (subject.State == DemandStatus.High)
        {
            subject.Price *= 1.2f;
            Console.WriteLine($"...Price adjusted +25% to {subject.Price} \n");
        }
        else if (subject.State == DemandStatus.Low)
        {
            subject.Price /= 1.2f;
            Console.WriteLine($"...Price adjusted -25% to {subject.Price} \n");
        }
        else
        {
            Console.WriteLine("...No price adjustment \n");
        }
    }
}

class EmailSupplier : Observer
{
    public override void Notify(ISubject subject)
    {
        if (subject.State == DemandStatus.Low)
        {
            base.Notify(subject);
            Console.WriteLine("...Emailing  Status  of Supplier \n");
        }
    }
}