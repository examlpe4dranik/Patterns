namespace PatternRunner.PatternDecorator
{
    internal class DigitSummator : DigitHandlerDecorator, IDigitHandler
    {
        public DigitSummator(IDigitHandler handler) : base(handler)
        {
        }

        public int Sum()
        {
            int result = 0;

            Source.Collection().ToList().ForEach(c => result += c);

            return result;
        }
    }
}