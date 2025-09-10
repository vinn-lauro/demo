
using Demo.RealSample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject("My Channel");
        AbstractObserver subscriberA = new ObserverA();
        AbstractObserver subscriverB = new ObserverB();

        subject.AddObserver(subscriberA);
        subject.AddObserver(subscriverB);

        subject.Notify();

        ISubject product = new Product("Product 1", 50f);
        Observer observerA = new PriceAdjustment();
        Observer observerB = new EmailSupplier();

    }
}
