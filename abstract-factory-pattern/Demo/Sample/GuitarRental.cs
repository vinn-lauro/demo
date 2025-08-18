namespace Sample;

class GuitarRental : IFactory
{
    public AbstractOrderForm CreateForm() => new RentForm();

    public AbstractInstrument CreateInstrument() => new Guitar();
}
