namespace Demo;

public sealed class SingletonModified
{
    private SingletonModified() { }

    private static readonly SingletonModified _instance = new SingletonModified();

    public static SingletonModified Instance { get { return _instance; } }
}