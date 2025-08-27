namespace Sample;

class FacadeOrder
{
    private Inventory inventory = new Inventory();
    private Payment payment = new Payment();
    private Notify notify = new Notify();

    public void PlaceOrder()
    {
        if (inventory.Check() > 0 && payment.Process())
        {
            notify.SendEmail();
            Console.WriteLine("Order Successful! Details have been sent to email.");
        }
        else
            Console.WriteLine("Order Failed! Your order could not be processed");
    }
}