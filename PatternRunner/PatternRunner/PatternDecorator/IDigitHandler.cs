namespace PatternRunner.PatternDecorator
{
    internal interface IDigitHandler
    {
        decimal Avg();

        IEnumerable<int> Collection();
    }
}