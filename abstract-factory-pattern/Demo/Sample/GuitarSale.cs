namespace Sample;

class GuitarSale : IFactory
{
    public AbstractOrderForm CreateForm() => new SaleForm();

    public AbstractInstrument CreateInstrument() => new Guitar();
}
