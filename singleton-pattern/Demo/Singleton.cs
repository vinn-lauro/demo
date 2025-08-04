namespace Demo;

public class Singleton
{
    public int Counter;
    private Singleton() { }

    private static Singleton _instance;

    public static Singleton Instance
    {
        get
        {
            if (_instance == null) _instance = new Singleton();
            return _instance;
        }
    }
}