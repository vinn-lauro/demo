class ProductA2 : IProductA
{
    public void Interact(IProductB productB) =>
        Console.WriteLine($"Interact {this.GetType().Name} with {productB.GetType().Name}");
}
