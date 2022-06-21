namespace PatternRunner.PatternFacade
{
    internal class ProccessFacade
    {
        private readonly Cleaner _cleaner;
        private readonly Spliter _spliter;

        public ProccessFacade(Cleaner cleaner)
        {
            _cleaner = cleaner;
            _spliter = new Spliter();
        }

        public string GetProcessed(string inputString)
        {
            var resultSplit = _spliter.Do(inputString);

            var resultCollection = new List<string>();
            foreach (var str in resultSplit)
            {
                resultCollection.Add(_cleaner.Do(str));
            }

            return Join(resultCollection, " ");
        }

        private static string Join(IEnumerable<string> collection, string separator)
        {
            var result = string.Empty;

            collection.ToList().ForEach(s => result += s + separator);

            return result[1..^separator.Length];
        }
    }
}