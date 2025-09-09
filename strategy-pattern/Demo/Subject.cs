namespace Demo;

class Subject
{
    private IStrategy _strategy;
    public Subject(IStrategy strategy) => _strategy = strategy;

    public void CallAlgorithm() => _strategy.Algorithm();
}