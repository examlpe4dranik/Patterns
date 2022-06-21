using System.Text.RegularExpressions;

namespace PatternRunner.PatternBuilder
{
    internal class CharReplacer : IReplacer
    {
        private string _replacerPattern = @"[a-zA-z]";
        private string _replacerMarker = "#";
        private string _postfix = string.Empty;

        public CharReplacer()
        {
        }

        public IReplacer SetPattern(string pattern)
        {
            _replacerPattern = pattern;
            return this;
        }

        public IReplacer SetMarker(string marker)
        {
            _replacerMarker = marker;
            return this;
        }

        public IReplacer SetPostfix(string value)
        {
            _postfix = value;
            return this;
        }

        public string Replace(string value)
        {
            var regex = new Regex(_replacerPattern);
            return regex.Replace(value, _replacerMarker) + _postfix;
        }
    }
}