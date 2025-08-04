namespace Demo;

public sealed class SingletonAsync
{
    private SingletonAsync() { }

    private static volatile SingletonAsync instance;
    private static object syncRoot = new Object();

    public static SingletonAsync Instace
    {
        get
        {
            if (instance == null)
                lock (syncRoot)
                    if (instance == null)
                        instance = new SingletonAsync();

            return instance;
        }
    }
}