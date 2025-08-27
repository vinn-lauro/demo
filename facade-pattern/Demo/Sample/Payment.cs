namespace Sample;

class Payment
{
    public bool Process()
    {
        Random isSuccessful = new Random();
        if (isSuccessful.Next(2) < 1) return false;
        else return true;
    }
}
