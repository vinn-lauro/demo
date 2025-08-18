namespace Sample;

class Guitar : AbstractInstrument
{
    public override string GetManufacturer() => Manufacturer!;

    public override void SetManufacturer(string manufacturer) => Manufacturer = $"{manufacturer} {GetType().Name}";
}
