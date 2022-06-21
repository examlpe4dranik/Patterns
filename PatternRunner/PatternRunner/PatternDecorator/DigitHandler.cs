namespace PatternRunner.PatternDecorator
{
    internal class DigitHandler : IDigitHandler
    {
        private readonly List<int> _collection;

        public DigitHandler(IEnumerable<int> collaction)
        {
            _collection = collaction.ToList();
        }

        public decimal Avg()
        {
            decimal result = decimal.Zero;

            _collection.ForEach(c => result += c);
            result /= _collection.Count;

            return result;
        }

        public IEnumerable<int> Collection()
        {
            var result = new List<int>();

            _collection.ForEach(c => result.Add(c));

            return result;
        }
    }
}