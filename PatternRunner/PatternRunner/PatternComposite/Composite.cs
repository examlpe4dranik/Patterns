namespace PatternRunner.PatternComposite
{
    public class Composite : IComponent
    {
        private List<IComponent> _children;

        public Composite()
        {
            _children = new List<IComponent>();
        }

        public IComponent Add(IComponent component)
        {
            _children.Add(component);
            return this;
        }

        public int Sum()
        {
            int sum = 0;

            _children.ForEach(c => sum += c.Sum());

            return sum;
        }
    }
}