namespace Sample;

class KeyboardSale : IFactory
{
    public AbstractOrderForm CreateForm() => new SaleForm();

    public AbstractInstrument CreateInstrument() => new Keyboard();
}
