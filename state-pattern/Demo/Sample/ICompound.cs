namespace Demo.Sample;

interface ICompound
{
    int Temperature { get; set; }
    IState State { get; set; }
    void Draw();
}
