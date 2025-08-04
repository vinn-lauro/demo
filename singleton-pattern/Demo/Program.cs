using Demo.Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Singleton singleton = Singleton.Instance;
        Console.WriteLine(Singleton.Instance.Counter++);
        Console.WriteLine(Singleton.Instance.Counter++);

        AbstractPlayer player;

        player = Knight.Instance;
        player.Attack();

        player = Archer.Instance;
        player.Attack();
    }
}
