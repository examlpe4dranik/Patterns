namespace PatternRunner.PatternBuilder
{
    internal interface IReplacer
    {
        string Replace(string value);

        IReplacer SetPattern(string pattern);

        IReplacer SetMarker(string marker);
    }
}