using Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new ProxySubject();
        subject.Request();

        ImageSubject imgSubject = new ImageProxy();
        imgSubject.Request();
        Console.WriteLine(imgSubject.URL);
    }
}
