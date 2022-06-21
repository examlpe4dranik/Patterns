namespace PatternRunner.PatternSolutions
{
    internal class SingletonSolution : IPatternSolution
    {
        public void Execute()
        {
            FirstCall();
            SecondCall();
        }

        private static void FirstCall()
        {
            Singleton.Instance().SetData(nameof(FirstCall));
            OutputConsole();
        }

        private static void SecondCall()
        {
            Singleton.Instance().SetData(nameof(SecondCall));
            OutputConsole();
        }

        private static void OutputConsole()
        {
            Console.WriteLine($"{Singleton.Instance().GetData()}");
        }
    }
}