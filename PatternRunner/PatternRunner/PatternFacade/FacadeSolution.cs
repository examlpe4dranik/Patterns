namespace PatternRunner.PatternFacade
{
    internal class PatternFacade : IPatternSolution
    {
        public void Execute()
        {
            string inputString = "one!-#tow#--three--@four-five-six-seven-eight-n!ne--t@n-$$#$&&-&^%%+++";
            Console.WriteLine($"{nameof(inputString)}: {inputString}");

            LongPathWithoutFacade(inputString);

            ShortPathWithFacade(inputString);
        }

        private void LongPathWithoutFacade(string inputString)
        {
            Console.WriteLine($"=={nameof(LongPathWithoutFacade)}==");

            var spliter = new Spliter();
            var resultSplit = spliter.Do(inputString);
            Console.Write($"{nameof(resultSplit)}: ");
            var collection = resultSplit.ToList();
            collection.ForEach(s => Console.Write($"{s} "));
            Console.WriteLine();

            Console.Write($"{nameof(Cleaner)}: ");
            foreach (var str in collection)
            {
                var cleaner = new Cleaner();
                var resultClean = cleaner.Do(str);
                Console.Write($"{resultClean} ");
            }
            Console.WriteLine();
            Console.WriteLine("===========");
        }

        private void ShortPathWithFacade(string inputString)
        {
            Console.WriteLine($"=={nameof(ShortPathWithFacade)}==");

            var facade = new ProccessFacade(new Cleaner().SetPattern(@"\W{2,}"));
            Console.WriteLine($"{nameof(ProccessFacade)}: {facade.GetProcessed(inputString)}");

            Console.WriteLine("===========");
        }
    }
}