namespace PatternRunner.PatternAbstractFactory
{
    public class AbstractFactorySolution : IPatternSolution
    {
        public void Execute()
        {
            var logic1 = new TargetLogic(new FactoryA());
            Console.WriteLine(logic1.BasicFunc());

            var logic2 = new TargetLogic(new FactoryB());
            Console.WriteLine(logic2.BasicFunc());
            Console.WriteLine(logic2.ExtendedFunc());
        }
    }
}