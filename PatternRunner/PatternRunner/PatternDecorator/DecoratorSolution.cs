namespace PatternRunner.PatternDecorator
{
    internal class DecoratorSolution : IPatternSolution
    {
        public void Execute()
        {
            var collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 11 };

            var digitHander = new DigitHandler(collection);
            Console.WriteLine($"{nameof(DigitHandler)}: {nameof(digitHander.Avg)} = {digitHander.Avg()}");

            var decorator = new DigitHandlerDecorator(digitHander);
            Console.WriteLine($"{nameof(DigitHandlerDecorator)}: {nameof(decorator.Avg)} = {decorator.Avg()}");

            var rounder = new DigitRounder(digitHander);
            Console.WriteLine($"{nameof(DigitRounder)}: {nameof(rounder.Avg)} = {rounder.Avg()}");

            var summator = new DigitSummator(rounder);
            Console.WriteLine($"{nameof(DigitSummator)}: {nameof(summator.Sum)} = {summator.Sum()}");
        }
    }
}