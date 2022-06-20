namespace PatternRunner.PatternBridge
{
    public interface IBridgeOperator
    {
        int Sum(int termFirst, int termSecond);

        int Multiply(int termFirst, int termSecond);

        string Sum(string termFirst, string termSecond);

        string Multiply(string termFirst, string termSecond);
    }
}