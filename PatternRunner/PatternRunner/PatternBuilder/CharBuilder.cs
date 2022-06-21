namespace PatternRunner.PatternBuilder
{
    internal class CharBuilder : IBuilder
    {
        private readonly IReplacer _replacer;

        public CharBuilder()
        {
            _replacer = new CharReplacer();
        }

        public IReplacer GetReplacer() => _replacer;

        public void SetMarker(string value) => _replacer.SetMarker(value);

        public void SetPattern(string value) => _replacer.SetPattern(value);

        public void SetPostfix(string value)
        {
            ((CharReplacer)_replacer).SetPostfix(value);
        }
    }
}