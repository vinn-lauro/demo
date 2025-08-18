namespace Sample;

public abstract class AbstractInstrument
{
    protected string? Manufacturer;
    public abstract void SetManufacturer(string manufacturer);
    public abstract string GetManufacturer();
}
