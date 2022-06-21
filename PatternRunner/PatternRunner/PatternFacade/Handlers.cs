using System.Text.RegularExpressions;

namespace PatternRunner.PatternFacade
{
    internal class Spliter
    {
        private readonly string[] Separators;

        public Spliter()
        {
            Separators = new string[] { ",", "-", ";", " " };
        }

        public IEnumerable<string> Do(string source)
        {
            foreach (var separator in Separators)
            {
                var result = source.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (result.Length > 1)
                {
                    return result;
                }
            }

            return DefaultDo();
        }

        private static string[] DefaultDo() => Array.Empty<string>();
    }

    internal class Cleaner
    {
        private const string TargetPatternDefault = @"\W+";
        private Regex _regex;

        public Cleaner()
        {
            _regex = new Regex(TargetPatternDefault);
        }

        public string Do(string source) => _regex.Replace(source, string.Empty);

        public Cleaner SetPattern(string pattern)
        {
            _regex = new Regex(pattern);

            return this;
        }
    }
}