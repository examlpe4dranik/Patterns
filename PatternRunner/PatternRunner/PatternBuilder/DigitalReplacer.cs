using System.Text.RegularExpressions;

namespace PatternRunner.PatternBuilder
{
    internal class DigitalReplacer : IReplacer
    {
        private string _replacerPattern = @"[0-9]";
        private string _replacerMarker = "#";

        public DigitalReplacer()
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

        public string Replace(string value)
        {
            var regex = new Regex(_replacerPattern);
            return regex.Replace(value, _replacerMarker);
        }
    }
}