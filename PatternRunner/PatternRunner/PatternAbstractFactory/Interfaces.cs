namespace PatternRunner.PatternAbstractFactory
{
    public interface IFactory
    {
        IProduct GetProduct();
    }

    public interface IProduct
    {
        string Name();

        string ExtendedFunc();
    }
}