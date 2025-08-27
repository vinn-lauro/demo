namespace Sample;

class ImageProxy : ImageSubject
{
    private ImageResource imageResource;

    public string URL { get; set; }

    public void Request()
    {
        if (imageResource == null) imageResource = new ImageResource();
        imageResource.Request();
        if (imageResource.URL == null) URL = "Dummy Image URL";
        else URL = imageResource.URL;
    }
}