namespace Demo.Sample;

public class Knight : AbstractPlayer
{
    private Knight() { }
    public override string Name { get; set; } = "Player - Knight";

    private static Knight _instance;
    public static Knight Instance
    {
        get
        {
            if (_instance == null) _instance = new Knight();
            return _instance;
        }
    }
}
