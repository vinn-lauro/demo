class ProductB2 : IProductB
{
    public void Interact(IProductA productA) =>
        Console.WriteLine($"Interact {this.GetType().Name} with {productA.GetType().Name}");
}
