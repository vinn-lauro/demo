namespace Demo;

class ConcreteSubject : Subject
{
    public void Request() =>
        Console.WriteLine("Concrete Subject's Real Request() called.");
}
