class Client
{
    private IProductA _productA;
    private IProductB _productB;

    public Client(IFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void DoInteraction() => _productB.Interact(_productA);
    public void DoReverseInteraction() => _productA.Interact(_productB);
}