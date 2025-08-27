namespace Demo;

class ProxySubject : Subject
{
    private ConcreteSubject Subject;
    public ProxySubject() => Subject = new ConcreteSubject();
    public void Request() => Subject.Request();
}