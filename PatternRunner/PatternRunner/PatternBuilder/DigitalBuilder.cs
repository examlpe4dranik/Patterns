namespace PatternRunner.PatternBuilder
{
    internal class DigitalBuilder : IBuilder
    {
        private readonly IReplacer _replacer;

        public DigitalBuilder()
        {
            _replacer = new DigitalReplacer();
        }

        public IReplacer GetReplacer() => _replacer;

        public void SetMarker(string value) => _replacer.SetMarker(value);

        public void SetPattern(string value) => _replacer.SetPattern(value);

        public void SetPostfix(string value)
        {
        }
    }
}