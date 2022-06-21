namespace PatternRunner.PatternDecorator
{
    internal class DigitRounder : DigitHandlerDecorator, IDigitHandler
    {
        public DigitRounder(IDigitHandler handler) : base(handler)
        {
        }

        public override decimal Avg() => Math.Round(base.Avg(), 2, MidpointRounding.AwayFromZero);
    }
}