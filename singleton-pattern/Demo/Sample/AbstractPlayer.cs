namespace Demo.Sample;

public abstract class AbstractPlayer
{
    public abstract string Name { get; set; }

    public virtual void Attack()
    {
        Console.WriteLine(Name + "- Attacked!");
    }
}