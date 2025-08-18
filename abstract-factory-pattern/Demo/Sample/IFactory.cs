namespace Sample;

interface IFactory
{
    AbstractInstrument CreateInstrument();
    AbstractOrderForm CreateForm();
}
