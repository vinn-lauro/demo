namespace Sample;

class ImageResource : ImageSubject
{
    public string URL { get; set; }
    public void Request()
    {
        var random = new Random();
        if (random.Next(2) < 1) URL = null;
        else URL = "Some Image IRL";
    }
}
