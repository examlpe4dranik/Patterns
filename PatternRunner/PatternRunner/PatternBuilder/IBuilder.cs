namespace PatternRunner.PatternBuilder
{
    internal interface IBuilder
    {
        void SetPattern(string value);

        void SetMarker(string value);

        void SetPostfix(string value);

        IReplacer GetReplacer();
    }
}