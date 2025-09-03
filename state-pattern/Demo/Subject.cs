namespace Demo;

class Subject
{
    public IState State;

    public Subject(IState state) => State = state;

    public void StateChange() => State.Switch(this);
}

