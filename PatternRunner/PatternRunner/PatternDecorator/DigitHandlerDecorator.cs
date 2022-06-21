namespace PatternRunner.PatternDecorator
{
    internal class DigitHandlerDecorator : IDigitHandler
    {
        protected IDigitHandler Source;

        public DigitHandlerDecorator(IDigitHandler handler)
        {
            Source = handler;
        }

        public virtual decimal Avg() => Source.Avg();

        public IEnumerable<int> Collection() => Source.Collection();
    }
}