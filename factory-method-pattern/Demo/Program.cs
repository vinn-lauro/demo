namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        IFactory factoryA = new ConcreteFactoryA();
        AbstractProduct productA = factoryA.CreateProduct();

        IFactory factoryB = new ConcreteFactoryB();
        AbstractProduct productB = factoryB.CreateProduct();
    }
}

abstract class AbstractProduct
{
    protected AbstractProduct()
    {
        Console.WriteLine($"{GetType()} Created!");
    }
}

class ConcreteProductA : AbstractProduct { }
class ConcreteProductB : AbstractProduct { }

interface IFactory
{
    AbstractProduct CreateProduct();
}

class ConcreteFactoryA : IFactory
{
    public AbstractProduct CreateProduct() => new ConcreteProductA();
}

class ConcreteFactoryB : IFactory
{
    public AbstractProduct CreateProduct() => new ConcreteProductB();
}