namespace Sample;

class RentForm : AbstractOrderForm
{
    public override void Assign(AbstractInstrument instrument, string manufacturer)
    {
        instrument.SetManufacturer(manufacturer);
        Console.WriteLine(String.Format("{0} created for a rented {1} of type {2}", this.GetType().Name, instrument.GetType().Name, instrument.GetManufacturer()));
    }
}
