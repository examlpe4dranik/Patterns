namespace PatternRunner.PatternComposite
{
    public class Leaf : IComponent
    {
        private int _value;

        public Leaf(int value)
        {
            _value = value;
        }

        public IComponent Add(IComponent component) => this;

        public int Sum() => _value;
    }
}