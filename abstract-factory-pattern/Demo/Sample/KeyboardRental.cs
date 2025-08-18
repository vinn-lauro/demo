namespace Sample;

class KeyboardRental : IFactory
{
    public AbstractOrderForm CreateForm() => new RentForm();

    public AbstractInstrument CreateInstrument() => new Keyboard();
}
