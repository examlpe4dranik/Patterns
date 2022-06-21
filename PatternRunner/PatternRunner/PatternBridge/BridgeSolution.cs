namespace PatternRunner.PatternBridge
{
    internal class BridgeSolution : IPatternSolution
    {
        public void Execute()
        {
            var bridge = new BridgeOperator();

            Out(bridge.Sum(2, 2).ToString());
            Out(bridge.Sum("ABC", "xyz"));
            Out(bridge.Multiply(3, 3).ToString());
            Out(bridge.Multiply("123", "qwe"));
            Out(bridge.Multiply("1234", "qwe"));
            Out(bridge.Multiply("123", "qwer"));
            Out(bridge.Multiply(string.Empty, "empty"));
            Out(bridge.Multiply("empty".ToUpper(), string.Empty));
        }

        private static void Out(string value) => Console.WriteLine(value);
    }
}