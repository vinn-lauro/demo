namespace Demo.Sample;

public class Wizard : AbstractPlayer
{
    private Wizard() { }
    public override string Name { get; set; } = "Player - Wizard";

    private static Wizard _instance;
    public static Wizard Instance
    {
        get
        {
            if (_instance == null) _instance = new Wizard();
            return _instance;
        }
    }
}
