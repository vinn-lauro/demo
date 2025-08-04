namespace Demo.Sample;

public class Archer : AbstractPlayer
{
    private Archer() { }
    public override string Name { get; set; } = "Player - Archer";

    private static Archer _instance;
    public static Archer Instance
    {
        get
        {
            if (_instance == null) _instance = new Archer();
            return _instance;
        }
    }
}
