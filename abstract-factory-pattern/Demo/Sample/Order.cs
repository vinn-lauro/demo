namespace Sample;

class Order
{
    private AbstractInstrument _instrument;
    private AbstractOrderForm _form;
    public Order(IFactory factory)
    {
        _instrument = factory.CreateInstrument();
        _form = factory.CreateForm();
    }

    public void CompleteOrder(string manufacturer) => _form.Assign(_instrument, manufacturer);
}