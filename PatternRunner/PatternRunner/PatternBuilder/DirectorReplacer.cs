namespace PatternRunner.PatternBuilder
{
    internal class DirectorReplacer
    {
        private readonly IBuilder _builder;

        public DirectorReplacer(IBuilder builder)
        {
            _builder = builder;
        }

        public IReplacer Contstruct(string pattern = null, string marker = null, string postfix = null)
        {
            if (pattern != null)
            {
                _builder.SetPattern(pattern);
            }

            if (marker != null)
            {
                _builder.SetMarker(marker);
            }

            if (postfix != null)
            {
                _builder.SetPostfix(postfix);
            }

            return _builder.GetReplacer();
        }
    }
}