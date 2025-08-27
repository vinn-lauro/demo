using Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Facade facade = new Facade();
        facade.FacadeMethodB();
        new FacadeOrder().PlaceOrder();
    }
}
