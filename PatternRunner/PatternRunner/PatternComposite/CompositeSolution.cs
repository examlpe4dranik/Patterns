namespace PatternRunner.PatternComposite
{
    public class CompositeSolution : IPatternSolution
    {
        public void Execute()
        {
            var li = new List<Leaf>();
            for (int i = 0; i < 10; i++)
            {
                li.Add(new Leaf(i));
            }

            li.ForEach(l => Console.Write($"{l.Sum()}-"));
            Console.WriteLine();

            var root = new Composite();
            root.Add(new Composite().Add(li[0]).Add(li[1]).Add(li[2]));
            root.Add(new Composite().Add(new Composite().Add(li[3]).Add(li[4]).Add(li[5])));
            root.Add(new Composite().Add(new Composite().Add(new Composite().Add(li[6]).Add(li[7]).Add(li[8]).Add(li[9]))));

            Console.WriteLine($"root: {root.Sum()}");
        }
    }
}