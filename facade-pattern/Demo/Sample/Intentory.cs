namespace Sample;

public class Inventory
{
    public int Check()
    {
        Random currentInventory = new Random();
        return currentInventory.Next(4);
    }
}
