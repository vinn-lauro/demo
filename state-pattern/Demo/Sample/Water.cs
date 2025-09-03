namespace Demo.Sample;

class Water : ICompound
{
    private int _temperature;

    public Water(IState state, int temp)
    {
        State = state;
        Temperature = temp;
    }
    public int Temperature
    {
        get
        {
            return _temperature;
        }
        set
        {
            _temperature = value;
            StateCheck();
        }
    }
    public IState State { get; set; }



    public void Draw()
    {
        State.Draw(this);
    }

    private void StateCheck()
    {
        State.StateCheck(this);
    }
}
